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
using 응소실_팀플;

namespace 응소실팀플
{
    public partial class spec : Form
    {
        String IDD = LoginForm.ID;
        public spec()
        {
            
            InitializeComponent();
            textBox4.Text = IDD;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == ""){
                MessageBox.Show("정보를 모두 입력해주세요.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else {
                string path = string.Format(@"c:\member\{0}\spec.txt", IDD);
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fs, System.Text.Encoding.Default);

                string path1=string.Format(@"c:\member\{0}\basic.txt", IDD);
                FileStream fss = new FileStream(path1, FileMode.Create, FileAccess.Write);
                StreamWriter st = new StreamWriter(fss, System.Text.Encoding.Default);

                streamWriter.WriteLine(textBox1.Text);//나이
                streamWriter.WriteLine(textBox2.Text);//키
                streamWriter.WriteLine(textBox3.Text);//몸무게
                streamWriter.WriteLine(comboBox1.Text);//성별

                double age = double.Parse(textBox1.Text);
                double height = double.Parse(textBox2.Text);
                double weight = double.Parse(textBox3.Text);

                if (comboBox1.Text == "남성")
                {
                    double meal = 66 + (13.8*weight) + (5 * height) - (6.8 * age);
                    string m = Convert.ToString(meal);   
                    MessageBox.Show("기초 대사량 : "+m);
                    st.WriteLine(m);

                }
                else if (comboBox1.Text == "여성")
                {
                    double meal = 655 + (9.6 * weight) + (1.8 * height) - (4.7 * age);
                    string m = Convert.ToString(meal);
                    MessageBox.Show("기초 대사량 : "+m);
                    st.WriteLine(m);
                }
                st.Flush();
                fss.Close();
                streamWriter.Flush();
                fs.Close();


                MessageBox.Show("저장 완료");
                Close(); }
        }
    }
}
