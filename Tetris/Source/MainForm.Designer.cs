namespace Tetris
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fieldPanel = new System.Windows.Forms.Panel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.fieldPicture = new System.Windows.Forms.PictureBox();
            this.infoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nextLabel = new System.Windows.Forms.Label();
            this.linesNumberLabel = new System.Windows.Forms.Label();
            this.linesLabel = new System.Windows.Forms.Label();
            this.scoreNumberLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.levelNumberLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.nextPicture = new System.Windows.Forms.PictureBox();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.titlePicture = new System.Windows.Forms.PictureBox();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.menuListPanel = new System.Windows.Forms.TableLayoutPanel();
            this._1PlayerLabel = new System.Windows.Forms.Label();
            this._2PlayersLabel = new System.Windows.Forms.Label();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.menuSelectorPicture = new System.Windows.Forms.PictureBox();
            this.networkPanel = new System.Windows.Forms.TableLayoutPanel();
            this.networkListPanel = new System.Windows.Forms.TableLayoutPanel();
            this.joinGameLabel = new System.Windows.Forms.Label();
            this.backLabel = new System.Windows.Forms.Label();
            this.openGameLabel = new System.Windows.Forms.Label();
            this.networkSelectorPicture = new System.Windows.Forms.PictureBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.inputPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textPanel = new System.Windows.Forms.TableLayoutPanel();
            this.digit1Label = new System.Windows.Forms.Label();
            this.digit2Label = new System.Windows.Forms.Label();
            this.digit3Label = new System.Windows.Forms.Label();
            this.dot1Label = new System.Windows.Forms.Label();
            this.digit4Label = new System.Windows.Forms.Label();
            this.digit5Label = new System.Windows.Forms.Label();
            this.digit6Label = new System.Windows.Forms.Label();
            this.dot2Label = new System.Windows.Forms.Label();
            this.digit7Label = new System.Windows.Forms.Label();
            this.digit8Label = new System.Windows.Forms.Label();
            this.digit9Label = new System.Windows.Forms.Label();
            this.dot3Label = new System.Windows.Forms.Label();
            this.digit10Label = new System.Windows.Forms.Label();
            this.digit11Label = new System.Windows.Forms.Label();
            this.digit12Label = new System.Windows.Forms.Label();
            this.keyboardPanel = new System.Windows.Forms.TableLayoutPanel();
            this._0Label = new System.Windows.Forms.Label();
            this._1Label = new System.Windows.Forms.Label();
            this._2Label = new System.Windows.Forms.Label();
            this._3Label = new System.Windows.Forms.Label();
            this._4Label = new System.Windows.Forms.Label();
            this._5Label = new System.Windows.Forms.Label();
            this._6Label = new System.Windows.Forms.Label();
            this._7Label = new System.Windows.Forms.Label();
            this._8Label = new System.Windows.Forms.Label();
            this._9Label = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            this.keyboardSelectorPicture = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.fieldPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fieldPicture)).BeginInit();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextPicture)).BeginInit();
            this.gamePanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture)).BeginInit();
            this.menuListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuSelectorPicture)).BeginInit();
            this.networkPanel.SuspendLayout();
            this.networkListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkSelectorPicture)).BeginInit();
            this.inputPanel.SuspendLayout();
            this.textPanel.SuspendLayout();
            this.keyboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardSelectorPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.mainPanel.ColumnCount = 2;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 325F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.fieldPanel, 0, 0);
            this.mainPanel.Controls.Add(this.infoPanel, 1, 0);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 1;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Size = new System.Drawing.Size(481, 429);
            this.mainPanel.TabIndex = 1;
            // 
            // fieldPanel
            // 
            this.fieldPanel.Controls.Add(this.infoLabel);
            this.fieldPanel.Controls.Add(this.fieldPicture);
            this.fieldPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldPanel.Location = new System.Drawing.Point(2, 2);
            this.fieldPanel.Margin = new System.Windows.Forms.Padding(0);
            this.fieldPanel.Name = "fieldPanel";
            this.fieldPanel.Size = new System.Drawing.Size(325, 425);
            this.fieldPanel.TabIndex = 2;
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Black;
            this.infoLabel.Font = new System.Drawing.Font("Half Bold Pixel-7", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.White;
            this.infoLabel.Location = new System.Drawing.Point(112, 191);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(3);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 3);
            this.infoLabel.Size = new System.Drawing.Size(101, 42);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Info";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.infoLabel.Visible = false;
            this.infoLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.infoLabel_Paint);
            // 
            // fieldPicture
            // 
            this.fieldPicture.BackColor = System.Drawing.Color.Black;
            this.fieldPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldPicture.Location = new System.Drawing.Point(0, 0);
            this.fieldPicture.Margin = new System.Windows.Forms.Padding(0);
            this.fieldPicture.Name = "fieldPicture";
            this.fieldPicture.Size = new System.Drawing.Size(325, 425);
            this.fieldPicture.TabIndex = 0;
            this.fieldPicture.TabStop = false;
            // 
            // infoPanel
            // 
            this.infoPanel.ColumnCount = 1;
            this.infoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.infoPanel.Controls.Add(this.nextLabel, 0, 6);
            this.infoPanel.Controls.Add(this.linesNumberLabel, 0, 5);
            this.infoPanel.Controls.Add(this.linesLabel, 0, 4);
            this.infoPanel.Controls.Add(this.scoreNumberLabel, 0, 3);
            this.infoPanel.Controls.Add(this.scoreLabel, 0, 2);
            this.infoPanel.Controls.Add(this.levelNumberLabel, 0, 1);
            this.infoPanel.Controls.Add(this.levelLabel, 0, 0);
            this.infoPanel.Controls.Add(this.nextPicture, 0, 7);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPanel.Location = new System.Drawing.Point(329, 2);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.RowCount = 8;
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.infoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.infoPanel.Size = new System.Drawing.Size(150, 425);
            this.infoPanel.TabIndex = 1;
            // 
            // nextLabel
            // 
            this.nextLabel.AutoSize = true;
            this.nextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextLabel.Font = new System.Drawing.Font("Half Bold Pixel-7", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextLabel.ForeColor = System.Drawing.Color.White;
            this.nextLabel.Location = new System.Drawing.Point(3, 255);
            this.nextLabel.Margin = new System.Windows.Forms.Padding(3);
            this.nextLabel.Name = "nextLabel";
            this.nextLabel.Size = new System.Drawing.Size(144, 39);
            this.nextLabel.TabIndex = 6;
            this.nextLabel.Text = "Next";
            // 
            // linesNumberLabel
            // 
            this.linesNumberLabel.AutoSize = true;
            this.linesNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linesNumberLabel.Font = new System.Drawing.Font("Half Bold Pixel-7", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linesNumberLabel.ForeColor = System.Drawing.Color.White;
            this.linesNumberLabel.Location = new System.Drawing.Point(3, 216);
            this.linesNumberLabel.Margin = new System.Windows.Forms.Padding(3);
            this.linesNumberLabel.Name = "linesNumberLabel";
            this.linesNumberLabel.Size = new System.Drawing.Size(144, 33);
            this.linesNumberLabel.TabIndex = 5;
            this.linesNumberLabel.Text = "0";
            // 
            // linesLabel
            // 
            this.linesLabel.AutoSize = true;
            this.linesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linesLabel.Font = new System.Drawing.Font("Half Bold Pixel-7", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linesLabel.ForeColor = System.Drawing.Color.White;
            this.linesLabel.Location = new System.Drawing.Point(3, 171);
            this.linesLabel.Margin = new System.Windows.Forms.Padding(3);
            this.linesLabel.Name = "linesLabel";
            this.linesLabel.Size = new System.Drawing.Size(144, 39);
            this.linesLabel.TabIndex = 4;
            this.linesLabel.Text = "Lines";
            // 
            // scoreNumberLabel
            // 
            this.scoreNumberLabel.AutoSize = true;
            this.scoreNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreNumberLabel.Font = new System.Drawing.Font("Half Bold Pixel-7", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreNumberLabel.ForeColor = System.Drawing.Color.White;
            this.scoreNumberLabel.Location = new System.Drawing.Point(3, 132);
            this.scoreNumberLabel.Margin = new System.Windows.Forms.Padding(3);
            this.scoreNumberLabel.Name = "scoreNumberLabel";
            this.scoreNumberLabel.Size = new System.Drawing.Size(144, 33);
            this.scoreNumberLabel.TabIndex = 3;
            this.scoreNumberLabel.Text = "0";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreLabel.Font = new System.Drawing.Font("Half Bold Pixel-7", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.ForeColor = System.Drawing.Color.White;
            this.scoreLabel.Location = new System.Drawing.Point(3, 87);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(3);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(144, 39);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Score";
            // 
            // levelNumberLabel
            // 
            this.levelNumberLabel.AutoSize = true;
            this.levelNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelNumberLabel.Font = new System.Drawing.Font("Half Bold Pixel-7", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelNumberLabel.ForeColor = System.Drawing.Color.White;
            this.levelNumberLabel.Location = new System.Drawing.Point(3, 48);
            this.levelNumberLabel.Margin = new System.Windows.Forms.Padding(3);
            this.levelNumberLabel.Name = "levelNumberLabel";
            this.levelNumberLabel.Size = new System.Drawing.Size(144, 33);
            this.levelNumberLabel.TabIndex = 1;
            this.levelNumberLabel.Text = "1";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelLabel.Font = new System.Drawing.Font("Half Bold Pixel-7", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelLabel.ForeColor = System.Drawing.Color.White;
            this.levelLabel.Location = new System.Drawing.Point(3, 3);
            this.levelLabel.Margin = new System.Windows.Forms.Padding(3);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(144, 39);
            this.levelLabel.TabIndex = 0;
            this.levelLabel.Text = "Level";
            // 
            // nextPicture
            // 
            this.nextPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextPicture.Location = new System.Drawing.Point(3, 300);
            this.nextPicture.Name = "nextPicture";
            this.nextPicture.Size = new System.Drawing.Size(144, 122);
            this.nextPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.nextPicture.TabIndex = 7;
            this.nextPicture.TabStop = false;
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.mainPanel);
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(505, 453);
            this.gamePanel.TabIndex = 2;
            // 
            // menuPanel
            // 
            this.menuPanel.ColumnCount = 1;
            this.menuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuPanel.Controls.Add(this.titlePicture, 0, 0);
            this.menuPanel.Controls.Add(this.copyrightLabel, 0, 2);
            this.menuPanel.Controls.Add(this.menuListPanel, 0, 1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.RowCount = 3;
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.menuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.menuPanel.Size = new System.Drawing.Size(505, 453);
            this.menuPanel.TabIndex = 0;
            // 
            // titlePicture
            // 
            this.titlePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titlePicture.Image = ((System.Drawing.Image)(resources.GetObject("titlePicture.Image")));
            this.titlePicture.Location = new System.Drawing.Point(3, 3);
            this.titlePicture.Name = "titlePicture";
            this.titlePicture.Size = new System.Drawing.Size(499, 172);
            this.titlePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.titlePicture.TabIndex = 0;
            this.titlePicture.TabStop = false;
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyrightLabel.Font = new System.Drawing.Font("Half Bold Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyrightLabel.ForeColor = System.Drawing.Color.White;
            this.copyrightLabel.Location = new System.Drawing.Point(3, 421);
            this.copyrightLabel.Margin = new System.Windows.Forms.Padding(3);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(499, 29);
            this.copyrightLabel.TabIndex = 1;
            this.copyrightLabel.Text = "© Bitgames 2015";
            this.copyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuListPanel
            // 
            this.menuListPanel.ColumnCount = 2;
            this.menuListPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.menuListPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77F));
            this.menuListPanel.Controls.Add(this._1PlayerLabel, 1, 0);
            this.menuListPanel.Controls.Add(this._2PlayersLabel, 1, 1);
            this.menuListPanel.Controls.Add(this.optionsLabel, 1, 2);
            this.menuListPanel.Controls.Add(this.exitLabel, 1, 3);
            this.menuListPanel.Controls.Add(this.menuSelectorPicture, 0, 0);
            this.menuListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuListPanel.Location = new System.Drawing.Point(150, 203);
            this.menuListPanel.Margin = new System.Windows.Forms.Padding(150, 25, 150, 25);
            this.menuListPanel.Name = "menuListPanel";
            this.menuListPanel.RowCount = 4;
            this.menuListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.menuListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.menuListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.menuListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.menuListPanel.Size = new System.Drawing.Size(205, 190);
            this.menuListPanel.TabIndex = 2;
            // 
            // _1PlayerLabel
            // 
            this._1PlayerLabel.AutoSize = true;
            this._1PlayerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._1PlayerLabel.Font = new System.Drawing.Font("Half Bold Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._1PlayerLabel.ForeColor = System.Drawing.Color.White;
            this._1PlayerLabel.Location = new System.Drawing.Point(50, 3);
            this._1PlayerLabel.Margin = new System.Windows.Forms.Padding(3);
            this._1PlayerLabel.Name = "_1PlayerLabel";
            this._1PlayerLabel.Size = new System.Drawing.Size(152, 41);
            this._1PlayerLabel.TabIndex = 2;
            this._1PlayerLabel.Text = "1 Player";
            this._1PlayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _2PlayersLabel
            // 
            this._2PlayersLabel.AutoSize = true;
            this._2PlayersLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._2PlayersLabel.Font = new System.Drawing.Font("Half Bold Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._2PlayersLabel.ForeColor = System.Drawing.Color.White;
            this._2PlayersLabel.Location = new System.Drawing.Point(50, 50);
            this._2PlayersLabel.Margin = new System.Windows.Forms.Padding(3);
            this._2PlayersLabel.Name = "_2PlayersLabel";
            this._2PlayersLabel.Size = new System.Drawing.Size(152, 41);
            this._2PlayersLabel.TabIndex = 4;
            this._2PlayersLabel.Text = "2 Players";
            this._2PlayersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsLabel.Font = new System.Drawing.Font("Half Bold Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optionsLabel.ForeColor = System.Drawing.Color.White;
            this.optionsLabel.Location = new System.Drawing.Point(50, 97);
            this.optionsLabel.Margin = new System.Windows.Forms.Padding(3);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(152, 41);
            this.optionsLabel.TabIndex = 3;
            this.optionsLabel.Text = "Options";
            this.optionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitLabel.Font = new System.Drawing.Font("Half Bold Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitLabel.ForeColor = System.Drawing.Color.White;
            this.exitLabel.Location = new System.Drawing.Point(50, 144);
            this.exitLabel.Margin = new System.Windows.Forms.Padding(3);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(152, 43);
            this.exitLabel.TabIndex = 5;
            this.exitLabel.Text = "Exit";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuSelectorPicture
            // 
            this.menuSelectorPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuSelectorPicture.Image = ((System.Drawing.Image)(resources.GetObject("menuSelectorPicture.Image")));
            this.menuSelectorPicture.Location = new System.Drawing.Point(3, 3);
            this.menuSelectorPicture.Name = "menuSelectorPicture";
            this.menuSelectorPicture.Size = new System.Drawing.Size(41, 41);
            this.menuSelectorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.menuSelectorPicture.TabIndex = 1;
            this.menuSelectorPicture.TabStop = false;
            // 
            // networkPanel
            // 
            this.networkPanel.ColumnCount = 1;
            this.networkPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.networkPanel.Controls.Add(this.networkListPanel, 0, 1);
            this.networkPanel.Controls.Add(this.errorLabel, 0, 0);
            this.networkPanel.Controls.Add(this.inputPanel, 0, 2);
            this.networkPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkPanel.Location = new System.Drawing.Point(0, 0);
            this.networkPanel.Name = "networkPanel";
            this.networkPanel.RowCount = 3;
            this.networkPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.networkPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.networkPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.networkPanel.Size = new System.Drawing.Size(505, 453);
            this.networkPanel.TabIndex = 2;
            // 
            // networkListPanel
            // 
            this.networkListPanel.ColumnCount = 2;
            this.networkListPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.networkListPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77F));
            this.networkListPanel.Controls.Add(this.joinGameLabel, 1, 1);
            this.networkListPanel.Controls.Add(this.backLabel, 1, 2);
            this.networkListPanel.Controls.Add(this.openGameLabel, 1, 0);
            this.networkListPanel.Controls.Add(this.networkSelectorPicture, 0, 0);
            this.networkListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkListPanel.Location = new System.Drawing.Point(150, 100);
            this.networkListPanel.Margin = new System.Windows.Forms.Padding(150, 65, 150, 65);
            this.networkListPanel.Name = "networkListPanel";
            this.networkListPanel.RowCount = 3;
            this.networkListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.networkListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.networkListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.networkListPanel.Size = new System.Drawing.Size(205, 141);
            this.networkListPanel.TabIndex = 3;
            // 
            // joinGameLabel
            // 
            this.joinGameLabel.AutoSize = true;
            this.joinGameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.joinGameLabel.Font = new System.Drawing.Font("Half Bold Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.joinGameLabel.ForeColor = System.Drawing.Color.White;
            this.joinGameLabel.Location = new System.Drawing.Point(50, 50);
            this.joinGameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.joinGameLabel.Name = "joinGameLabel";
            this.joinGameLabel.Size = new System.Drawing.Size(152, 41);
            this.joinGameLabel.TabIndex = 4;
            this.joinGameLabel.Text = "Join Game";
            this.joinGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backLabel.Font = new System.Drawing.Font("Half Bold Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backLabel.ForeColor = System.Drawing.Color.White;
            this.backLabel.Location = new System.Drawing.Point(50, 97);
            this.backLabel.Margin = new System.Windows.Forms.Padding(3);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(152, 41);
            this.backLabel.TabIndex = 3;
            this.backLabel.Text = "Back";
            this.backLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openGameLabel
            // 
            this.openGameLabel.AutoSize = true;
            this.openGameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openGameLabel.Font = new System.Drawing.Font("Half Bold Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openGameLabel.ForeColor = System.Drawing.Color.White;
            this.openGameLabel.Location = new System.Drawing.Point(50, 3);
            this.openGameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.openGameLabel.Name = "openGameLabel";
            this.openGameLabel.Size = new System.Drawing.Size(152, 41);
            this.openGameLabel.TabIndex = 2;
            this.openGameLabel.Text = "Open Game";
            this.openGameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // networkSelectorPicture
            // 
            this.networkSelectorPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkSelectorPicture.Image = ((System.Drawing.Image)(resources.GetObject("networkSelectorPicture.Image")));
            this.networkSelectorPicture.Location = new System.Drawing.Point(3, 3);
            this.networkSelectorPicture.Name = "networkSelectorPicture";
            this.networkSelectorPicture.Size = new System.Drawing.Size(41, 41);
            this.networkSelectorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.networkSelectorPicture.TabIndex = 1;
            this.networkSelectorPicture.TabStop = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorLabel.Font = new System.Drawing.Font("Half Bold Pixel-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Black;
            this.errorLabel.Location = new System.Drawing.Point(3, 3);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(3);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(499, 29);
            this.errorLabel.TabIndex = 2;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputPanel
            // 
            this.inputPanel.ColumnCount = 1;
            this.inputPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputPanel.Controls.Add(this.textPanel, 0, 1);
            this.inputPanel.Controls.Add(this.keyboardPanel, 0, 0);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPanel.Location = new System.Drawing.Point(51, 324);
            this.inputPanel.Margin = new System.Windows.Forms.Padding(51, 18, 51, 18);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.RowCount = 2;
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.inputPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.inputPanel.Size = new System.Drawing.Size(403, 111);
            this.inputPanel.TabIndex = 4;
            this.inputPanel.Visible = false;
            this.inputPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.inputPanel_Paint);
            // 
            // textPanel
            // 
            this.textPanel.ColumnCount = 15;
            this.textPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.textPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.textPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.textPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.textPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.textPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.textPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.textPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.textPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.textPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.textPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.textPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.textPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.textPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.textPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666666F));
            this.textPanel.Controls.Add(this.digit1Label, 0, 0);
            this.textPanel.Controls.Add(this.digit2Label, 1, 0);
            this.textPanel.Controls.Add(this.digit3Label, 2, 0);
            this.textPanel.Controls.Add(this.dot1Label, 3, 0);
            this.textPanel.Controls.Add(this.digit4Label, 4, 0);
            this.textPanel.Controls.Add(this.digit5Label, 5, 0);
            this.textPanel.Controls.Add(this.digit6Label, 6, 0);
            this.textPanel.Controls.Add(this.dot2Label, 7, 0);
            this.textPanel.Controls.Add(this.digit7Label, 8, 0);
            this.textPanel.Controls.Add(this.digit8Label, 9, 0);
            this.textPanel.Controls.Add(this.digit9Label, 10, 0);
            this.textPanel.Controls.Add(this.dot3Label, 11, 0);
            this.textPanel.Controls.Add(this.digit10Label, 12, 0);
            this.textPanel.Controls.Add(this.digit11Label, 13, 0);
            this.textPanel.Controls.Add(this.digit12Label, 14, 0);
            this.textPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPanel.Location = new System.Drawing.Point(6, 75);
            this.textPanel.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.textPanel.Name = "textPanel";
            this.textPanel.RowCount = 1;
            this.textPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.textPanel.Size = new System.Drawing.Size(391, 33);
            this.textPanel.TabIndex = 1;
            this.textPanel.Tag = "0";
            // 
            // digit1Label
            // 
            this.digit1Label.AutoSize = true;
            this.digit1Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digit1Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit1Label.ForeColor = System.Drawing.Color.White;
            this.digit1Label.Location = new System.Drawing.Point(3, 3);
            this.digit1Label.Margin = new System.Windows.Forms.Padding(3);
            this.digit1Label.Name = "digit1Label";
            this.digit1Label.Size = new System.Drawing.Size(20, 27);
            this.digit1Label.TabIndex = 5;
            this.digit1Label.Text = "1";
            this.digit1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // digit2Label
            // 
            this.digit2Label.AutoSize = true;
            this.digit2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digit2Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit2Label.ForeColor = System.Drawing.Color.White;
            this.digit2Label.Location = new System.Drawing.Point(29, 3);
            this.digit2Label.Margin = new System.Windows.Forms.Padding(3);
            this.digit2Label.Name = "digit2Label";
            this.digit2Label.Size = new System.Drawing.Size(20, 27);
            this.digit2Label.TabIndex = 7;
            this.digit2Label.Text = "2";
            this.digit2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // digit3Label
            // 
            this.digit3Label.AutoSize = true;
            this.digit3Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digit3Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit3Label.ForeColor = System.Drawing.Color.White;
            this.digit3Label.Location = new System.Drawing.Point(55, 3);
            this.digit3Label.Margin = new System.Windows.Forms.Padding(3);
            this.digit3Label.Name = "digit3Label";
            this.digit3Label.Size = new System.Drawing.Size(20, 27);
            this.digit3Label.TabIndex = 6;
            this.digit3Label.Text = "7";
            this.digit3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dot1Label
            // 
            this.dot1Label.AutoSize = true;
            this.dot1Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dot1Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dot1Label.ForeColor = System.Drawing.Color.White;
            this.dot1Label.Location = new System.Drawing.Point(81, 3);
            this.dot1Label.Margin = new System.Windows.Forms.Padding(3);
            this.dot1Label.Name = "dot1Label";
            this.dot1Label.Size = new System.Drawing.Size(20, 27);
            this.dot1Label.TabIndex = 8;
            this.dot1Label.Text = ".";
            this.dot1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // digit4Label
            // 
            this.digit4Label.AutoSize = true;
            this.digit4Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digit4Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit4Label.ForeColor = System.Drawing.Color.White;
            this.digit4Label.Location = new System.Drawing.Point(107, 3);
            this.digit4Label.Margin = new System.Windows.Forms.Padding(3);
            this.digit4Label.Name = "digit4Label";
            this.digit4Label.Size = new System.Drawing.Size(20, 27);
            this.digit4Label.TabIndex = 9;
            this.digit4Label.Text = "0";
            this.digit4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // digit5Label
            // 
            this.digit5Label.AutoSize = true;
            this.digit5Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digit5Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit5Label.ForeColor = System.Drawing.Color.White;
            this.digit5Label.Location = new System.Drawing.Point(133, 3);
            this.digit5Label.Margin = new System.Windows.Forms.Padding(3);
            this.digit5Label.Name = "digit5Label";
            this.digit5Label.Size = new System.Drawing.Size(20, 27);
            this.digit5Label.TabIndex = 10;
            this.digit5Label.Text = "0";
            this.digit5Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // digit6Label
            // 
            this.digit6Label.AutoSize = true;
            this.digit6Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digit6Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit6Label.ForeColor = System.Drawing.Color.White;
            this.digit6Label.Location = new System.Drawing.Point(159, 3);
            this.digit6Label.Margin = new System.Windows.Forms.Padding(3);
            this.digit6Label.Name = "digit6Label";
            this.digit6Label.Size = new System.Drawing.Size(20, 27);
            this.digit6Label.TabIndex = 11;
            this.digit6Label.Text = "0";
            this.digit6Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dot2Label
            // 
            this.dot2Label.AutoSize = true;
            this.dot2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dot2Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dot2Label.ForeColor = System.Drawing.Color.White;
            this.dot2Label.Location = new System.Drawing.Point(185, 3);
            this.dot2Label.Margin = new System.Windows.Forms.Padding(3);
            this.dot2Label.Name = "dot2Label";
            this.dot2Label.Size = new System.Drawing.Size(20, 27);
            this.dot2Label.TabIndex = 12;
            this.dot2Label.Text = ".";
            this.dot2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // digit7Label
            // 
            this.digit7Label.AutoSize = true;
            this.digit7Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digit7Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit7Label.ForeColor = System.Drawing.Color.White;
            this.digit7Label.Location = new System.Drawing.Point(211, 3);
            this.digit7Label.Margin = new System.Windows.Forms.Padding(3);
            this.digit7Label.Name = "digit7Label";
            this.digit7Label.Size = new System.Drawing.Size(20, 27);
            this.digit7Label.TabIndex = 13;
            this.digit7Label.Text = "0";
            this.digit7Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // digit8Label
            // 
            this.digit8Label.AutoSize = true;
            this.digit8Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digit8Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit8Label.ForeColor = System.Drawing.Color.White;
            this.digit8Label.Location = new System.Drawing.Point(237, 3);
            this.digit8Label.Margin = new System.Windows.Forms.Padding(3);
            this.digit8Label.Name = "digit8Label";
            this.digit8Label.Size = new System.Drawing.Size(20, 27);
            this.digit8Label.TabIndex = 14;
            this.digit8Label.Text = "0";
            this.digit8Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // digit9Label
            // 
            this.digit9Label.AutoSize = true;
            this.digit9Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digit9Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit9Label.ForeColor = System.Drawing.Color.White;
            this.digit9Label.Location = new System.Drawing.Point(263, 3);
            this.digit9Label.Margin = new System.Windows.Forms.Padding(3);
            this.digit9Label.Name = "digit9Label";
            this.digit9Label.Size = new System.Drawing.Size(20, 27);
            this.digit9Label.TabIndex = 15;
            this.digit9Label.Text = "0";
            this.digit9Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dot3Label
            // 
            this.dot3Label.AutoSize = true;
            this.dot3Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dot3Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dot3Label.ForeColor = System.Drawing.Color.White;
            this.dot3Label.Location = new System.Drawing.Point(289, 3);
            this.dot3Label.Margin = new System.Windows.Forms.Padding(3);
            this.dot3Label.Name = "dot3Label";
            this.dot3Label.Size = new System.Drawing.Size(20, 27);
            this.dot3Label.TabIndex = 16;
            this.dot3Label.Text = ".";
            this.dot3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // digit10Label
            // 
            this.digit10Label.AutoSize = true;
            this.digit10Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digit10Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit10Label.ForeColor = System.Drawing.Color.White;
            this.digit10Label.Location = new System.Drawing.Point(315, 3);
            this.digit10Label.Margin = new System.Windows.Forms.Padding(3);
            this.digit10Label.Name = "digit10Label";
            this.digit10Label.Size = new System.Drawing.Size(20, 27);
            this.digit10Label.TabIndex = 17;
            this.digit10Label.Text = "0";
            this.digit10Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // digit11Label
            // 
            this.digit11Label.AutoSize = true;
            this.digit11Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digit11Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit11Label.ForeColor = System.Drawing.Color.White;
            this.digit11Label.Location = new System.Drawing.Point(341, 3);
            this.digit11Label.Margin = new System.Windows.Forms.Padding(3);
            this.digit11Label.Name = "digit11Label";
            this.digit11Label.Size = new System.Drawing.Size(20, 27);
            this.digit11Label.TabIndex = 18;
            this.digit11Label.Text = "0";
            this.digit11Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // digit12Label
            // 
            this.digit12Label.AutoSize = true;
            this.digit12Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digit12Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit12Label.ForeColor = System.Drawing.Color.White;
            this.digit12Label.Location = new System.Drawing.Point(367, 3);
            this.digit12Label.Margin = new System.Windows.Forms.Padding(3);
            this.digit12Label.Name = "digit12Label";
            this.digit12Label.Size = new System.Drawing.Size(21, 27);
            this.digit12Label.TabIndex = 19;
            this.digit12Label.Text = "1";
            this.digit12Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keyboardPanel
            // 
            this.keyboardPanel.ColumnCount = 12;
            this.keyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.keyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.keyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.keyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.keyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.keyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.keyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.keyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.keyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.keyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.keyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.keyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.keyboardPanel.Controls.Add(this._0Label, 0, 0);
            this.keyboardPanel.Controls.Add(this._1Label, 1, 0);
            this.keyboardPanel.Controls.Add(this._2Label, 2, 0);
            this.keyboardPanel.Controls.Add(this._3Label, 3, 0);
            this.keyboardPanel.Controls.Add(this._4Label, 4, 0);
            this.keyboardPanel.Controls.Add(this._5Label, 5, 0);
            this.keyboardPanel.Controls.Add(this._6Label, 6, 0);
            this.keyboardPanel.Controls.Add(this._7Label, 7, 0);
            this.keyboardPanel.Controls.Add(this._8Label, 8, 0);
            this.keyboardPanel.Controls.Add(this._9Label, 9, 0);
            this.keyboardPanel.Controls.Add(this.leftLabel, 10, 0);
            this.keyboardPanel.Controls.Add(this.rightLabel, 11, 0);
            this.keyboardPanel.Controls.Add(this.keyboardSelectorPicture, 0, 1);
            this.keyboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyboardPanel.Location = new System.Drawing.Point(3, 3);
            this.keyboardPanel.Name = "keyboardPanel";
            this.keyboardPanel.RowCount = 2;
            this.keyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.keyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.keyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.keyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.keyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.keyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.keyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.keyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.keyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.keyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.keyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.keyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.keyboardPanel.Size = new System.Drawing.Size(397, 66);
            this.keyboardPanel.TabIndex = 0;
            // 
            // _0Label
            // 
            this._0Label.AutoSize = true;
            this._0Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this._0Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._0Label.ForeColor = System.Drawing.Color.White;
            this._0Label.Location = new System.Drawing.Point(3, 3);
            this._0Label.Margin = new System.Windows.Forms.Padding(3);
            this._0Label.Name = "_0Label";
            this._0Label.Size = new System.Drawing.Size(27, 27);
            this._0Label.TabIndex = 3;
            this._0Label.Text = "0";
            this._0Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _1Label
            // 
            this._1Label.AutoSize = true;
            this._1Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this._1Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._1Label.ForeColor = System.Drawing.Color.White;
            this._1Label.Location = new System.Drawing.Point(36, 3);
            this._1Label.Margin = new System.Windows.Forms.Padding(3);
            this._1Label.Name = "_1Label";
            this._1Label.Size = new System.Drawing.Size(27, 27);
            this._1Label.TabIndex = 4;
            this._1Label.Text = "1";
            this._1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _2Label
            // 
            this._2Label.AutoSize = true;
            this._2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this._2Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._2Label.ForeColor = System.Drawing.Color.White;
            this._2Label.Location = new System.Drawing.Point(69, 3);
            this._2Label.Margin = new System.Windows.Forms.Padding(3);
            this._2Label.Name = "_2Label";
            this._2Label.Size = new System.Drawing.Size(27, 27);
            this._2Label.TabIndex = 5;
            this._2Label.Text = "2";
            this._2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _3Label
            // 
            this._3Label.AutoSize = true;
            this._3Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this._3Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._3Label.ForeColor = System.Drawing.Color.White;
            this._3Label.Location = new System.Drawing.Point(102, 3);
            this._3Label.Margin = new System.Windows.Forms.Padding(3);
            this._3Label.Name = "_3Label";
            this._3Label.Size = new System.Drawing.Size(27, 27);
            this._3Label.TabIndex = 6;
            this._3Label.Text = "3";
            this._3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _4Label
            // 
            this._4Label.AutoSize = true;
            this._4Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this._4Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._4Label.ForeColor = System.Drawing.Color.White;
            this._4Label.Location = new System.Drawing.Point(135, 3);
            this._4Label.Margin = new System.Windows.Forms.Padding(3);
            this._4Label.Name = "_4Label";
            this._4Label.Size = new System.Drawing.Size(27, 27);
            this._4Label.TabIndex = 7;
            this._4Label.Text = "4";
            this._4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _5Label
            // 
            this._5Label.AutoSize = true;
            this._5Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this._5Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._5Label.ForeColor = System.Drawing.Color.White;
            this._5Label.Location = new System.Drawing.Point(168, 3);
            this._5Label.Margin = new System.Windows.Forms.Padding(3);
            this._5Label.Name = "_5Label";
            this._5Label.Size = new System.Drawing.Size(27, 27);
            this._5Label.TabIndex = 8;
            this._5Label.Text = "5";
            this._5Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _6Label
            // 
            this._6Label.AutoSize = true;
            this._6Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this._6Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._6Label.ForeColor = System.Drawing.Color.White;
            this._6Label.Location = new System.Drawing.Point(201, 3);
            this._6Label.Margin = new System.Windows.Forms.Padding(3);
            this._6Label.Name = "_6Label";
            this._6Label.Size = new System.Drawing.Size(27, 27);
            this._6Label.TabIndex = 9;
            this._6Label.Text = "6";
            this._6Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _7Label
            // 
            this._7Label.AutoSize = true;
            this._7Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this._7Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._7Label.ForeColor = System.Drawing.Color.White;
            this._7Label.Location = new System.Drawing.Point(234, 3);
            this._7Label.Margin = new System.Windows.Forms.Padding(3);
            this._7Label.Name = "_7Label";
            this._7Label.Size = new System.Drawing.Size(27, 27);
            this._7Label.TabIndex = 10;
            this._7Label.Text = "7";
            this._7Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _8Label
            // 
            this._8Label.AutoSize = true;
            this._8Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this._8Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._8Label.ForeColor = System.Drawing.Color.White;
            this._8Label.Location = new System.Drawing.Point(267, 3);
            this._8Label.Margin = new System.Windows.Forms.Padding(3);
            this._8Label.Name = "_8Label";
            this._8Label.Size = new System.Drawing.Size(27, 27);
            this._8Label.TabIndex = 11;
            this._8Label.Text = "8";
            this._8Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _9Label
            // 
            this._9Label.AutoSize = true;
            this._9Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this._9Label.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._9Label.ForeColor = System.Drawing.Color.White;
            this._9Label.Location = new System.Drawing.Point(300, 3);
            this._9Label.Margin = new System.Windows.Forms.Padding(3);
            this._9Label.Name = "_9Label";
            this._9Label.Size = new System.Drawing.Size(27, 27);
            this._9Label.TabIndex = 12;
            this._9Label.Text = "9";
            this._9Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftLabel.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftLabel.ForeColor = System.Drawing.Color.White;
            this.leftLabel.Location = new System.Drawing.Point(333, 3);
            this.leftLabel.Margin = new System.Windows.Forms.Padding(3);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(27, 27);
            this.leftLabel.TabIndex = 13;
            this.leftLabel.Text = "◄";
            this.leftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightLabel.Font = new System.Drawing.Font("Half Bold Pixel-7", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightLabel.ForeColor = System.Drawing.Color.White;
            this.rightLabel.Location = new System.Drawing.Point(366, 3);
            this.rightLabel.Margin = new System.Windows.Forms.Padding(3);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(28, 27);
            this.rightLabel.TabIndex = 14;
            this.rightLabel.Text = "►";
            this.rightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keyboardSelectorPicture
            // 
            this.keyboardSelectorPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyboardSelectorPicture.Image = ((System.Drawing.Image)(resources.GetObject("keyboardSelectorPicture.Image")));
            this.keyboardSelectorPicture.Location = new System.Drawing.Point(3, 36);
            this.keyboardSelectorPicture.Name = "keyboardSelectorPicture";
            this.keyboardSelectorPicture.Size = new System.Drawing.Size(27, 27);
            this.keyboardSelectorPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.keyboardSelectorPicture.TabIndex = 15;
            this.keyboardSelectorPicture.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(505, 453);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.networkPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тетрис";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.mainPanel.ResumeLayout(false);
            this.fieldPanel.ResumeLayout(false);
            this.fieldPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fieldPicture)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextPicture)).EndInit();
            this.gamePanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture)).EndInit();
            this.menuListPanel.ResumeLayout(false);
            this.menuListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuSelectorPicture)).EndInit();
            this.networkPanel.ResumeLayout(false);
            this.networkPanel.PerformLayout();
            this.networkListPanel.ResumeLayout(false);
            this.networkListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.networkSelectorPicture)).EndInit();
            this.inputPanel.ResumeLayout(false);
            this.textPanel.ResumeLayout(false);
            this.textPanel.PerformLayout();
            this.keyboardPanel.ResumeLayout(false);
            this.keyboardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardSelectorPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox fieldPicture;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.TableLayoutPanel infoPanel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label linesLabel;
        private System.Windows.Forms.Label nextLabel;
        public System.Windows.Forms.Label scoreNumberLabel;
        public System.Windows.Forms.Label linesNumberLabel;
        public System.Windows.Forms.PictureBox nextPicture;
        public System.Windows.Forms.Label levelNumberLabel;
        private System.Windows.Forms.TableLayoutPanel menuPanel;
        private System.Windows.Forms.PictureBox titlePicture;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.TableLayoutPanel menuListPanel;
        private System.Windows.Forms.PictureBox menuSelectorPicture;
        private System.Windows.Forms.Label _1PlayerLabel;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Label _2PlayersLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.TableLayoutPanel networkPanel;
        private System.Windows.Forms.TableLayoutPanel networkListPanel;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.PictureBox networkSelectorPicture;
        private System.Windows.Forms.TableLayoutPanel inputPanel;
        private System.Windows.Forms.TableLayoutPanel keyboardPanel;
        private System.Windows.Forms.Label _0Label;
        private System.Windows.Forms.PictureBox keyboardSelectorPicture;
        private System.Windows.Forms.TableLayoutPanel textPanel;
        private System.Windows.Forms.Label _1Label;
        private System.Windows.Forms.Label _2Label;
        private System.Windows.Forms.Label _3Label;
        private System.Windows.Forms.Label _4Label;
        private System.Windows.Forms.Label _5Label;
        private System.Windows.Forms.Label _6Label;
        private System.Windows.Forms.Label _7Label;
        private System.Windows.Forms.Label _8Label;
        private System.Windows.Forms.Label _9Label;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label digit2Label;
        private System.Windows.Forms.Label digit3Label;
        private System.Windows.Forms.Label digit1Label;
        private System.Windows.Forms.Label dot1Label;
        private System.Windows.Forms.Label digit12Label;
        private System.Windows.Forms.Label digit11Label;
        private System.Windows.Forms.Label digit10Label;
        private System.Windows.Forms.Label dot3Label;
        private System.Windows.Forms.Label digit9Label;
        private System.Windows.Forms.Label digit8Label;
        private System.Windows.Forms.Label digit7Label;
        private System.Windows.Forms.Label dot2Label;
        private System.Windows.Forms.Label digit6Label;
        private System.Windows.Forms.Label digit5Label;
        private System.Windows.Forms.Label digit4Label;
        public System.Windows.Forms.Label errorLabel;
        public System.Windows.Forms.Label openGameLabel;
        public System.Windows.Forms.Label joinGameLabel;
        public System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Panel fieldPanel;
        public System.Windows.Forms.Label infoLabel;
    }
}