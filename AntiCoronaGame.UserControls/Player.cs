using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AntiCoronaGame.UserControls
{
    public class Player : PictureBox
    {
        List<Point> points = new List<Point>();
        protected GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                path.AddPolygon(points.ToArray());
                return path;
            }
        }
        public Player()
        {
            this.BackColor = Color.Transparent;
            this.Image = Properties.Resources.player;
            this.Size = new Size(135, 75);
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.TabIndex = 0;
            this.TabStop = false;

            CreatePoints();

            this.Paint += Player_Paint;
            this.LocationChanged += Player_LocationChanged;
            this.MouseClick += Player_MouseClick;
        }

        private void Player_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location.ToString());
        }

        private void Player_LocationChanged(object sender, EventArgs e)
        {
        }

        private void Player_Paint(object sender, PaintEventArgs e)
        {
            using (GraphicsPath path = this.GraphicsPath)
            {
                using (Pen pen = new Pen(Color.Black, 1) { DashStyle = DashStyle.Solid })
                {
                    e.Graphics.DrawPath(pen, path);
                }
                using (Brush brush = new SolidBrush(Color.Black))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }

        public bool IsHit(PointF point)
        {
            bool result = false;
            point = new PointF(point.X - this.Location.X, point.Y - this.Location.Y);
            using (GraphicsPath path = this.GraphicsPath)
            {
                using (Pen pen = new Pen(Color.Black, 3))
                {
                    result = path.IsOutlineVisible(point, pen);
                }
            }
            return result;
        }

        void CreatePoints()
        {
            points.Add(new Point(94, 3));
            points.Add(new Point(78, 26));
            points.Add(new Point(136, 28));
            points.Add(new Point(137, 41));
            points.Add(new Point(81, 42));
            points.Add(new Point(61, 44));
            points.Add(new Point(68, 61));
            points.Add(new Point(45, 68));
            points.Add(new Point(48, 75));
            points.Add(new Point(1, 68));
            points.Add(new Point(5, 50));
            points.Add(new Point(5, 26));
            points.Add(new Point(63, 11));
            points.Add(new Point(67, 1));
            points.Add(new Point(67, 1));
            points.Add(new Point(67, 1));
        }
    }
}
