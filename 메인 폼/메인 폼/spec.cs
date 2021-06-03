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

namespace 메인_폼
{
    public partial class spec : Form
    {
        public spec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "")
                MessageBox.Show("정보를 모두 입력해주세요.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            string path = string.Format(@"c:\member\{0}.txt", textBox1.Text);
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fs, System.Text.Encoding.Default);



            streamWriter.WriteLine(textBox1.Text);
            streamWriter.WriteLine(textBox2.Text);
            streamWriter.WriteLine(textBox3.Text);
            streamWriter.WriteLine(comboBox1.Text);

            streamWriter.Flush();
            fs.Close();


            MessageBox.Show("저장 완료");
        }
    }
}
