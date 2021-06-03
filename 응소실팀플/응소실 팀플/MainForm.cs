using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 응소실_팀플
{
    public partial class MainForm : Form
    {
        public static String ID;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup s = new Signup();
            if (s.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            if (btnLogin.Text == "로그인")

            {

                if (f.ShowDialog() == DialogResult.OK)

                {

                    //textBox1.Text = username + "님 반갑습니다.";

                    btnLogin.Text = "Logout";

                }

                else

                {

                    textBox1.Text = "로그인에 실패했습니다.";

                }

                f.Dispose();

            }

            else

            {

                textBox1.Text = "안녕히가세요.";

                btnLogin.Text = "Login";

            }


        }
    }
}
