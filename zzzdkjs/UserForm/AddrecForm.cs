using DelegateNS;
using FiberRecordNS;
using System.Windows.Forms;

namespace zzzdkjs.UserForm
{
    public partial class AddrecForm : Form
    {

        public event Delegate.AddFiberRecHandle AddFiberRec;
        private FiberRecord fiberrec;

        public AddrecForm(FiberRecord rec)
        {
            InitializeComponent();
            fiberrec = rec;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, System.EventArgs e)
        {
            AddFiberRec(fiberrec);
        }
    }
}
