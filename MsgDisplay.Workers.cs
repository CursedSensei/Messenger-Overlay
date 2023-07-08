using System.Windows.Forms;
using System.Windows.Input;

namespace Messenger_Overlay
{
    partial class MsgDisplay
    {
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

                    if ((Keyboard.IsKeyDown(Key.LeftAlt) || 
                        Keyboard.IsKeyDown(Key.RightAlt)) && 
                        this.Visible == true) 
                    {
                        ShowDisplay();
                    }
                });

                System.Threading.Thread.Sleep(30);
            }
        }

        private void delayedInit_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (!sKeyWorker.IsBusy) { }
            System.Threading.Thread.Sleep(50);
            if ((bool)e.Argument)
            {
                this.Invoke((MethodInvoker)delegate () { this.ShowDisplay(); });
            }
            else
            {
                this.Invoke((MethodInvoker)delegate () {
                    this.ShowDisplay();
                    this.ShowDisplay();
                });
            }

        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(BackForm);
        }
    }
}
