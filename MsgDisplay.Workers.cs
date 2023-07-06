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
                });

                System.Threading.Thread.Sleep(30);
            }
        }

        private void delayedInit_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (!sKeyWorker.IsBusy) { }
            System.Threading.Thread.Sleep(50);
            this.ShowDisplay();
        }
    }
}
