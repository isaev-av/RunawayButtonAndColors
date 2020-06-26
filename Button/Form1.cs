using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Runaway_Button
{
    public partial class RunButtonView : Form
    {
        private Point mousePoint;

        public RunButtonView()
        {
            InitializeComponent();
        }

        private void PushMeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations, you managed to pressed the button!");
        }

        private void RunButtonView_MouseMove(object sender, MouseEventArgs e)
        {
            Point newMPosition = Point.Subtract(MousePosition, new Size(mousePoint));
            Point newMousePoint = new Point
            {
                X = SetX(ref newMPosition),
                Y = SetY(newMPosition)
            };

            if (newMousePoint.X < 0)
            {
                newMousePoint.X = 0;
            }
            if (newMousePoint.Y < 0)
            {
                newMousePoint.Y = 0;
            }
            if (newMousePoint.X > ClientRectangle.Width - pushMeButton.Width)
            {
                newMousePoint.X = ClientRectangle.Width - pushMeButton.Width;
            }
            if (newMousePoint.Y > ClientRectangle.Height - pushMeButton.Height)
            {
                newMousePoint.Y = ClientRectangle.Height - pushMeButton.Height;
            }
            pushMeButton.Location = newMousePoint;
            mousePoint = MousePosition;
        }

        private int SetY(Point mouseChange)
        {
            return Math.Abs(pushMeButton.Location.Y + pushMeButton.Height / 2 + Bounds.Y + 40 - MousePosition.Y)
                <= Math.Abs(pushMeButton.Location.Y + pushMeButton.Height / 2 + Bounds.Y + 40 - mousePoint.Y)
                ? pushMeButton.Location.Y + mouseChange.Y : pushMeButton.Location.Y;
        }

        private int SetX(ref Point mouseChange)
        {
            return Math.Abs(pushMeButton.Location.X + pushMeButton.Width / 2 + Bounds.X - MousePosition.X)
                <= Math.Abs(pushMeButton.Location.X + pushMeButton.Width / 2 + Bounds.X - mousePoint.X)
                ? pushMeButton.Location.X + mouseChange.X : pushMeButton.Location.X;
        }

        private void RunButtonView_MouseEnter(object sender, EventArgs e)
        {
            mousePoint = MousePosition;
        }
    }
}
