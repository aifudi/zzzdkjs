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
            FiberRecord rec = GetEditedRec();
            AddFiberRec(fiberrec);
        }

        /// <summary>
        /// 得到新增的光纤记录值
        /// </summary>
        /// <returns></returns>
        private FiberRecord GetEditedRec()
        {
            FiberRecord rec = new FiberRecord();
            rec.FiberPigtail = textBoxFiberTail.Text;
            rec.TeleOperator = comboBoxOperator.Items[comboBoxOperator.SelectedIndex].ToString();

            return rec;

        }
    }
}
