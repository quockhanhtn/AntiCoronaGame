using System;
using System.Media;
using System.Windows.Forms;

namespace AntiCoronaGame.UserControls
{
    public class CountDownLabel : Label
    {
        public CountDownLabel(int countDown)
        {
            this.countDown = countDown;
            if (countDown == 3)
            {
                var sound = new SoundPlayer(Properties.Resources.three);
                sound.Play();
            }

            this.AutoSize = true;
            this.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.Location = new System.Drawing.Point(421, 157);
            this.Size = new System.Drawing.Size(91, 106);
            this.TabIndex = 10;
            this.Text = countDown.ToString();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            
        }

        public void StartCountDown(Action afterCountDownMethods)
        {
            timer.Start();
            this.afterCountDownMethods = afterCountDownMethods;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            countDown -= 1;
            this.Text = countDown.ToString();

            if (countDown == 3)
            {
                var sound = new SoundPlayer(Properties.Resources.three);
                sound.Play();
            }
            else if (countDown == 2)
            {
                var sound = new SoundPlayer(Properties.Resources.two);
                sound.Play();
            }
            else if (countDown == 1)
            {
                var sound = new SoundPlayer(Properties.Resources.one);
                sound.Play();
            }
            else if (countDown == 0)
            {
                var sound = new SoundPlayer(Properties.Resources.go);
                sound.Play();
                afterCountDownMethods();
                this.Dispose();
            }
        }

        Timer timer;
        int countDown = 0;
        Action afterCountDownMethods;
    }
}
