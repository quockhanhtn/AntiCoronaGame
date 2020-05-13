using AntiCoronaGame.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace AntiCoronaGame
{
    public partial class fGamePlay : Form
    {
        int speed = 10;
        int playerSpeed = 15;
        bool goUp;
        bool goDown;
        bool turnLeft;
        bool turnRight;
        bool shot = false;
        int score = 0;
        int index = 1;
        int level = 1;
        int health = 100;
        
        SoundPlayer bulletSound = new SoundPlayer(Properties.Resources.burst);
        SoundPlayer coughSound = new SoundPlayer(Properties.Resources.cough_sound);
        Random random = new Random();

        public int Score
        {
            get => score; set
            {
                score = value;
                Level = ((int)(value / 10));
                lblPoint.Value = value;
            }
        }

        public int Level
        {
            get => level;
            set
            {
                level = value;
                lblLevel.Value = value;
            }
        }

        public fGamePlay()
        {
            InitializeComponent();
            this.Invalidate();  // request a delayed Repaint by the normal MessageLoop system    
            this.Update();      // forces Repaint of invalidated area 
            this.Refresh();
        }

        #region Methods
        public void StartGame()
        {
            btnPause.PerformClick();
        }

        public void MovePillar()
        {
            picPillar1.Left -= speed;
            picPillar2.Left -= speed;
            picPillar3.Left -= speed;
            picPillar4.Left -= speed;
            if (picPillar1.Left <= -100)
            {
                picPillar1.Left = 900;
            }
            if (picPillar2.Left <= -100)
            {
                picPillar2.Left = 900;
            }
            if (picPillar3.Left <= -100)
            {
                picPillar3.Left = 900;
            }
            if (picPillar4.Left <= -100)
            {
                picPillar4.Left = 900;
            }
        }
        public void MovePlayer()
        {
            if (goDown)
            {
                if (picPlayer.Top < 330)
                {
                    picPlayer.Top += playerSpeed;
                }
            }
            if (goUp)
            {
                if (picPlayer.Top > playerSpeed)
                {
                    picPlayer.Top -= playerSpeed;
                }
            }
            if (turnLeft)
            {
                picPlayer.Left -= playerSpeed;
            }
            if (turnRight)
            {
                picPlayer.Left += playerSpeed;
            }
        }
        public void MoveCorona()
        {
            pBUfo1.Left -= speed;
            pBUfo2.Left -= speed;
            if (pBUfo1.Left < -100)
            {
                pBUfo1.Left = 900;
                pBUfo1.Top = random.Next(100, 330) - pBUfo1.Height;
            }
            if (pBUfo2.Left < -100)
            {
                pBUfo2.Left = 900;
                pBUfo2.Top = random.Next(100, 330) - pBUfo1.Height;
            }

        }
        public void MakeBullet()
        {
            Bullet bullet = new Bullet(pnlGamePlay, picPlayer.Left + picPlayer.Width, picPlayer.Top + 25);
        }
        public void Make()
        {
            foreach (Control item in pnlGamePlay.Controls)
            {
                if (item is Bullet)
                {
                    // bắn đạn ra
                    item.Left += 15;// tốc độ đạn

                    if (item.Left > 400) { item.Top += 2; }
                    if (item.Left > 900)
                    {
                        pnlGamePlay.Controls.Remove(item);
                        item.Dispose();
                    }
                    // nếu bắn trúng
                    if (item.Bounds.IntersectsWith(pBUfo1.Bounds))
                    {
                        Score += 1;
                        pnlGamePlay.Controls.Remove(item);
                        item.Dispose();
                        pBUfo1.Left = 1000;
                        pBUfo1.Top = random.Next(100, 330) - pBUfo1.Height;
                        ChangeCorona();
                    }
                    if (item.Bounds.IntersectsWith(pBUfo2.Bounds))
                    {
                        Score += 1;
                        pnlGamePlay.Controls.Remove(item);
                        item.Dispose();
                        pBUfo2.Left = 1000;
                        pBUfo2.Top = random.Next(100, 330) - pBUfo1.Height;
                        ChangeCorona();
                    }
                }
            }
        }
        public void ChangeCorona()
        {
            index += 1;
            if (index > 3)
                index = 1;
            switch (index)
            {
                case 1:
                    {
                        pBUfo1.Image = Properties.Resources.corona_0;
                        pBUfo2.Image = Properties.Resources.corona_1;
                        break;
                    }
                case 2:
                    {
                        pBUfo1.Image = Properties.Resources.corona_3;
                        pBUfo2.Image = Properties.Resources.corona_4;
                        break;
                    }
                case 3:
                    {
                        pBUfo1.Image = Properties.Resources.corona_5;
                        pBUfo2.Image = Properties.Resources.corona_0;
                        break;
                    }
            }
        }
        public void GameOver()
        {
            if (picPlayer.IsHit(new Point(picPillar1.Location.X, picPillar1.Location.Y + picPillar1.Height))
                || picPlayer.IsHit(picPillar2.Location)
                || picPlayer.IsHit(new Point(picPillar3.Location.X, picPillar3.Location.Y + picPillar3.Height))
                || picPlayer.IsHit(picPillar4.Location))
            {
                health = 0;
                healthBar.HealthPercent = 0;
            }

            //if (picPlayer.Bounds.IntersectsWith(picPillar1.Bounds)
            //    || picPlayer.Bounds.IntersectsWith(picPillar2.Bounds)
            //    || picPlayer.Bounds.IntersectsWith(picPillar3.Bounds))
            //{
            //    health = 0;
            //    healthBar.HealthPercent = 0;
            //}
            if (picPlayer.Bounds.IntersectsWith(pBUfo1.Bounds))
            {
                health = health - 10;
                healthBar.HealthPercent -= 10;
                pBUfo1.Left = 1000;
                coughSound.Play();
            }
            if (picPlayer.Bounds.IntersectsWith(pBUfo2.Bounds))
            {
                health = health - 10;
                healthBar.HealthPercent -= 10;
                pBUfo2.Left = 1000;
                coughSound.Play();
            }

            if (health == 0)
            {
                tmrGameUpdate.Stop();
                //pBUfo1.Hide();
                //pBUfo2.Hide();
                //picPillar1.Hide();
                //picPillar2.Hide();
                //picPillar3.Hide();
                //picPlayer.Hide();
                //lbgameover.Show();
                if (MessageBox.Show("Bạn đã được: " + Score + " điểm.\nBạn có muốn chơi tiếp", "Điểm số:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                    fGamePlay fGamePlay = new fGamePlay();
                    fGamePlay.ShowDialog();
                }
            }
        }
        public void MakeLevel()
        {
            Level = (Score / 10);
            switch (Level)
            {
                case 0:
                    speed = 7;
                    break;
                case 1:
                    speed = 10;
                    break;
                case 2:
                    speed = 13;
                    break;
                case 3:
                    speed = 16;
                    break;
                case 4:
                    speed = 19;
                    break;
                case 5:
                    speed = 22;
                    break;
                case 6:
                    speed = 25;
                    break;
                case 7:
                    speed = 28;
                    break;
                case 8:
                    speed = 31;
                    break;
                case 9:
                    speed = 34;
                    break;
                case 10:
                    speed = 37;
                    break;
                default:
                    speed = 40;
                    break;
            }
        }
        #endregion
        #region Events

        private void fGamePlay_Load(object sender, EventArgs e)
        {
            tmrGameUpdate.Stop();
            //lbgameover.Hide();
            picPlayer.Focus();
            //tmrGameUpdate.Start();
        }

        private void fGamePlay_KeyDown(object sender, KeyEventArgs e)
        {
            pnlGamePlay.Focus();
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                goUp = true;
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                goDown = true;
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                turnLeft = true;
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                turnRight = true;
            else if (e.KeyCode == Keys.Space && shot == false)
            {
                MakeBullet();
                shot = true;
                bulletSound.Play();
            }
            else if (e.KeyCode == Keys.P)
            {
                btnPause.PerformClick();
            }
        }
        private void fGamePlay_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                goUp = false;
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                goDown = false;
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                turnLeft = false;
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                turnRight = false;
            else if (shot == true)
                shot = false;
        }

        private void pBHome_Click(object sender, EventArgs e)
        {
            this.Close();
            fMain fMain = new fMain();
            fMain.Show();
        }
        #endregion

        private void tmrGameUpdate_Tick(object sender, EventArgs e)
        {
            MovePillar();
            MovePlayer();
            MoveCorona();
            Make();
            GameOver();
            MakeLevel();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (tmrGameUpdate.Enabled)
            {
                btnPause.BackgroundImage = Properties.Resources.play;
                tmrGameUpdate.Stop();
            }
            else
            {
                btnPause.BackgroundImage = Properties.Resources.pause;
                tmrGameUpdate.Start();
            }
        }

        private void fGamePlay_Paint(object sender, PaintEventArgs e)
        {
            using (Image background = new Bitmap(Properties.Resources.background, new Size(1260, 415)))
            {
                e.Graphics.DrawImageUnscaled(background, new Point(pnlGamePlay.Location.X, pnlGamePlay.Location.Y));
            }
        }
    }
}
