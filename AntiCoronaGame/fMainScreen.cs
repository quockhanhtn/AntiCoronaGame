using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiCoronaGame
{
    public partial class fMainScreen : Form
    {
        SoundPlayer musicIntro = new SoundPlayer(Properties.Resources.intro_audio);
        fGamePlay formGamePlay;

        public fMainScreen()
        {
            InitializeComponent();
            formGamePlay = new fGamePlay();
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
            formGamePlay.ShowDialog(this);
            this.Show();
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            fIntro.Show(this);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {

        }
    }
}
