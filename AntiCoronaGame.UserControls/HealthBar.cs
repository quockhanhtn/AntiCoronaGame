using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiCoronaGame.UserControls
{
    public static class GraphicsExtensions
    {
        public static void DrawRectangle(this Graphics g, Pen pen, RectangleF rect) =>
            g.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);
    }
    public class HealthBar : DoubleBufferedPanel
    {
        private int healthPercent = 100;
        private Color healthColor;

        [Category("Tool tip"), Description("")]
        public int HealthPercent { 
            get => healthPercent;
            set
            {
                if (value < 0) { healthPercent = 0; }
                else if (value > 100) { healthPercent = 100; }
                else { healthPercent = value; }
                this.Invalidate();
            }
        }

        [Category("Tool tip"), Description("")]
        public Color HealthColor { get => healthColor; set { healthColor = value; this.Invalidate(); } }

        

        public HealthBar()
        {
            this.Paint += HealthBar_Paint;
        }

        private void HealthBar_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Brush brush = new SolidBrush(HealthColor))
            {
                float recWidth = (this.Width * HealthPercent) / 100;
                RectangleF rectangleF = new RectangleF(new PointF(0, 0), new SizeF(recWidth, this.Height)); ;
                e.Graphics.FillRectangle(brush, rectangleF);
            }
        }
    }
}
