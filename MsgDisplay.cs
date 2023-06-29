using System.Windows.Forms;
using System.Windows.Input;
using MouseEventHandler = System.Windows.Forms.MouseEventHandler;

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
        private void sKeyWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            bool kBuffer = false;
            while (true)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    if (Keyboard.IsKeyDown(Key.LeftShift) &&
                        Keyboard.IsKeyDown(Key.F3))
                    {
                        if (kBuffer != true)
                        {
                            kBuffer = true;
                            ShowDisplay();
                        }
                    }
                    else { kBuffer = false; }
                });
                
                System.Threading.Thread.Sleep(30);
            }
        }

        private void delayedInit_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while(!sKeyWorker.IsBusy) { }
            System.Threading.Thread.Sleep(50);
            this.ShowDisplay();
        }
    }
}
