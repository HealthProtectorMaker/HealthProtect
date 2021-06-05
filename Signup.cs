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
using System.Diagnostics;

namespace 응소실_팀플
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void sigupBtn_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text=="" || textBox2.Text == "")
            {
                MessageBox.Show("내용을 입력해주세요");
            }
            else { 
            try
            {
                CreateDirectory();
                DirectoryInfo dir = new DirectoryInfo(@"c:\member\");
                dir.CreateSubdirectory(textBox1.Text);
                
                //파일에 저장
                string path= string.Format(@"c:\member\{0}.txt", textBox1.Text);
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fs, System.Text.Encoding.Default);

                //streamWriter.WriteLine(textBox1.Text);
                streamWriter.WriteLine(textBox2.Text);
                for(int i = 0; i <= (checkedListBox1.Items.Count - 1); i++)
                {
                    if (checkedListBox1.GetItemChecked(i)) { 
                
                        streamWriter.WriteLine(checkedListBox1.Items[i].ToString());
                    }
                }

                streamWriter.Flush();
                fs.Close();
                MessageBox.Show("회원가입이 완료되었습니다");
                textBox1.Text = null;
                Close();
       
            }
            catch
            {
                MessageBox.Show("오류");
            }
            }
        }

        private void CreateDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo(@"c:\");
            dir.CreateSubdirectory("member");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
