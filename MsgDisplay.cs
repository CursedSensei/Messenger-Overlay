using System.Windows.Forms;

namespace Messenger_Overlay
{
    public partial class MsgDisplay : UserForm
    {
        public MsgDisplay(bool minimized)
        {
            InitializeComponent();

            // User Initialize

            this.MoveBox.MouseDown += new MouseEventHandler(MouseBox_Down);
            this.MoveBox.MouseUp += new MouseEventHandler(MouseBox_Up);
            this.MoveBox.MouseMove += new MouseEventHandler(MouseBox_Moving);

            if (minimized != false)
            {
                delayedInit.RunWorkerAsync();
            }

            sKeyWorker.RunWorkerAsync();
        }

        private void ShowDisplay()
        {
            if (this.Visible == false)
            { 
                this.Show();
            }
            else
            {
                this.Hide();
            }
        }
    }
}
