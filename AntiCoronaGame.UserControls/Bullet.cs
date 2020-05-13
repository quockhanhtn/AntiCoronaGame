using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiCoronaGame.UserControls
{
    public class Bullet : PictureBox
    {
        public Bullet(Control parent, int left, int top)
        {
            this.BackColor = Color.Transparent;
            this.Height = 15;
            this.Width = 60;
            this.Image = Properties.Resources.bullet;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Left = left;
            this.Tag = "bullet";
            this.Top = top;

            parent.Controls.Add(this);
        }
    }
}
