using System;
using System.Windows.Forms;

namespace AntiCoronaGame
{
    public partial class fAbout : Form
    {
        #region Constructor
        public fAbout()
        {
            InitializeComponent();
        }
        #endregion

        #region Method
        public static void Show(Form parentForm)
        {
            using (fAbout formAbout = new fAbout())
            {
                parentForm.Hide();
                formAbout.ShowDialog(parentForm);
                parentForm.Show();
            }
        }
        #endregion

        #region Events

        private void llbGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var llb = sender as LinkLabel;
            System.Diagnostics.Process.Start("http://" + llb.Text);
        }

        private void picGithubHoang_Click(object sender, EventArgs e)
        {
            llbGithub_LinkClicked(llbGithubHoang, null);
        }

        private void picGithubKhanh_Click(object sender, EventArgs e)
        {
            llbGithub_LinkClicked(llbGithubKhanh, null);
        }
        #endregion
    }
}
