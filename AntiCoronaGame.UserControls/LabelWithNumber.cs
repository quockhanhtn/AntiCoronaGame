using System.ComponentModel;
using System.Windows.Forms;

namespace AntiCoronaGame.UserControls
{
    /// <summary>
    /// Subclass of label, diplay "TextDisplay : Value"
    /// </summary>
    public class LabelWithNumber : Label
    {
        int value;
        string textDisplay;

        [Category("My properties"), Description("Value of number will display in the right of label")]
        public int Value
        {
            get => value;
            set
            {
                this.value = value;
                this.Text = this.TextDisplay + ": " + value.ToString();
            }
        }

        [Category("My properties"), Description("Value of text")]
        public string TextDisplay
        {
            get => textDisplay; set
            {
                textDisplay = value;
                this.Text = value + ": " + this.Value.ToString();
            }
        }
    }
}
