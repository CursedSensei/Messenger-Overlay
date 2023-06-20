using System.Windows.Forms;

namespace Messenger_Overlay
{
    class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MsgDisplay());
        }
    }
}
