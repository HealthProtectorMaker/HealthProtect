using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 응소실팀플;

namespace 응소실_팀플
{
    public partial class LoginForm : Form
    {
        public static String ID;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ID = textUsername.Text;
                    string path = string.Format(@"c:\member\{0}.txt", textUsername.Text);
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    StreamReader streamReader = new StreamReader(fs, System.Text.Encoding.Default);
                    string pw = streamReader.ReadLine();
                    string _pw = textPassword.Text;
                    if (pw == _pw)
                    {

                        this.Visible = false;
                        Home s = new Home(); 
                        if (s.ShowDialog() == DialogResult.OK)
                        {

                        }


                    }
                    else
                    {
                        MessageBox.Show("틀렸습니다");
                    }
            }
            catch
            {
                MessageBox.Show("존재하지 않는 아이디입니다");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
