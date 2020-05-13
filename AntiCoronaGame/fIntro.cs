using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiCoronaGame
{
    public partial class fIntro : Form
    {
        static fIntro formIntro = new fIntro();
        public fIntro()
        {
            InitializeComponent();
        }

        public static void Show(Form parentForm)
        {
            parentForm.Hide();
            formIntro.ShowDialog();
            parentForm.Refresh();
            parentForm.Show();
        }

        private void fIntro_Load(object sender, EventArgs e)
        {
            LoadingGame gameLoading = new LoadingGame(this);
            gameLoading.InitEvents();
        }
    }
}
