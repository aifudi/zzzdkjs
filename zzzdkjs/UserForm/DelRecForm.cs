using DelegateNS;
using FiberRecordNS;
using System.Windows.Forms;

namespace zzzdkjs.UserForm
{
    public partial class DelRecForm : Form
    {

        public event Delegate.DelFiberRecHandle DelFiberRec;

        private FiberRecord fiberrec;

        public DelRecForm(FiberRecord rec)
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
            DelFiberRec(fiberrec);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
