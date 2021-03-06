﻿using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Tetris
{
    public class Game
    {
        public static bool Running { get; private set; }
        public Figure Figure { get; private set; }
        public Field Field { get; private set; }
        public int Level { get; private set; }
        public int Score { get; private set; }
        public int Lines { get; private set; }
        private Random Random { get; set; }
        private int LinesLeft { get; set; }        
        private int NextId { get; set; }       

        static Game()
        {
            Running = false;
        }

        public Game(PictureBox fieldPicture, int rn = 0)
        {
            if (rn == 0)
            {
                Random = new Random();
            }
            else
            {
                Random = new Random(rn);
            }
            Level = 1;
            Score = 0;
            Lines = 0;
            LinesLeft = 5 * Level;
            MainForm.BeginInvokeControl(MainForm.Instance.levelNumberLabel1, new Action(() => { MainForm.Instance.levelNumberLabel1.Text = Level.ToString(); }));
            MainForm.BeginInvokeControl(MainForm.Instance.scoreNumberLabel1, new Action(() => { MainForm.Instance.scoreNumberLabel1.Text = Score.ToString(); }));
            MainForm.BeginInvokeControl(MainForm.Instance.linesNumberLabel1, new Action(() => { MainForm.Instance.linesNumberLabel1.Text = Lines.ToString(); }));
            Field = new Field(fieldPicture);
        }

        public void Start()
        {
            Running = true;
            NextId = Random.Next(0, 6);
            SoundPlayer.PlayBackground();
            Task.Factory.StartNew
                (delegate()
                { 
                    while (true)
                    {
                        Figure = new Figure(this, NextId, Level <= 10 ? 1000 - (Level - 1) * 100 : 100 - Level % 10 * 10);
                        NextId = Random.Next(0, 6);
                        DrawNext();
                        int result = Figure.Activate();                       
                        if (result == 5)
                        {
                            Running = false;
                            Thread.Sleep(1500);
                            SoundPlayer.StopBackground();
                            SoundPlayer.PlaySound(SoundPlayer.Sounds.GameOver);
                            MainForm.BeginInvokeControl(MainForm.Instance.infoLabel1, new Action(() => { MainForm.Instance.infoLabel1.Visible = true; }));
                            MainForm.BeginInvokeControl(MainForm.Instance.infoLabel1, new Action(() => { MainForm.Instance.infoLabel1.Text = "Game\nOver"; }));
                            MainForm.CenterControl(MainForm.Instance.infoLabel1);
                            break;
                        }
                        else
                            if (result > 0)
                            {
                                Lines += result;
                                if (Level < 15)
                                {
                                    LinesLeft -= result;
                                    if (LinesLeft <= 0)
                                    {
                                        Level++;
                                        LinesLeft = (5 * Level) + LinesLeft;
                                        MainForm.BeginInvokeControl(MainForm.Instance.levelNumberLabel1, new Action(() => { MainForm.Instance.levelNumberLabel1.Text = Level.ToString(); }));
                                        Animator.FlickerLabel(MainForm.Instance.levelNumberLabel1, 100, 10);
                                    }
                                }
                                MainForm.BeginInvokeControl(MainForm.Instance.linesNumberLabel1, new Action(() => { MainForm.Instance.linesNumberLabel1.Text = Lines.ToString(); }));
                                
                            }
                        Score += result * (100 + 10 * (Level - 1)) + 10;
                        MainForm.BeginInvokeControl(MainForm.Instance.scoreNumberLabel1, new Action(() => { MainForm.Instance.scoreNumberLabel1.Text = Score.ToString(); }));
                    }
                });
        }

        private void DrawNext()
        {
            Bitmap bitmap = (NextId == 1 ? new Bitmap(4 * Figure.BrickSize, 1 * Figure.BrickSize) : (NextId == 2 ? new Bitmap(2 * Figure.BrickSize, 2 * Figure.BrickSize) : new Bitmap(3 * Figure.BrickSize, 2 * Figure.BrickSize)));
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Point position = (NextId == 1 ? new Point(1, -1) : (NextId == 2 ? new Point(0, 0) : new Point(1, 0)));
                for (int i = 0; i < 4; i++)
                {
                    Drawing.PaintCell(graphics, Figure.Colors[NextId], new Point(position.X + Figure.Schemas[NextId][0][i].X, position.Y + Figure.Schemas[NextId][0][i].Y), false);
                }
                Drawing.RefreshImage(MainForm.Instance.nextPicture1, bitmap);
            }
        }
    }
}
