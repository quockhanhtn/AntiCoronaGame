namespace AntiCoronaGame
{
    partial class fGameOver
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
            this.dragMovePanel1 = new AntiCoronaGame.UserControls.DragMovePanel();
            this.btnQuit = new AntiCoronaGame.UserControls.FlatButton();
            this.btnReplay = new AntiCoronaGame.UserControls.FlatButton();
            this.bntHome = new AntiCoronaGame.UserControls.FlatButton();
            this.lblBestScores = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblYourScores = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dragMovePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dragMovePanel1
            // 
            this.dragMovePanel1.BackColor = System.Drawing.Color.White;
            this.dragMovePanel1.Controls.Add(this.btnQuit);
            this.dragMovePanel1.Controls.Add(this.btnReplay);
            this.dragMovePanel1.Controls.Add(this.bntHome);
            this.dragMovePanel1.Controls.Add(this.lblBestScores);
            this.dragMovePanel1.Controls.Add(this.label2);
            this.dragMovePanel1.Controls.Add(this.lblYourScores);
            this.dragMovePanel1.Controls.Add(this.label1);
            this.dragMovePanel1.Controls.Add(this.pictureBox1);
            this.dragMovePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dragMovePanel1.Location = new System.Drawing.Point(0, 0);
            this.dragMovePanel1.Name = "dragMovePanel1";
            this.dragMovePanel1.Size = new System.Drawing.Size(560, 341);
            this.dragMovePanel1.TabIndex = 0;
            this.dragMovePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.dragMovePanel1_Paint);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(362, 269);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(135, 42);
            this.btnQuit.TabIndex = 6;
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
            // btnReplay
            // 
            this.btnReplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReplay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnReplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplay.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplay.ForeColor = System.Drawing.Color.White;
            this.btnReplay.Location = new System.Drawing.Point(76, 269);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(135, 42);
            this.btnReplay.TabIndex = 7;
            this.btnReplay.Text = "REPLAY";
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
            this.btnReplay.ToolTipTitle = "";
            this.btnReplay.UseVisualStyleBackColor = false;
            // 
            // bntHome
            // 
            this.bntHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bntHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bntHome.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntHome.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntHome.ForeColor = System.Drawing.Color.White;
            this.bntHome.Location = new System.Drawing.Point(219, 269);
            this.bntHome.Name = "bntHome";
            this.bntHome.Size = new System.Drawing.Size(135, 42);
            this.bntHome.TabIndex = 8;
            this.bntHome.Text = "HOME";
            this.bntHome.ToolTipActive = true;
            this.bntHome.ToolTipAutomaticDelay = 500;
            this.bntHome.ToolTipAutoPopDelay = 5000;
            this.bntHome.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.bntHome.ToolTipCaption = "";
            this.bntHome.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.bntHome.ToolTipInitialDelay = 200;
            this.bntHome.ToolTipIsBalloon = false;
            this.bntHome.ToolTipReshowDelay = 100;
            this.bntHome.ToolTipShowAlways = true;
            this.bntHome.ToolTipTitle = "";
            this.bntHome.UseVisualStyleBackColor = false;
            // 
            // lblBestScores
            // 
            this.lblBestScores.AutoSize = true;
            this.lblBestScores.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestScores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.lblBestScores.Location = new System.Drawing.Point(355, 205);
            this.lblBestScores.Name = "lblBestScores";
            this.lblBestScores.Size = new System.Drawing.Size(33, 38);
            this.lblBestScores.TabIndex = 5;
            this.lblBestScores.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.label2.Location = new System.Drawing.Point(153, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Best scores :";
            // 
            // lblYourScores
            // 
            this.lblYourScores.AutoSize = true;
            this.lblYourScores.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourScores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.lblYourScores.Location = new System.Drawing.Point(355, 151);
            this.lblYourScores.Name = "lblYourScores";
            this.lblYourScores.Size = new System.Drawing.Size(33, 38);
            this.lblYourScores.TabIndex = 5;
            this.lblYourScores.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(153, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Your scores : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AntiCoronaGame.Properties.Resources.game_over;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fGameOver
            // 
            this.AcceptButton = this.btnReplay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 341);
            this.Controls.Add(this.dragMovePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fGameOver";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fAbout";
            this.Shown += new System.EventHandler(this.fGameOver_Shown);
            this.dragMovePanel1.ResumeLayout(false);
            this.dragMovePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.DragMovePanel dragMovePanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UserControls.FlatButton btnQuit;
        private UserControls.FlatButton btnReplay;
        private UserControls.FlatButton bntHome;
        private System.Windows.Forms.Label lblBestScores;
        private System.Windows.Forms.Label lblYourScores;
    }
}