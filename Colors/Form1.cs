using System;
using System.Drawing;
using System.Windows.Forms;

namespace Color_Palette
{
    public partial class ColorForm : Form
    {
        public ColorForm()
        {
            InitializeComponent();
            colorOutput.BackColor = Color.FromArgb(redTrack.Value, greenTrack.Value, blueTrack.Value);
        }

        /// <summary>
        /// Changes color depening on scrolls values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorTrack_Scroll(object sender, EventArgs e)
        {
            colorOutput.BackColor = Color.FromArgb(redTrack.Value, greenTrack.Value, blueTrack.Value);
        }

        /// <summary>
        /// Prints current color code in label
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Argument</param>
        private void Color_MouseHover(object sender, EventArgs e)
        {
            label1.Text = ColorTranslator.ToHtml(colorOutput.BackColor);
            label1.Location = Point.Subtract(MousePosition, new Size(Bounds.Location));
            label1.Visible = true;
        }

        /// <summary>
        /// Makes label with color code invisible on moves moved away
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Argument</param>
        private void Color_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        /// <summary>
        /// Sets color code in bufer
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event Argument</param>
        private void Color_BackColorChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(ColorTranslator.ToHtml(colorOutput.BackColor));
        }
    }
}
