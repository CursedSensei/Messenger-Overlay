using System.Windows.Forms;

namespace Messenger_Overlay
{
    public partial class MsgDisplay : UserForm
    {
        public MsgDisplay()
        {
            InitializeComponent();

            // User Initialize
            this.MoveBox.MouseDown += new MouseEventHandler(MouseBox_Down);
            this.MoveBox.MouseUp += new MouseEventHandler(MouseBox_Up);
            this.MoveBox.MouseMove += new MouseEventHandler(MouseBox_Moving);
        }
    }
}
