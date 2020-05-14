using System.Windows.Forms;

namespace AntiCoronaGame
{
    public partial class fHowTo : Form
    {
        #region Constructor
        public fHowTo()
        {
            InitializeComponent();
        }
        #endregion

        #region Method
        public static void Show(Form parentForm)
        {
            using (fHowTo formHowTo = new fHowTo())
            {
                parentForm.Hide();
                formHowTo.ShowDialog(parentForm);
                parentForm.Show();
            }
        }
        #endregion
    }
}
