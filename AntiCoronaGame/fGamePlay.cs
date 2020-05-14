using AntiCoronaGame.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
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

        int bestScore = 0;

        SoundPlayer bulletSound = new SoundPlayer(Properties.Resources.burst);
        SoundPlayer coughSound = new SoundPlayer(Properties.Resources.cough_sound);
        Random random = new Random();

        public int Score
        {
            get => score; 
            set
            {
                score = value;
                Level = ((int)(value / 10));
                lblScore.Value = value;
                if (value > BestScore)
                {
                    BestScore = value;
                }
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

        public int BestScore
        {
            get => bestScore;
            set
            {
                bestScore = value;
                lblBestScore.Value = value;
            }
        }

        public fGamePlay()
        {
            InitializeComponent();
            pnlGameInfor.Enabled = false;
            BestScore = GetBestScore();
            picPillar1.Location = new Point(250, random.Next(-180, -50));
            picPillar2.Location = new Point(500, random.Next(270, 320));
            picPillar3.Location = new Point(750, random.Next(-180, -50));
            picPillar4.Location = new Point(0, random.Next(270, 320));
        }

        public void StartGame()
        {
            pnlGameInfor.Enabled = true;
            tmrGameUpdate.Start();
        }

        public void MovePillar()
        {
            picPillar1.Left -= speed;
            picPillar2.Left -= speed;
            picPillar3.Left -= speed;
            picPillar4.Left -= speed;
            if (picPillar1.Left <= -100)
            {
                picPillar1.Location = new Point(750, random.Next(-180, -50));
                picPillar1.Left = 900;
            }
            if (picPillar2.Left <= -100)
            {
                picPillar2.Location = new Point(500, random.Next(270, 320));
                picPillar2.Left = 900;
            }
            if (picPillar3.Left <= -100)
            {
                picPillar3.Location = new Point(750, random.Next(-180, -50));
                picPillar3.Left = 900;
            }
            if (picPillar4.Left <= -100)
            {
                picPillar4.Location = new Point(500, random.Next(270, 320));
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
            picVirus2.Left -= speed;
            picVirus1.Left -= speed;
            if (picVirus2.Left < -100)
            {
                picVirus2.Left = 900;
                picVirus2.Top = random.Next(100, 330) - picVirus2.Height;
            }
            if (picVirus1.Left < -100)
            {
                picVirus1.Left = 900;
                picVirus1.Top = random.Next(100, 330) - picVirus2.Height;
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
                    if (item.Bounds.IntersectsWith(picVirus2.Bounds))
                    {
                        Score += 1;
                        pnlGamePlay.Controls.Remove(item);
                        item.Dispose();
                        picVirus2.Left = 1000;
                        picVirus2.Top = random.Next(100, 330) - picVirus2.Height;
                        ChangeCorona();
                    }

                    if (item.Bounds.IntersectsWith(picVirus1.Bounds))
                    {
                        Score += 1;
                        pnlGamePlay.Controls.Remove(item);
                        item.Dispose();
                        picVirus1.Left = 1000;
                        picVirus1.Top = random.Next(100, 330) - picVirus2.Height;
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
                        picVirus2.Image = Properties.Resources.corona_0;
                        picVirus1.Image = Properties.Resources.corona_1;
                        break;
                    }
                case 2:
                    {
                        picVirus2.Image = Properties.Resources.corona_3;
                        picVirus1.Image = Properties.Resources.corona_4;
                        break;
                    }
                case 3:
                    {
                        picVirus2.Image = Properties.Resources.corona_5;
                        picVirus1.Image = Properties.Resources.corona_0;
                        break;
                    }
            }
        }
        public void GameOver()
        {
            //if (picPlayer.IsHit(picPillar1.Bounds, picPillar1.Location)) 
            //{
            //    //health = 0;
            //    //healthBar.HealthPercent = 0;
            //    lblBestScore.Text = "1";
            //}
            //if (picPlayer.IsHit(picPillar2.Bounds, picPillar2.Location))
            //{
            //    //health = 0;
            //    //healthBar.HealthPercent = 0;
            //    lblBestScore.Text = "2";
            //}
            //if (picPlayer.IsHit(picPillar3.Bounds, picPillar3.Location))
            //{
            //    //health = 0;
            //    //healthBar.HealthPercent = 0;
            //    lblBestScore.Text = "3";
            //}
            //if (picPlayer.IsHit(picPillar4.Bounds, picPillar4.Location))
            //{
            //    //health = 0;
            //    //healthBar.HealthPercent = 0;
            //    lblBestScore.Text = "4";
            //}

            if (picPlayer.Bounds.IntersectsWith(picPillar1.Bounds)
                || picPlayer.Bounds.IntersectsWith(picPillar2.Bounds)
                || picPlayer.Bounds.IntersectsWith(picPillar3.Bounds)
                || picPlayer.Bounds.IntersectsWith(picPillar4.Bounds))
            {
                health = 0;
                healthBar.HealthPercent = 0;
            }
            if (picPlayer.Bounds.IntersectsWith(picVirus2.Bounds))
            {
                health = health - 10;
                healthBar.HealthPercent -= 10;
                picVirus2.Left = 1000;
                coughSound.Play();
            }
            if (picPlayer.Bounds.IntersectsWith(picVirus1.Bounds))
            {
                health = health - 10;
                healthBar.HealthPercent -= 10;
                picVirus1.Left = 1000;
                coughSound.Play();
            }

            if (health == 0)
            {
                tmrGameUpdate.Stop();
                SetBestScore();
                fGameOver formGameOver = new fGameOver();
                formGameOver.SetScores(Score, BestScore);
                switch (formGameOver.ShowDialog(this))
                {
                    case DialogResult.OK:       //Replay
                        btnReplay.PerformClick();
                        break;
                    case DialogResult.Cancel:   //Home
                        this.Close();
                        break;
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
        
        private void fGamePlay_Load(object sender, EventArgs e)
        {
            tmrGameUpdate.Stop();
            picPlayer.Focus();
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

        private void fGamePlay_Shown(object sender, EventArgs e)
        {
            CountDownLabel countDown = new CountDownLabel(3);
            pnlGamePlay.Controls.Add(countDown);
            countDown.StartCountDown(StartGame);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Program.FormMainScreen.Show();
            this.Close();
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            fGamePlay formGamePlay = new fGamePlay();
            formGamePlay.StartPosition = FormStartPosition.CenterScreen;
            formGamePlay.Show();
            this.Close();
        }

        int GetBestScore()
        {
            int result = 0;
            string fileName = @"gameSave.config";
            if (File.Exists(fileName))
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    int.TryParse(sr.ReadLine(), out result);
                }
            }
            return result;
        }

        void SetBestScore()
        {
            string fileName = @"gameSave.config";
            if (File.Exists(fileName)) { File.Delete(fileName); }
            using (FileStream fs = File.Create(fileName))
            { 
                Byte[] text = new UTF8Encoding(true).GetBytes(BestScore.ToString());
                fs.Write(text, 0, text.Length);
            }
        }
    }
}
