using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Ice9_Keygen
{
    public partial class ErrorForm : Form
    {
        public ErrorForm(int nameLength)
        {
            InitializeComponent();

            SystemSounds.Beep.Play();

            if (nameLength < 4)
            {
                lblErrorMsg.Text = "Name must be at least 4 characters.";
            }
            else if (nameLength > 10)
            {
                lblErrorMsg.Text = "Name must be less than 11 characters.";
            }
        }

        private bool isMoving = false;
        private Point offset;

        private void MoveWindow(MouseEventArgs e)
        {
            if (isMoving)
            {
                Point newLocation = this.PointToScreen(new Point(e.X, e.Y));
                newLocation.Offset(-offset.X, -offset.Y);
                this.Location = newLocation;
            }
        }

        private void pnlBorder_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            offset = new Point(e.X, e.Y);
        }

        private void pnlBorder_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                isMoving = false;
            }
        }

        private void pnlBorder_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }

        private void lblError_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            offset = new Point(e.X, e.Y);
        }

        private void lblError_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                isMoving = false;
            }
        }

        private void lblError_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }

        private void lblErrorMsg_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            offset = new Point(e.X, e.Y);
        }

        private void lblErrorMsg_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(e);
        }

        private void lblErrorMsg_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMoving)
            {
                isMoving = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
