using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 응소실팀플
{
    public partial class healthcheck : Form
    {
        public healthcheck()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            skin f2 = new skin();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            energy f3 = new energy();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            biotics f4 = new biotics();
            f4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            stomach f5 = new stomach();
            f5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fem f6 = new fem();
            f6.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sleep f7 = new sleep();
            f7.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("체온 및 수면시간을 입력해주세요.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                
            string path = string.Format(@"c:\member\{0}.txt", textBox3.Text);
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fs, System.Text.Encoding.Default);



            streamWriter.WriteLine(textBox3.Text);
            streamWriter.WriteLine(textBox4.Text);
            for (int i = 0; i <= (checkedListBox1.Items.Count - 1); i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {

                    streamWriter.WriteLine(checkedListBox1.Items[i].ToString());
                }
            }
            streamWriter.Flush();
            fs.Close();
            
            MessageBox.Show("저장 완료");
        }
    }
}
