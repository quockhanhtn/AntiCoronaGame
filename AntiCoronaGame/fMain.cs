using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiCoronaGame
{
    public partial class fMain : Form
    {
        #region Propertis
        private List<PictureBox> buttonList = new List<PictureBox>();
        public SoundPlayer music = new SoundPlayer(Properties.Resources.audio);
        private fGamePlay fGameplay;
        private LoadingGame gameLoading;
        #endregion
        public fMain()
        {
            InitializeComponent();
            fGameplay = new fGamePlay();
            DrawLogin();
            music.PlayLooping();
            gameLoading = new LoadingGame(fGameplay);
        }
        #region Methods
        private void GetImage()
        {
            buttonList[0].Image = Properties.Resources.btnPlay;
            buttonList[1].Image = Properties.Resources.btnAbout;
            buttonList[2].Image = Properties.Resources.btnQuit;
            buttonList[3].Image = Properties.Resources.btnReplay;
            buttonList[4].Image = Properties.Resources.btnHome;
        }
        private void InitButtons()
        {
            PictureBox picTemp = new PictureBox { Height = 0, Location = new Point(500, 80) };
            for (int i = 0; i < 5; i++)
            {
                PictureBox ptb = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    BackColor = Color.Transparent,
                    Location = new Point(picTemp.Location.X, picTemp.Location.Y + picTemp.Height + 20),
                    Tag = i.ToString()
                };
                picTemp = ptb;
                ptb.Click += ptb_Click;
                ptb.MouseHover += ptb_MouseHover;
                ptb.MouseLeave += ptb_MouseLeave;
                buttonList.Add(ptb);
            }
            GetImage();
        }

        void ptb_MouseLeave(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            btn.BackColor = Color.Transparent;
        }

        void ptb_MouseHover(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            btn.BackColor = Color.Red;
        }
        private void DrawLogin()
        {
            InitButtons();
            for (int i = 0; i < 3; i++)
                this.Controls.Add(buttonList[i]);
        }
        #endregion
        #region Events

        //+Hàm xử lý sự kiện các button được nhấn
        private void ptb_Click(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            if (Equals(btn.Tag, "0"))
            {
                this.Hide();
                music.Stop();
                fGameplay.Show();
                gameLoading.InitEvents();

            }
            if (Equals(btn.Tag, "1"))
            {
                //fAbout fAbout = new fAbout();
                //fAbout.ShowDialog();
            }
            if (Equals(btn.Tag, "2"))
            {
                if (MessageBox.Show("Bạn muốn thoát chứ ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    Application.Exit();

            }
        }
        #endregion
    }
}
