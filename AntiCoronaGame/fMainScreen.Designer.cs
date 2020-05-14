namespace AntiCoronaGame
{
    partial class fMainScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.titleBar1 = new AntiCoronaGame.UserControls.TitleBar();
            this.pnlBoderRight = new System.Windows.Forms.Panel();
            this.pnlBoderLeft = new System.Windows.Forms.Panel();
            this.pnlBoderBottom = new System.Windows.Forms.Panel();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnQuit = new AntiCoronaGame.UserControls.FlatButton();
            this.btnIntro = new AntiCoronaGame.UserControls.FlatButton();
            this.btnHowTo = new AntiCoronaGame.UserControls.FlatButton();
            this.btnAbout = new AntiCoronaGame.UserControls.FlatButton();
            this.btnPlay = new AntiCoronaGame.UserControls.FlatButton();
            this.picIntro = new System.Windows.Forms.PictureBox();
            this.pnlText = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIntro)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.pnlBoderRight, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlBoderLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlBoderBottom, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pnlButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.picIntro, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnlText, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 548);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // titleBar1
            // 
            this.titleBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.titleBar1.ButtonForeColor = AntiCoronaGame.UserControls.TitleBar.ButtonColor.White;
            this.tableLayoutPanel1.SetColumnSpan(this.titleBar1, 3);
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBar1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar1.Location = new System.Drawing.Point(3, 3);
            this.titleBar1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.ResizeWindowsBox = AntiCoronaGame.UserControls.TitleBar.ResizeBox.NoneResize;
            this.titleBar1.Size = new System.Drawing.Size(726, 36);
            this.titleBar1.TabIndex = 2;
            this.titleBar1.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar1.TitleForeColor = System.Drawing.Color.White;
            this.titleBar1.TitleIcon = null;
            this.titleBar1.TitleText = "";
            // 
            // pnlBoderRight
            // 
            this.pnlBoderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlBoderRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBoderRight.Location = new System.Drawing.Point(726, 39);
            this.pnlBoderRight.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.pnlBoderRight.Name = "pnlBoderRight";
            this.tableLayoutPanel1.SetRowSpan(this.pnlBoderRight, 3);
            this.pnlBoderRight.Size = new System.Drawing.Size(3, 503);
            this.pnlBoderRight.TabIndex = 3;
            // 
            // pnlBoderLeft
            // 
            this.pnlBoderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlBoderLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBoderLeft.Location = new System.Drawing.Point(3, 39);
            this.pnlBoderLeft.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlBoderLeft.Name = "pnlBoderLeft";
            this.tableLayoutPanel1.SetRowSpan(this.pnlBoderLeft, 3);
            this.pnlBoderLeft.Size = new System.Drawing.Size(3, 503);
            this.pnlBoderLeft.TabIndex = 3;
            // 
            // pnlBoderBottom
            // 
            this.pnlBoderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tableLayoutPanel1.SetColumnSpan(this.pnlBoderBottom, 3);
            this.pnlBoderBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBoderBottom.Location = new System.Drawing.Point(3, 542);
            this.pnlBoderBottom.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnlBoderBottom.Name = "pnlBoderBottom";
            this.pnlBoderBottom.Size = new System.Drawing.Size(726, 3);
            this.pnlBoderBottom.TabIndex = 3;
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnQuit);
            this.pnlButton.Controls.Add(this.btnIntro);
            this.pnlButton.Controls.Add(this.btnHowTo);
            this.pnlButton.Controls.Add(this.btnAbout);
            this.pnlButton.Controls.Add(this.btnPlay);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButton.Location = new System.Drawing.Point(6, 442);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(0);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(720, 100);
            this.pnlButton.TabIndex = 4;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(578, 52);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(135, 42);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.ToolTipActive = true;
            this.btnQuit.ToolTipAutomaticDelay = 500;
            this.btnQuit.ToolTipAutoPopDelay = 5000;
            this.btnQuit.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnQuit.ToolTipCaption = "";
            this.btnQuit.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnQuit.ToolTipInitialDelay = 200;
            this.btnQuit.ToolTipIsBalloon = false;
            this.btnQuit.ToolTipReshowDelay = 100;
            this.btnQuit.ToolTipShowAlways = true;
            this.btnQuit.ToolTipTitle = "";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnIntro
            // 
            this.btnIntro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnIntro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIntro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntro.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntro.ForeColor = System.Drawing.Color.White;
            this.btnIntro.Location = new System.Drawing.Point(149, 53);
            this.btnIntro.Name = "btnIntro";
            this.btnIntro.Size = new System.Drawing.Size(135, 42);
            this.btnIntro.TabIndex = 1;
            this.btnIntro.Text = "INTRO";
            this.btnIntro.ToolTipActive = true;
            this.btnIntro.ToolTipAutomaticDelay = 500;
            this.btnIntro.ToolTipAutoPopDelay = 5000;
            this.btnIntro.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnIntro.ToolTipCaption = "";
            this.btnIntro.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnIntro.ToolTipInitialDelay = 200;
            this.btnIntro.ToolTipIsBalloon = false;
            this.btnIntro.ToolTipReshowDelay = 100;
            this.btnIntro.ToolTipShowAlways = true;
            this.btnIntro.ToolTipTitle = "";
            this.btnIntro.UseVisualStyleBackColor = false;
            this.btnIntro.Click += new System.EventHandler(this.btnIntro_Click);
            // 
            // btnHowTo
            // 
            this.btnHowTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnHowTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHowTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHowTo.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowTo.ForeColor = System.Drawing.Color.White;
            this.btnHowTo.Location = new System.Drawing.Point(292, 52);
            this.btnHowTo.Name = "btnHowTo";
            this.btnHowTo.Size = new System.Drawing.Size(135, 42);
            this.btnHowTo.TabIndex = 1;
            this.btnHowTo.Text = "HOW TO";
            this.btnHowTo.ToolTipActive = true;
            this.btnHowTo.ToolTipAutomaticDelay = 500;
            this.btnHowTo.ToolTipAutoPopDelay = 5000;
            this.btnHowTo.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnHowTo.ToolTipCaption = "";
            this.btnHowTo.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnHowTo.ToolTipInitialDelay = 200;
            this.btnHowTo.ToolTipIsBalloon = false;
            this.btnHowTo.ToolTipReshowDelay = 100;
            this.btnHowTo.ToolTipShowAlways = true;
            this.btnHowTo.ToolTipTitle = "";
            this.btnHowTo.UseVisualStyleBackColor = false;
            this.btnHowTo.Click += new System.EventHandler(this.btnHowTo_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(435, 52);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(135, 42);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "ABOUT";
            this.btnAbout.ToolTipActive = true;
            this.btnAbout.ToolTipAutomaticDelay = 500;
            this.btnAbout.ToolTipAutoPopDelay = 5000;
            this.btnAbout.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnAbout.ToolTipCaption = "";
            this.btnAbout.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnAbout.ToolTipInitialDelay = 200;
            this.btnAbout.ToolTipIsBalloon = false;
            this.btnAbout.ToolTipReshowDelay = 100;
            this.btnAbout.ToolTipShowAlways = true;
            this.btnAbout.ToolTipTitle = "";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(6, 53);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(135, 42);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.ToolTipActive = true;
            this.btnPlay.ToolTipAutomaticDelay = 500;
            this.btnPlay.ToolTipAutoPopDelay = 5000;
            this.btnPlay.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnPlay.ToolTipCaption = "";
            this.btnPlay.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnPlay.ToolTipInitialDelay = 200;
            this.btnPlay.ToolTipIsBalloon = false;
            this.btnPlay.ToolTipReshowDelay = 100;
            this.btnPlay.ToolTipShowAlways = true;
            this.btnPlay.ToolTipTitle = "";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // picIntro
            // 
            this.picIntro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picIntro.Location = new System.Drawing.Point(6, 139);
            this.picIntro.Margin = new System.Windows.Forms.Padding(0);
            this.picIntro.Name = "picIntro";
            this.picIntro.Size = new System.Drawing.Size(720, 303);
            this.picIntro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIntro.TabIndex = 5;
            this.picIntro.TabStop = false;
            // 
            // pnlText
            // 
            this.pnlText.BackgroundImage = global::AntiCoronaGame.Properties.Resources.text;
            this.pnlText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlText.Location = new System.Drawing.Point(6, 39);
            this.pnlText.Margin = new System.Windows.Forms.Padding(0);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(720, 100);
            this.pnlText.TabIndex = 6;
            // 
            // fMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(732, 548);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMainScreen";
            this.VisibleChanged += new System.EventHandler(this.fMainScreen_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIntro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlBoderRight;
        private System.Windows.Forms.Panel pnlBoderLeft;
        private System.Windows.Forms.Panel pnlBoderBottom;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.PictureBox picIntro;
        private System.Windows.Forms.Panel pnlText;
        private UserControls.FlatButton btnPlay;
        private UserControls.FlatButton btnQuit;
        private UserControls.FlatButton btnAbout;
        private UserControls.FlatButton btnIntro;
        private UserControls.FlatButton btnHowTo;
        private UserControls.TitleBar titleBar1;
    }
}