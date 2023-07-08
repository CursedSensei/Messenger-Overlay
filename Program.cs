using System.Windows.Forms;
using System.Threading;

namespace Messenger_Overlay
{
    class Program
    {
        internal static MsgDisplay MainForm;

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
                MainForm = new MsgDisplay(true);
                Application.Run(MainForm);
            }
            else
            {
                MainForm = new MsgDisplay(false);
                Application.Run(MainForm); 
            }

            mutex.Close();
        }

    }
}
