using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace AntiCoronaGame
{
    public partial class fGameOver : Form
    {
        public fGameOver()
        {
            InitializeComponent();
        }

        public void SetScores(int yourScores, int bestScores)
        {
            this.lblYourScores.Text = yourScores.ToString();
            this.lblBestScores.Text = bestScores.ToString();
        }

        private void dragMovePanel1_Paint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Color.FromArgb(0, 122, 204), 5))
            {
                var rec = new Rectangle(new Point(5, 5), new Size(dragMovePanel1.Width - 10, dragMovePanel1.Height - 10));
                e.Graphics.DrawRectangle(pen, rec);
            }
        }

        private void btnQuit_Click(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát trò chơi :(", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void fGameOver_Shown(object sender, System.EventArgs e)
        {
            var musicGameOver = new SoundPlayer(Properties.Resources.game_over1);
            musicGameOver.Play();
        }
    }
}
