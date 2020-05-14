namespace AntiCoronaGame
{
    partial class fGamePlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGamePlay));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.titleBar1 = new AntiCoronaGame.UserControls.TitleBar();
            this.pnlGameInfor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.healthBar = new AntiCoronaGame.UserControls.HealthBar();
            this.btnReplay = new AntiCoronaGame.UserControls.FlatButton();
            this.btnHome = new AntiCoronaGame.UserControls.FlatButton();
            this.btnPause = new AntiCoronaGame.UserControls.FlatButton();
            this.lblLevel = new AntiCoronaGame.UserControls.LabelWithNumber();
            this.lblBestScore = new AntiCoronaGame.UserControls.LabelWithNumber();
            this.lblScore = new AntiCoronaGame.UserControls.LabelWithNumber();
            this.pnlBoderLeft = new AntiCoronaGame.UserControls.DoubleBufferedPanel();
            this.pnlBoderRight = new System.Windows.Forms.Panel();
            this.pnlGamePlay = new AntiCoronaGame.UserControls.DoubleBufferedPanel();
            this.picPillar1 = new System.Windows.Forms.PictureBox();
            this.picPillar4 = new System.Windows.Forms.PictureBox();
            this.picPillar2 = new System.Windows.Forms.PictureBox();
            this.picPillar3 = new System.Windows.Forms.PictureBox();
            this.picVirus1 = new System.Windows.Forms.PictureBox();
            this.picVirus2 = new System.Windows.Forms.PictureBox();
            this.picPlayer = new AntiCoronaGame.UserControls.Player();
            this.tmrGameUpdate = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlGameInfor.SuspendLayout();
            this.pnlGamePlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPillar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPillar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPillar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPillar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVirus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVirus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.titleBar1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlGameInfor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnlBoderLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlBoderRight, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlGamePlay, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(998, 496);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // titleBar1
            // 
            this.titleBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.titleBar1.ButtonForeColor = AntiCoronaGame.UserControls.TitleBar.ButtonColor.White;
            this.tableLayoutPanel1.SetColumnSpan(this.titleBar1, 3);
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar1.Location = new System.Drawing.Point(3, 3);
            this.titleBar1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.ResizeWindowsBox = AntiCoronaGame.UserControls.TitleBar.ResizeBox.NoneResize;
            this.titleBar1.Size = new System.Drawing.Size(992, 36);
            this.titleBar1.TabIndex = 1;
            this.titleBar1.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar1.TitleForeColor = System.Drawing.Color.White;
            this.titleBar1.TitleIcon = null;
            this.titleBar1.TitleText = "Anti Corona";
            // 
            // pnlGameInfor
            // 
            this.pnlGameInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlGameInfor.Controls.Add(this.label1);
            this.pnlGameInfor.Controls.Add(this.healthBar);
            this.pnlGameInfor.Controls.Add(this.btnReplay);
            this.pnlGameInfor.Controls.Add(this.btnHome);
            this.pnlGameInfor.Controls.Add(this.btnPause);
            this.pnlGameInfor.Controls.Add(this.lblLevel);
            this.pnlGameInfor.Controls.Add(this.lblBestScore);
            this.pnlGameInfor.Controls.Add(this.lblScore);
            this.pnlGameInfor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGameInfor.Location = new System.Drawing.Point(6, 459);
            this.pnlGameInfor.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnlGameInfor.Name = "pnlGameInfor";
            this.pnlGameInfor.Size = new System.Drawing.Size(986, 34);
            this.pnlGameInfor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(420, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Health";
            // 
            // healthBar
            // 
            this.healthBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.healthBar.HealthColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(210)))), ((int)(((byte)(128)))));
            this.healthBar.HealthPercent = 100;
            this.healthBar.Location = new System.Drawing.Point(487, 2);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(349, 30);
            this.healthBar.TabIndex = 2;
            // 
            // btnReplay
            // 
            this.btnReplay.BackgroundImage = global::AntiCoronaGame.Properties.Resources.replay;
            this.btnReplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReplay.FlatAppearance.BorderSize = 0;
            this.btnReplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplay.Location = new System.Drawing.Point(905, 0);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(41, 34);
            this.btnReplay.TabIndex = 1;
            this.btnReplay.ToolTipActive = true;
            this.btnReplay.ToolTipAutomaticDelay = 500;
            this.btnReplay.ToolTipAutoPopDelay = 5000;
            this.btnReplay.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnReplay.ToolTipCaption = "";
            this.btnReplay.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnReplay.ToolTipInitialDelay = 200;
            this.btnReplay.ToolTipIsBalloon = false;
            this.btnReplay.ToolTipReshowDelay = 100;
            this.btnReplay.ToolTipShowAlways = true;
            this.btnReplay.ToolTipTitle = "Replay";
            this.btnReplay.UseVisualStyleBackColor = true;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::AntiCoronaGame.Properties.Resources.home_variant;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(863, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(41, 34);
            this.btnHome.TabIndex = 1;
            this.btnHome.ToolTipActive = true;
            this.btnHome.ToolTipAutomaticDelay = 500;
            this.btnHome.ToolTipAutoPopDelay = 5000;
            this.btnHome.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnHome.ToolTipCaption = "";
            this.btnHome.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnHome.ToolTipInitialDelay = 200;
            this.btnHome.ToolTipIsBalloon = false;
            this.btnHome.ToolTipReshowDelay = 100;
            this.btnHome.ToolTipShowAlways = true;
            this.btnHome.ToolTipTitle = "Pause";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = global::AntiCoronaGame.Properties.Resources.pause;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(947, 0);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(41, 34);
            this.btnPause.TabIndex = 1;
            this.btnPause.ToolTipActive = true;
            this.btnPause.ToolTipAutomaticDelay = 500;
            this.btnPause.ToolTipAutoPopDelay = 5000;
            this.btnPause.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnPause.ToolTipCaption = "";
            this.btnPause.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnPause.ToolTipInitialDelay = 200;
            this.btnPause.ToolTipIsBalloon = false;
            this.btnPause.ToolTipReshowDelay = 100;
            this.btnPause.ToolTipShowAlways = true;
            this.btnPause.ToolTipTitle = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(297, 5);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(67, 23);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Level: 0";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLevel.TextDisplay = "Level";
            this.lblLevel.Value = 0;
            // 
            // lblBestScore
            // 
            this.lblBestScore.AutoSize = true;
            this.lblBestScore.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestScore.ForeColor = System.Drawing.Color.White;
            this.lblBestScore.Location = new System.Drawing.Point(153, 5);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(105, 23);
            this.lblBestScore.TabIndex = 0;
            this.lblBestScore.Text = "Best score: 0";
            this.lblBestScore.TextDisplay = "Best score";
            this.lblBestScore.Value = 0;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(6, 5);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(70, 23);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: 0";
            this.lblScore.TextDisplay = "Score";
            this.lblScore.Value = 0;
            // 
            // pnlBoderLeft
            // 
            this.pnlBoderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlBoderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBoderLeft.Location = new System.Drawing.Point(3, 39);
            this.pnlBoderLeft.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.pnlBoderLeft.Name = "pnlBoderLeft";
            this.tableLayoutPanel1.SetRowSpan(this.pnlBoderLeft, 2);
            this.pnlBoderLeft.Size = new System.Drawing.Size(3, 454);
            this.pnlBoderLeft.TabIndex = 3;
            // 
            // pnlBoderRight
            // 
            this.pnlBoderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlBoderRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBoderRight.Location = new System.Drawing.Point(992, 39);
            this.pnlBoderRight.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.pnlBoderRight.Name = "pnlBoderRight";
            this.tableLayoutPanel1.SetRowSpan(this.pnlBoderRight, 2);
            this.pnlBoderRight.Size = new System.Drawing.Size(3, 454);
            this.pnlBoderRight.TabIndex = 5;
            // 
            // pnlGamePlay
            // 
            this.pnlGamePlay.BackColor = System.Drawing.Color.Transparent;
            this.pnlGamePlay.Controls.Add(this.picPillar1);
            this.pnlGamePlay.Controls.Add(this.picPillar4);
            this.pnlGamePlay.Controls.Add(this.picPillar2);
            this.pnlGamePlay.Controls.Add(this.picPillar3);
            this.pnlGamePlay.Controls.Add(this.picVirus1);
            this.pnlGamePlay.Controls.Add(this.picVirus2);
            this.pnlGamePlay.Controls.Add(this.picPlayer);
            this.pnlGamePlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGamePlay.Location = new System.Drawing.Point(9, 39);
            this.pnlGamePlay.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pnlGamePlay.Name = "pnlGamePlay";
            this.pnlGamePlay.Size = new System.Drawing.Size(980, 420);
            this.pnlGamePlay.TabIndex = 6;
            // 
            // picPillar1
            // 
            this.picPillar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picPillar1.Location = new System.Drawing.Point(250, 0);
            this.picPillar1.Name = "picPillar1";
            this.picPillar1.Size = new System.Drawing.Size(50, 200);
            this.picPillar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPillar1.TabIndex = 5;
            this.picPillar1.TabStop = false;
            // 
            // picPillar4
            // 
            this.picPillar4.BackColor = System.Drawing.Color.SpringGreen;
            this.picPillar4.Location = new System.Drawing.Point(0, 220);
            this.picPillar4.Name = "picPillar4";
            this.picPillar4.Size = new System.Drawing.Size(50, 200);
            this.picPillar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPillar4.TabIndex = 6;
            this.picPillar4.TabStop = false;
            // 
            // picPillar2
            // 
            this.picPillar2.BackColor = System.Drawing.Color.Maroon;
            this.picPillar2.Location = new System.Drawing.Point(500, 220);
            this.picPillar2.Name = "picPillar2";
            this.picPillar2.Size = new System.Drawing.Size(50, 200);
            this.picPillar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPillar2.TabIndex = 6;
            this.picPillar2.TabStop = false;
            // 
            // picPillar3
            // 
            this.picPillar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.picPillar3.Location = new System.Drawing.Point(750, 0);
            this.picPillar3.Name = "picPillar3";
            this.picPillar3.Size = new System.Drawing.Size(50, 200);
            this.picPillar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPillar3.TabIndex = 7;
            this.picPillar3.TabStop = false;
            // 
            // picVirus1
            // 
            this.picVirus1.BackColor = System.Drawing.Color.Transparent;
            this.picVirus1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picVirus1.Image = global::AntiCoronaGame.Properties.Resources.corona_3;
            this.picVirus1.Location = new System.Drawing.Point(320, 237);
            this.picVirus1.Name = "picVirus1";
            this.picVirus1.Size = new System.Drawing.Size(50, 50);
            this.picVirus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVirus1.TabIndex = 9;
            this.picVirus1.TabStop = false;
            // 
            // picVirus2
            // 
            this.picVirus2.BackColor = System.Drawing.Color.Transparent;
            this.picVirus2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picVirus2.Image = global::AntiCoronaGame.Properties.Resources.corona_3;
            this.picVirus2.Location = new System.Drawing.Point(513, 104);
            this.picVirus2.Name = "picVirus2";
            this.picVirus2.Size = new System.Drawing.Size(50, 50);
            this.picVirus2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVirus2.TabIndex = 8;
            this.picVirus2.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.Image = ((System.Drawing.Image)(resources.GetObject("picPlayer.Image")));
            this.picPlayer.Location = new System.Drawing.Point(85, 173);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(135, 75);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // tmrGameUpdate
            // 
            this.tmrGameUpdate.Tick += new System.EventHandler(this.tmrGameUpdate_Tick);
            // 
            // fGamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 496);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "fGamePlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fGamePlay";
            this.Load += new System.EventHandler(this.fGamePlay_Load);
            this.Shown += new System.EventHandler(this.fGamePlay_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.fGamePlay_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGamePlay_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fGamePlay_KeyUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlGameInfor.ResumeLayout(false);
            this.pnlGameInfor.PerformLayout();
            this.pnlGamePlay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPillar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPillar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPillar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPillar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVirus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVirus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UserControls.TitleBar titleBar1;
        private System.Windows.Forms.Panel pnlGameInfor;
        private UserControls.DoubleBufferedPanel pnlBoderLeft;
        private System.Windows.Forms.Panel pnlBoderRight;
        private UserControls.LabelWithNumber lblScore;
        private UserControls.DoubleBufferedPanel pnlGamePlay;
        private System.Windows.Forms.Timer tmrGameUpdate;
        private UserControls.LabelWithNumber lblLevel;
        private UserControls.FlatButton btnPause;
        private UserControls.FlatButton btnHome;
        private UserControls.HealthBar healthBar;
        private System.Windows.Forms.Label label1;
        private UserControls.Player picPlayer;
        private System.Windows.Forms.PictureBox picPillar3;
        private System.Windows.Forms.PictureBox picPillar2;
        private System.Windows.Forms.PictureBox picPillar1;
        private System.Windows.Forms.PictureBox picVirus1;
        private System.Windows.Forms.PictureBox picVirus2;
        private System.Windows.Forms.PictureBox picPillar4;
        private UserControls.FlatButton btnReplay;
        private UserControls.LabelWithNumber lblBestScore;
    }
}