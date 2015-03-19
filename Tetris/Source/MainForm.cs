using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;

namespace Tetris
{
    /// <summary>
    /// Направления движения фигуры (для передачи в метод)
    /// </summary>
    public enum Direction { Up, Down, Left, Right }

    public partial class MainForm : Form
    {
        public static MainForm Instance { get; set; }
        private Game Game { get; set; }
        private Dictionary<Keys, bool> KeysHolding { get; set; }
        private Dictionary<Keys, AutoResetEvent> KeysCancel { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        public static void BeginInvokeControl(Control control, Action action)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke(action);
            }
            else
            {
                action();
            }
        }

        public static void ShowError(string message)
        {
            MainForm.BeginInvokeControl(MainForm.Instance.errorLabel, new Action(() => { MainForm.Instance.errorLabel.Text = message; }));
            Animator.FlickerLabel(MainForm.Instance.errorLabel, 100, 10);
            SoundPlayer.PlaySound(SoundPlayer.Sounds.Error);
        }

        public static void CenterInfoLabel(string text)
        {
            BeginInvokeControl(MainForm.Instance.infoLabel, new Action(() => { MainForm.Instance.infoLabel.Text = text; }));
            BeginInvokeControl(MainForm.Instance.infoLabel, new Action(() => { MainForm.Instance.infoLabel.Location = new Point((MainForm.Instance.fieldPicture.Width - MainForm.Instance.infoLabel.Width) / 2, (MainForm.Instance.fieldPicture.Height - MainForm.Instance.infoLabel.Height) / 2); }));
        }

        private static void SetDoubleBuffered(Control parent)
        {
            typeof(Control).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, parent, new object[] { true });
            foreach (Control child in parent.Controls)
            {
                SetDoubleBuffered(child);
            }
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            Instance = this;
            SetDoubleBuffered(this);
            #region Инициализация состояний зажатых клавиш
            KeysHolding = new Dictionary<Keys, bool>();
            KeysHolding.Add(Keys.Left, false);
            KeysHolding.Add(Keys.Right, false);
            KeysHolding.Add(Keys.Down, false);
            KeysHolding.Add(Keys.Up, false);
            KeysHolding.Add(Keys.Space, false);
            KeysHolding.Add(Keys.Escape, false);
            KeysHolding.Add(Keys.Enter, false);
            #endregion
            #region Инициализация сигналов для сброса зажатых клавиши
            KeysCancel = new Dictionary<Keys, AutoResetEvent>();
            KeysCancel.Add(Keys.Left, new AutoResetEvent(false));
            KeysCancel.Add(Keys.Right, new AutoResetEvent(false));
            #endregion
            #region Изменение шрифтов
            PrivateFontCollection FontCollection = ResourceLoader.LoadFont();
            levelLabel.Font = new Font(FontCollection.Families[0], 24, FontStyle.Underline);
            levelNumberLabel.Font = new Font(FontCollection.Families[0], 20);
            scoreLabel.Font = new Font(FontCollection.Families[0], 24, FontStyle.Underline);
            scoreNumberLabel.Font = new Font(FontCollection.Families[0], 20);
            linesLabel.Font = new Font(FontCollection.Families[0], 24, FontStyle.Underline);
            linesNumberLabel.Font = new Font(FontCollection.Families[0], 20);
            nextLabel.Font = new Font(FontCollection.Families[0], 24, FontStyle.Underline);
            _1PlayerLabel.Font = new Font(FontCollection.Families[0], 18);
            _2PlayersLabel.Font = new Font(FontCollection.Families[0], 18);
            optionsLabel.Font = new Font(FontCollection.Families[0], 18);
            exitLabel.Font = new Font(FontCollection.Families[0], 18);
            copyrightLabel.Font = new Font(FontCollection.Families[0], 18);
            errorLabel.Font = new Font(FontCollection.Families[0], 18);
            openGameLabel.Font = new Font(FontCollection.Families[0], 18);
            joinGameLabel.Font = new Font(FontCollection.Families[0], 18);
            backLabel.Font = new Font(FontCollection.Families[0], 18);
            _0Label.Font = new Font(FontCollection.Families[0], 16);
            _1Label.Font = new Font(FontCollection.Families[0], 16);
            _2Label.Font = new Font(FontCollection.Families[0], 16);
            _3Label.Font = new Font(FontCollection.Families[0], 16);
            _4Label.Font = new Font(FontCollection.Families[0], 16);
            _5Label.Font = new Font(FontCollection.Families[0], 16);
            _6Label.Font = new Font(FontCollection.Families[0], 16);
            _7Label.Font = new Font(FontCollection.Families[0], 16);
            _8Label.Font = new Font(FontCollection.Families[0], 16);
            _9Label.Font = new Font(FontCollection.Families[0], 16);
            leftLabel.Font = new Font(FontCollection.Families[0], 16);
            rightLabel.Font = new Font(FontCollection.Families[0], 16);
            digit1Label.Font = new Font(FontCollection.Families[0], 16, FontStyle.Underline);
            digit2Label.Font = new Font(FontCollection.Families[0], 16, FontStyle.Underline);
            digit3Label.Font = new Font(FontCollection.Families[0], 16, FontStyle.Underline);
            dot1Label.Font = new Font(FontCollection.Families[0], 16);
            digit4Label.Font = new Font(FontCollection.Families[0], 16, FontStyle.Underline);
            digit5Label.Font = new Font(FontCollection.Families[0], 16, FontStyle.Underline);
            digit6Label.Font = new Font(FontCollection.Families[0], 16, FontStyle.Underline);
            dot2Label.Font = new Font(FontCollection.Families[0], 16);
            digit7Label.Font = new Font(FontCollection.Families[0], 16, FontStyle.Underline);
            digit8Label.Font = new Font(FontCollection.Families[0], 16, FontStyle.Underline);
            digit9Label.Font = new Font(FontCollection.Families[0], 16, FontStyle.Underline);
            dot3Label.Font = new Font(FontCollection.Families[0], 16);
            digit10Label.Font = new Font(FontCollection.Families[0], 16, FontStyle.Underline);
            digit11Label.Font = new Font(FontCollection.Families[0], 16, FontStyle.Underline);
            digit12Label.Font = new Font(FontCollection.Families[0], 16, FontStyle.Underline);
            infoLabel.Font = new Font(FontCollection.Families[0], 24);
            #endregion
            SoundPlayer.LoadMusic();
            SoundPlayer.LoadSounds();
            SoundPlayer.PlayMenu();
        }

        
        private void Switch(TableLayoutPanel listPanel, PictureBox selectorPicture, bool vertical = true, bool forward = true)
        {
            if (forward && vertical)
            {
                if (listPanel.GetRow(selectorPicture) < listPanel.RowCount - 1)
                    listPanel.SetRow(selectorPicture, listPanel.GetRow(selectorPicture) + 1);
                else
                    listPanel.SetRow(selectorPicture, 0);

            }
            else
                if (!forward && vertical)
                {
                    if (listPanel.GetRow(selectorPicture) > 0)
                        listPanel.SetRow(selectorPicture, listPanel.GetRow(selectorPicture) - 1);
                    else
                        listPanel.SetRow(selectorPicture, listPanel.RowCount - 1);
                }
                else
                {
                    if (forward && !vertical)
                    {
                        if (listPanel.GetColumn(selectorPicture) < listPanel.ColumnCount - 1)
                            listPanel.SetColumn(selectorPicture, listPanel.GetColumn(selectorPicture) + 1);
                        else
                            listPanel.SetColumn(selectorPicture, 0);
                    }
                    else
                    {
                        if (!forward && !vertical)
                        {
                            if (listPanel.GetColumn(selectorPicture) > 0)
                                listPanel.SetColumn(selectorPicture, listPanel.GetColumn(selectorPicture) - 1);
                            else
                                listPanel.SetColumn(selectorPicture, listPanel.ColumnCount - 1);
                        }
                    }
                }
            SoundPlayer.PlaySound(SoundPlayer.Sounds.Switch);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //проверка на неиспользуемые кнопки
            if (KeysHolding.ContainsKey(e.KeyCode))
            {
                //если не нажата
                if (!KeysHolding[e.KeyCode])
                {
                    KeysHolding[e.KeyCode] = true;
                    //проверяем текущую панель
                    if (this.Controls.GetChildIndex(menuPanel) == 0)
                    {
                        //если не работает анимация
                        if (!Animator.Active())
                        {
                            //если Ентер
                            if (e.KeyCode == Keys.Enter)
                            {
                                //если на синглплеере
                                if (menuListPanel.GetRow(menuSelectorPicture) == 0)
                                {
                                    Animator.FlickerLabel(_1PlayerLabel, 100, 10,
                                        delegate()
                                        {
                                            SoundPlayer.StopMenu();
                                            Game = new Game(fieldPicture);
                                            Game.Start();
                                            BeginInvokeControl(gamePanel, new Action(() => { gamePanel.BringToFront(); }));
                                        });
                                }
                                else
                                {
                                    //если мультиплеер
                                    if (menuListPanel.GetRow(menuSelectorPicture) == 1)
                                    {
                                        Animator.FlickerLabel(_2PlayersLabel, 100, 10,
                                            delegate()
                                            {
                                                BeginInvokeControl(networkPanel, new Action(() => { networkPanel.BringToFront(); }));
                                            });
                                    }
                                    else
                                    {
                                        //если ехит
                                        if (menuListPanel.GetRow(menuSelectorPicture) == 3)
                                        {
                                            Animator.FlickerLabel(exitLabel, 100, 10, delegate() { Application.Exit(); });
                                        }
                                    }
                                }
                                SoundPlayer.PlaySound(SoundPlayer.Sounds.Select_0);
                            }
                            else
                            {
                                //если вниз
                                if (e.KeyCode == Keys.Down)
                                {
                                    Switch(menuListPanel, menuSelectorPicture);
                                }
                                else
                                {
                                    //если вверх
                                    if (e.KeyCode == Keys.Up)
                                    {
                                        Switch(menuListPanel, menuSelectorPicture, forward: false);
                                    }
                                }
                            }
                        }
                    }
                    else
                        //если игра
                        if (this.Controls.GetChildIndex(gamePanel) == 0)
                        {
                            //на геймовере
                            if (e.KeyCode == Keys.Enter)
                            {
                                if (!SoundPlayer.SoundFinished(SoundPlayer.Sounds.GameOver) && !Game.Running)
                                {
                                    SoundPlayer.StopSound(SoundPlayer.Sounds.GameOver);
                                    infoLabel.Visible = false;
                                    menuPanel.BringToFront();
                                    SoundPlayer.PlayMenu();
                                }
                            }
                            else
                            {
                                //пауза
                                if (e.KeyCode == Keys.Escape)
                                {
                                    Game.Figure.Pause();
                                }
                                else
                                {
                                    if (e.KeyCode == Keys.Up)
                                    {
                                        Game.Figure.Rotate();
                                    }
                                    else
                                    {
                                        if (e.KeyCode == Keys.Down)
                                        {
                                            Game.Figure.Accelerate();
                                        }
                                        else
                                        {
                                            if (e.KeyCode == Keys.Space)
                                            {
                                                Game.Figure.Drop();
                                            }
                                            else
                                            {
                                                if (KeysCancel.ContainsKey(e.KeyCode))
                                                {
                                                    //поток для двигания вправо/влево с одинковой задержкой
                                                    Task.Factory.StartNew
                                                    (delegate()
                                                    {
                                                        while (true)
                                                        {
                                                            if (e.KeyCode == Keys.Left)
                                                            {
                                                                Game.Figure.Move(Direction.Left);
                                                            }
                                                            if (e.KeyCode == Keys.Right)
                                                            {
                                                                Game.Figure.Move(Direction.Right);
                                                            }
                                                            if (KeysCancel[e.KeyCode].WaitOne(100))
                                                            {
                                                                break;
                                                            }
                                                        }
                                                    });
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            //меню в мультиплеере
                            if (this.Controls.GetChildIndex(networkPanel) == 0)
                            {
                                //что ниего не мигало
                                if (!Animator.Active(openGameLabel, joinGameLabel, backLabel, errorLabel))
                                {
                                    if (e.KeyCode == Keys.Enter)
                                    {
                                        if (networkListPanel.GetRow(networkSelectorPicture) == 0)
                                        {
                                            Network.StartServer();
                                        }
                                        else
                                        {
                                            //нажатие на подключиться
                                            if (networkListPanel.GetRow(networkSelectorPicture) == 1)
                                            {
                                                string ipString = "";
                                                foreach (Control control in textPanel.Controls)
                                                {
                                                    ipString += control.Text;
                                                }
                                                Network.ConnectToServer(ipString);
                                            }
                                            else
                                            {
                                                //бэк
                                                if (networkListPanel.GetRow(networkSelectorPicture) == 2)
                                                {
                                                    Animator.FlickerLabel(backLabel, 100, 10,
                                                        delegate()
                                                        {
                                                            BeginInvokeControl(networkListPanel, new Action(() => { networkListPanel.SetRow(networkSelectorPicture, 0); }));
                                                            BeginInvokeControl(keyboardPanel, new Action(() => { keyboardPanel.SetColumn(keyboardSelectorPicture, 0); }));
                                                            BeginInvokeControl(textPanel, new Action(() => { textPanel.Tag = 0; }));
                                                            #region Сброс IP адреса
                                                            BeginInvokeControl(digit1Label, new Action(() => { digit1Label.Text = "1"; }));
                                                            BeginInvokeControl(digit2Label, new Action(() => { digit2Label.Text = "2"; }));
                                                            BeginInvokeControl(digit3Label, new Action(() => { digit3Label.Text = "7"; }));
                                                            BeginInvokeControl(digit4Label, new Action(() => { digit4Label.Text = "0"; }));
                                                            BeginInvokeControl(digit5Label, new Action(() => { digit5Label.Text = "0"; }));
                                                            BeginInvokeControl(digit6Label, new Action(() => { digit6Label.Text = "0"; }));
                                                            BeginInvokeControl(digit7Label, new Action(() => { digit7Label.Text = "0"; }));
                                                            BeginInvokeControl(digit8Label, new Action(() => { digit8Label.Text = "0"; }));
                                                            BeginInvokeControl(digit9Label, new Action(() => { digit9Label.Text = "0"; }));
                                                            BeginInvokeControl(digit10Label, new Action(() => { digit10Label.Text = "0"; }));
                                                            BeginInvokeControl(digit11Label, new Action(() => { digit11Label.Text = "0"; }));
                                                            BeginInvokeControl(digit12Label, new Action(() => { digit12Label.Text = "1"; }));
                                                            #endregion
                                                            BeginInvokeControl(menuPanel, new Action(() => { menuPanel.BringToFront(); }));
                                                        });
                                                    SoundPlayer.PlaySound(SoundPlayer.Sounds.Select_0);
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        //вверх/вниз в мультике меню
                                        if (e.KeyCode == Keys.Down)
                                        {
                                            Switch(networkListPanel, networkSelectorPicture);
                                        }
                                        else
                                        {
                                            if (e.KeyCode == Keys.Up)
                                            {
                                                Switch(networkListPanel, networkSelectorPicture, forward: false);
                                            }
                                        }
                                    }
                                    if (networkListPanel.GetRow(networkSelectorPicture) == 1 && !inputPanel.Visible)
                                    {
                                        inputPanel.Visible = true;
                                        Animator.FlickerLabel((Label)textPanel.Controls[Convert.ToInt32(textPanel.Tag)], 500, -1);
                                    }
                                    else
                                        if (networkListPanel.GetRow(networkSelectorPicture) != 1 && inputPanel.Visible)
                                        {
                                            Animator.CancelAnimation((Label)textPanel.Controls[Convert.ToInt32(textPanel.Tag)]);
                                            inputPanel.Visible = false;
                                        }
                                    if (inputPanel.Visible)
                                    {
                                        if (e.KeyCode == Keys.Left)
                                        {
                                            Switch(keyboardPanel, keyboardSelectorPicture, forward: false, vertical: false);
                                        }
                                        else
                                        {
                                            if (e.KeyCode == Keys.Right)
                                            {
                                                Switch(keyboardPanel, keyboardSelectorPicture, vertical: false);
                                            }
                                            else
                                            {
                                                if (e.KeyCode == Keys.Space)
                                                {
                                                    if (keyboardPanel.GetColumn(keyboardSelectorPicture) != 10)
                                                    {
                                                        if (keyboardPanel.GetColumn(keyboardSelectorPicture) < 10)
                                                        {
                                                            ((Label)textPanel.Controls[Convert.ToInt32(textPanel.Tag)]).Text = keyboardPanel.GetColumn(keyboardSelectorPicture).ToString();
                                                        }
                                                        if (Convert.ToInt32(textPanel.Tag) < 14)
                                                        {
                                                            Animator.CancelAnimation((Label)textPanel.Controls[Convert.ToInt32(textPanel.Tag)]);
                                                            textPanel.Tag = Convert.ToInt32(textPanel.Tag) + (((Label)textPanel.Controls[Convert.ToInt32(textPanel.Tag) + 1]).Text == "." ? 2 : 1);
                                                            Animator.FlickerLabel((Label)textPanel.Controls[Convert.ToInt32(textPanel.Tag)], 500, -1);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        if (Convert.ToInt32(textPanel.Tag) > 0)
                                                        {
                                                            Animator.CancelAnimation((Label)textPanel.Controls[Convert.ToInt32(textPanel.Tag)]);
                                                            textPanel.Tag = Convert.ToInt32(textPanel.Tag) - (((Label)textPanel.Controls[Convert.ToInt32(textPanel.Tag) - 1]).Text == "." ? 2 : 1);
                                                            Animator.FlickerLabel((Label)textPanel.Controls[Convert.ToInt32(textPanel.Tag)], 500, -1);
                                                        }
                                                    }
                                                    SoundPlayer.PlaySound(SoundPlayer.Sounds.Select_1);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                }
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (KeysHolding.ContainsKey(e.KeyCode))
            {
                KeysHolding[e.KeyCode] = false;
                if (this.Controls.GetChildIndex(gamePanel) == 0)
                {
                    if (e.KeyCode == Keys.Down)
                    {
                        Game.Figure.SlowDown();
                    }
                    else
                    {
                        if (KeysCancel.ContainsKey(e.KeyCode))
                        {
                            KeysCancel[e.KeyCode].Set();
                        }
                    }
                }
            }
        }

        private void inputPanel_Paint(object sender, PaintEventArgs e)
        {
            Drawing.PaintBorder(e.Graphics, Color.White, e.ClipRectangle);
        }

        private void infoLabel_Paint(object sender, PaintEventArgs e)
        {
            Drawing.PaintBorder(e.Graphics, Color.White, e.ClipRectangle);
        }
    }
}