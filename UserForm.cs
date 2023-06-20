using System.Windows.Forms;
using System.Drawing;

namespace Messenger_Overlay
{
    public class UserForm : Form
    {
        #region MouseBox Behavior

        private bool MouseBox_Move = false;
        private Point MouseBox_pos;

        protected void MouseBox_Down(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) { return; }
            this.MouseBox_Move = true;
            this.MouseBox_pos.X = Cursor.Position.X - this.Location.X;
            this.MouseBox_pos.Y = Cursor.Position.Y - this.Location.Y;
        }
        protected void MouseBox_Up(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) { return; }
            this.MouseBox_Move = false;
        }
        protected void MouseBox_Moving(object sender, MouseEventArgs e)
        {
            if (this.MouseBox_Move)
            {
                SetDesktopLocation(Cursor.Position.X - this.MouseBox_pos.X, Cursor.Position.Y - this.MouseBox_pos.Y);
            }
        }

        #endregion

    }
}
