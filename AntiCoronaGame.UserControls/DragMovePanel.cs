﻿using System.Drawing;
using System.Windows.Forms;

namespace AntiCoronaGame.UserControls
{
    public class DragMovePanel : Panel
    {
        private Point oldLocation;
        private Point distanceMoved;
        private Point DistanceMoved
        {
            get => distanceMoved;
            set
            {
                distanceMoved = value;
                int parentXLoc = this.FindForm().Location.X + distanceMoved.X - oldLocation.X;
                int parentYLoc = this.FindForm().Location.Y + distanceMoved.Y - oldLocation.Y;
                this.FindForm().Location = new Point(parentXLoc, parentYLoc);
            }
        }
        public DragMovePanel()
        {
            this.MouseDown += DragMovePanel_MouseDown;
            this.MouseMove += DragMovePanel_MouseMove;
            this.MouseUp += DragMovePanel_MouseUp;
        }

        private void DragMovePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Cursor = Cursors.SizeAll;
                this.oldLocation = e.Location;
            }
        }

        private void DragMovePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Cursor == Cursors.SizeAll)
            {
                DistanceMoved = e.Location;
            }
        }

        private void DragMovePanel_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
