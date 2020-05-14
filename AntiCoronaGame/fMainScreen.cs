using System;
using System.Media;
using System.Windows.Forms;

namespace AntiCoronaGame
{
    public partial class fMainScreen : Form
    {
        SoundPlayer musicIntro = new SoundPlayer(Properties.Resources.intro_audio);

        public fMainScreen()
        {
            InitializeComponent();
        }

        private void fMainScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                musicIntro.PlayLooping();
                picIntro.Image = Properties.Resources.intro;
            }
            else
            {
                musicIntro.Stop();
                picIntro.Image = null;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formGamePlay = new fGamePlay();
            formGamePlay.ShowDialog(this);
        }

        private void btnIntro_Click(object sender, EventArgs e) { fIntro.Show(this); }

        private void btnHowTo_Click(object sender, EventArgs e) {  fHowTo.Show(this); }

        private void btnAbout_Click(object sender, EventArgs e) { fAbout.Show(this); }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát trò chơi :(", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes) { this.Close(); }
        }
    }
}
