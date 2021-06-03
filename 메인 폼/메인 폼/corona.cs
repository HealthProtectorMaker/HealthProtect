using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 메인_폼
{
    public partial class corona : Form
    {
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        int k = 0;
        int ck = 0;
        bool temperature = false;
        bool breathe = false;
        public corona()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ck++;
            a++;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            temperature = true;
            a++;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ck++;
            b++;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ck++;
            b++;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            breathe = true;
            b++;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            ck++;
            b++;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            ck++;
            b++;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            ck++;
            b++;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            ck++;
            c++;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            ck++;
            d++;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            ck++;
            k++;
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            a++;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            b++;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            c++;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            d++;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            k++;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (a < 1 || b < 1 || c < 1 || d < 1 || k < 1)
            {
                MessageBox.Show("모든 문항을 체크해주세요.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                if (breathe == true || temperature == true || ck >= 7)
                {
                    MessageBox.Show("38℃이상의 고열이 지속되거나 증상이 심해질 경우 콜센터(☏ 1339, 지역번호+120)또는 관할보건소에 문의하고 선별진료소 방문 후 진료받기 등 안내에 따라 주시기 바랍니다.", "안내문");
                    this.Close();
                }
                else if (ck >= 3)
                {
                    MessageBox.Show("해당 증상들이 없어질 때까지 가정에서 예방수칙을 준수하고 충분한 휴식을 취하시기 바랍니다.", "안내문");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("코로나19예방을 위한 자가진단 설문결과 의심 증상에 해당되는 항목이 없습니다.", "안내문");
                    this.Close();
                }
            }
        }

    }
}
