namespace AntiCoronaGame
{
    partial class fAbout
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.llbGithubHoang = new System.Windows.Forms.LinkLabel();
            this.picGithubHoang = new System.Windows.Forms.PictureBox();
            this.llbGithubKhanh = new System.Windows.Forms.LinkLabel();
            this.picGithubKhanh = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGithubHoang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGithubKhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.titleBar1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(632, 295);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // titleBar1
            // 
            this.titleBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.titleBar1.ButtonForeColor = AntiCoronaGame.UserControls.TitleBar.ButtonColor.White;
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBar1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar1.Location = new System.Drawing.Point(2, 2);
            this.titleBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.ResizeWindowsBox = AntiCoronaGame.UserControls.TitleBar.ResizeBox.NoneResize;
            this.titleBar1.Size = new System.Drawing.Size(628, 34);
            this.titleBar1.TabIndex = 0;
            this.titleBar1.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar1.TitleForeColor = System.Drawing.Color.White;
            this.titleBar1.TitleIcon = global::AntiCoronaGame.Properties.Resources.information;
            this.titleBar1.TitleText = "About";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pnlMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.panel1.Size = new System.Drawing.Size(628, 257);
            this.panel1.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.llbGithubHoang);
            this.pnlMain.Controls.Add(this.picGithubHoang);
            this.pnlMain.Controls.Add(this.llbGithubKhanh);
            this.pnlMain.Controls.Add(this.picGithubKhanh);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.btnOk);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(2, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(624, 255);
            this.pnlMain.TabIndex = 0;
            // 
            // llbGithubHoang
            // 
            this.llbGithubHoang.AutoSize = true;
            this.llbGithubHoang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbGithubHoang.Location = new System.Drawing.Point(69, 138);
            this.llbGithubHoang.Name = "llbGithubHoang";
            this.llbGithubHoang.Size = new System.Drawing.Size(238, 25);
            this.llbGithubHoang.TabIndex = 6;
            this.llbGithubHoang.TabStop = true;
            this.llbGithubHoang.Text = "github.com/huyhoangitQN";
            this.llbGithubHoang.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbGithub_LinkClicked);
            // 
            // picGithubHoang
            // 
            this.picGithubHoang.Image = global::AntiCoronaGame.Properties.Resources.github;
            this.picGithubHoang.Location = new System.Drawing.Point(33, 136);
            this.picGithubHoang.Name = "picGithubHoang";
            this.picGithubHoang.Size = new System.Drawing.Size(30, 30);
            this.picGithubHoang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGithubHoang.TabIndex = 5;
            this.picGithubHoang.TabStop = false;
            this.picGithubHoang.Click += new System.EventHandler(this.picGithubHoang_Click);
            // 
            // llbGithubKhanh
            // 
            this.llbGithubKhanh.AutoSize = true;
            this.llbGithubKhanh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbGithubKhanh.Location = new System.Drawing.Point(69, 177);
            this.llbGithubKhanh.Name = "llbGithubKhanh";
            this.llbGithubKhanh.Size = new System.Drawing.Size(225, 25);
            this.llbGithubKhanh.TabIndex = 6;
            this.llbGithubKhanh.TabStop = true;
            this.llbGithubKhanh.Text = "github.com/quockhanhtn";
            this.llbGithubKhanh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbGithub_LinkClicked);
            // 
            // picGithubKhanh
            // 
            this.picGithubKhanh.Image = global::AntiCoronaGame.Properties.Resources.github;
            this.picGithubKhanh.Location = new System.Drawing.Point(33, 175);
            this.picGithubKhanh.Name = "picGithubKhanh";
            this.picGithubKhanh.Size = new System.Drawing.Size(30, 30);
            this.picGithubKhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGithubKhanh.TabIndex = 5;
            this.picGithubKhanh.TabStop = false;
            this.picGithubKhanh.Click += new System.EventHandler(this.picGithubKhanh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "© 2020 Hồ Huy Hoàng - Lâm Quốc Khánh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "AntiCoronaGame version 1.0";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(503, 198);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 35);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // fAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 295);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About - AntiCoronaGame";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGithubHoang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGithubKhanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AntiCoronaGame.UserControls.TitleBar titleBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llbGithubKhanh;
        private System.Windows.Forms.PictureBox picGithubKhanh;
        private System.Windows.Forms.LinkLabel llbGithubHoang;
        private System.Windows.Forms.PictureBox picGithubHoang;
    }
}