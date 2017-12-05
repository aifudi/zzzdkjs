using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using XmlHelperNS;
using Delegate = DelegateNS.Delegate;

namespace zzzdkjs.UserForm
{
    public partial class LoginForm : Form
    {
        // 密码错误统计次数
        private int count = 0;
        // 用户名-密码 统计字典
        private Dictionary<string,string> userDictionary = new Dictionary<string, string>();

        // 定义用户登录回调函数
        public event Delegate.UserLoginHandle UserLongin;

        public LoginForm(string startuppath)
        {
            InitializeComponent();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitUserPwd(startuppath);
        }

        /// <summary>
        /// 用户名-密码 字典初始化
        /// </summary>
        private void InitUserPwd(string startuppath)
        {
            
            string usrpwdfile = startuppath + "\\user.xml";

            // 解析XML文件
            XmlHelper xmlHelper = new XmlHelper();
            XmlNodeList nodeList = xmlHelper.GetXmlNodeListByXpath(usrpwdfile, "/Users/user");
            foreach (XmlNode n in nodeList)
            {
                string username = n.SelectSingleNode("username").InnerText;
                string pwd = n.SelectSingleNode("password").InnerText;
                userDictionary.Add(username, pwd);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxName.Text;
            
            if (count < 3)
            {
                if (!userDictionary.ContainsKey(username))
                {
                    count++;
                    MessageBox.Show("用户名错误！");
                    return;
                }

                string pwd = userDictionary[username];
                if (string.Compare(pwd,textBoxPwd.Text)!=0)
                {
                    count++;
                    MessageBox.Show("请输入正确的用户名及密码！");
                    return;
                }
                else
                {
                    //登录页面
                    UserLongin(username);
                    this.Close();
                }
            }

            else
            {
                //错误页面
                MessageBox.Show("密码错误次数已超过三次，你无权使用本系统！");
                Application.Exit();
            }

        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
