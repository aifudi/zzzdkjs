using System;
using System.Windows.Forms;
using FiberRecordNS;
using Delegate = DelegateNS.Delegate;

namespace zzzdkjs.UserForm
{
    public partial class OPChooseForm : Form
    {
        public OPChooseForm(FiberRecord rec)
        {
            InitializeComponent();
            fiberrec = rec;
        }

        private FiberRecord fiberrec;
        
        // 定义回调函数
        public event Delegate.EditFiberRecHandle EditFiberRec;
        public event Delegate.AddFiberRecHandle AddFiberRec;
        public event Delegate.DelFiberRecHandle DelFiberRec;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                AddrecForm addrecForm = new AddrecForm(fiberrec);
                addrecForm.AddFiberRec += AddFiberRec;
                addrecForm.ShowDialog();
            }

            if (radioButton2.Checked)
            {
                EditRecForm editRecForm = new EditRecForm(fiberrec);
                editRecForm.EditFiberRec += EditFiberRec;
                editRecForm.ShowDialog();
            }

            if (radioButton3.Checked)
            {
                DelRecForm delRecForm = new DelRecForm(fiberrec);
                delRecForm.DelFiberRec += DelFiberRec;
                delRecForm.ShowDialog();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
