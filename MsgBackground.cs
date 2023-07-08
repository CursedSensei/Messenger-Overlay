using System.Windows.Forms;

namespace Messenger_Overlay
{
    public partial class MsgBackground : Form
    {
        public MsgBackground()
        {
            InitializeComponent();

            // User Initialize
            
            this.SetClientSizeCore(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void MsgBackground_Click(object sender, System.EventArgs e)
        {
            Program.MainForm.Invoke((MethodInvoker)delegate () { Program.MainForm.Hide(); });
            this.Hide();
            MsgNotifTray.Visible = true;
        }

        private void MsgNotifTray_DoubleClick(object sender, System.EventArgs e)
        {
            MsgNotifTray.Visible = false;
            this.Invoke((MethodInvoker)delegate () { Show(); });
            Program.MainForm.Invoke((MethodInvoker)delegate () { Program.MainForm.Show(); });
        }

        private void IconMenuOpen_Click(object sender, System.EventArgs e)
        {
            MsgNotifTray.Visible = false;
            this.Invoke((MethodInvoker)delegate () { Show(); });
            Program.MainForm.Invoke((MethodInvoker)delegate () { Program.MainForm.Show(); });
        }

        private void IconMenuClose_Click(object sender, System.EventArgs e)
        {
            Program.MainForm.Close();
        }
    }
}
