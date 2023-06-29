using System.Windows.Forms;
using System.Threading;

namespace Messenger_Overlay
{
    class Program
    {
        [System.STAThread]
        static void Main(string[] argv)
        {
            bool mutexStatus = true;
            Mutex mutex = new Mutex(true, "@Hirishima: Messenger Overlay", out mutexStatus);
            if (!mutexStatus)
            {
                mutex.Close();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (argv.Length != 0 && argv[0] == "--start-minimized")
            {
                Application.Run(new MsgDisplay(true));
            }
            else { 
                Application.Run(new MsgDisplay(false)); 
            }

            mutex.Close();
        }

    }
}
