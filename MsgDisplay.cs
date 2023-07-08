using System.Windows.Forms;

namespace Messenger_Overlay
{
    public partial class MsgDisplay : UserForm
    {
        public MsgDisplay(bool minimized)
        {
            InitializeComponent();

            // User Initialize

            backgroundWorker.RunWorkerAsync();

            this.MoveBox.MouseDown += new MouseEventHandler(MouseBox_Down);
            this.MoveBox.MouseUp += new MouseEventHandler(MouseBox_Up);
            this.MoveBox.MouseMove += new MouseEventHandler(MouseBox_Moving);

            delayedInit.RunWorkerAsync(minimized);

            sKeyWorker.RunWorkerAsync();
        }

        private void ShowDisplay()
        {
            if (this.Visible == false)
            {
                BackForm.MsgNotifTray.Visible = false;
                BackForm.Invoke((MethodInvoker)delegate () { BackForm.Show(); });
                this.Show();
            }
            else
            {
                this.Hide();
                BackForm.Invoke((MethodInvoker)delegate () { BackForm.Hide(); });
                BackForm.MsgNotifTray.Visible = true;
            }
        }

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            BackForm.MsgNotifTray.Visible = false;
        }
    }
}
