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
    public partial class healthcheck : Form
    {
        String IDD = LoginForm.ID;

        public healthcheck()
        {
            InitializeComponent();
            textBox1.Text = IDD;
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
            int num = 0;

            if (textBox3.Text == "" || textBox4.Text == "")
            MessageBox.Show("체온 및 수면시간을 입력해주세요.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            string path = string.Format(@"c:\member\{0}\{1}.txt", IDD,"healthcheck");
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fs, System.Text.Encoding.Default);
            


            //streamWriter.WriteLine(textBox3.Text);//체온
            //streamWriter.WriteLine(textBox4.Text);//수면시간
            //for (int i = 0; i <= (checkedListBox1.Items.Count - 1); i++)
            //{
            //    if (checkedListBox1.GetItemChecked(i))
            //    {
            //        num++;
            //        streamWriter.WriteLine(checkedListBox1.Items[i].ToString());//여러 증상 중 체크한것
            //    }
            //}


            float Box3 =float.Parse(textBox3.Text);
            float Box4 = float.Parse(textBox4.Text);
            if (Box3 > 37.6)//열있음
            {
                if (Box4 < 7)
                {
                    //잠 부족

                    if (num > 15)
                    {
                        MessageBox.Show("☆☆☆☆☆\n체온도 너무 높고 수면 부족안데다가 증상이 심하시기때문에 \n병원에 내원해보시는걸 추천드립니다");
                        streamWriter.WriteLine("☆☆☆☆☆");

                    }
                    else if (num <= 15 && num > 0)
                    {
                        MessageBox.Show("★★☆☆☆\n체온이 높습니다 \n 빨리 열을 내릴 수 있도록 해야하고 \n 이 증상이 계속된다면 병원에 내원해보시기 바랍니다");
                        streamWriter.WriteLine("★★☆☆☆");
                    }
                    else
                    {
                        MessageBox.Show("★★☆☆☆\n체온이 높습니다 \n 빨리 열을 내릴 수 있도록 해야합니다\n수면시간은 8~9시간이 좋습니다\n이 두가지만 지켜진다면\n바로 별5개를 받을 수 있을거에요!");
                        streamWriter.WriteLine("★★☆☆☆");
                    }

                }
                else
                {
                    //충분히 잠
                    if (num > 15)
                    {
                        MessageBox.Show("☆☆☆☆☆\n체온도 너무 높고 증상이 심하시기때문에 \n병원에 내원해보시는걸 추천드립니다");
                        streamWriter.WriteLine("☆☆☆☆☆");
                    }
                    else if (num <= 15 && num > 0)
                    {
                        MessageBox.Show("★★☆☆☆\n체온이 높습니다 \n 빨리 열을 내릴 수 있도록 해야하고 \n 이 증상이 계속된다면 병원에 내원해보시기 바랍니다");
                        streamWriter.WriteLine("★★☆☆☆");
                    }
                    else
                    {
                        MessageBox.Show("★★☆☆☆\n체온이 높습니다 \n 빨리 열을 내릴 수 있도록 해야합니다\n 그렇다면 바로 별5개를 받을 수 있을거에요!");
                        streamWriter.WriteLine("★★☆☆☆");
                    }
                }
            }
            else if(Box3 < 36.4)//저열
            {
                if (Box4 < 7)
                {
                    //잠 부족
                    if (num > 15)
                    {
                        MessageBox.Show("☆☆☆☆☆\n체온도 낮고 증상이 심하시기때문에 \n병원에 내원해보시는걸 추천드립니다");
                        streamWriter.WriteLine("☆☆☆☆☆");
                    }
                    else if (num <= 15 && num > 0)
                    {
                        MessageBox.Show("★★★☆☆\n체온이 너무 낮습니다. 몸을 따뜻하게 해주세요 \n수면시간은 8~9시간이 좋습니다\n 그리고 말씀하신 증상들의 완화가 필요하기 때문에\n 아래 건강기능 식품을 참고하세요!\n다음엔 별 더 많이 받아보아요!");
                        streamWriter.WriteLine("★★★☆☆");
                    }
                    else
                    {
                        MessageBox.Show("★★★★☆\n체온이 너무 낮습니다, 몸을 따뜻하게 해주세요 \n수면시간은 8~9시간이 좋습니다다\n조금 더 숙면을 취하고 몸을 따뜻하게 해서 \n 별 5개 받아보아요!");
                        streamWriter.WriteLine("★★★★☆");
                    }
                }
                else
                {
                    //충분히 잠
                    if (num > 15)
                    {
                        MessageBox.Show("☆☆☆☆☆\n체온도 낮고 증상이 심하시기때문에 \n병원에 내원해보시는걸 추천드립니다");
                        streamWriter.WriteLine("☆☆☆☆☆");
                    }
                    else if (num <= 15 && num > 0)
                    {
                        MessageBox.Show("★★☆☆☆\n체온이 너무 낮습니다. 몸을 따뜻하게 해주세요\n 그리고 말씀하신 증상들의 완화가 필요하기 때문에\n 아래 건강기능 식품을 참고하세요!\n다음엔 별 더 많이 받아보아요!");
                        streamWriter.WriteLine("★★☆☆☆");
                    }
                    else
                    {
                        MessageBox.Show("★★★☆☆\n체온이 너무 낮습니다. 몸을 따뜻하게 해주세요\n 해결하고 다음엔 별5개 밥아보아요!");
                        streamWriter.WriteLine("★★★☆☆");
                    }
                }
            }
            else if(Box3 >= 36.4&&Box3<=37.6)
            {
                if (Box4 < 7)
                {
                    //잠 부족
                    if (num > 15)
                    {
                        MessageBox.Show("★☆☆☆☆\n체온은 정상이지만\n수면도 부족하고 증상이 조금 심각하오니 \n병원에 내원해보시는걸 추천드립니다");
                        streamWriter.WriteLine("★☆☆☆☆");
                    }
                    else if (num <= 15 && num > 0)
                    {
                        MessageBox.Show("★★★★☆\n체온은 정상이나 수면이 부족하네요\n수면시간은 8~9시간이 좋습니다\n 그리고 말씀하신 증상들의 완화가 필요하기 때문에\n 아래 건강기능 식품을 참고하세요!\n다음엔 별 5개 받아보아요!");
                        streamWriter.WriteLine("★★★★☆");
                    }
                    else
                    {
                        MessageBox.Show("★★★★☆\n건강합니다\n다만 수면시간은 8~9시간이 좋습니다\n조금 더 숙면을 취해보는게 어떨까요?");
                        streamWriter.WriteLine("★★★★☆");
                    }
                }
                else
                {
                    //충분히 잠
                    if (num > 15)
                    {
                        MessageBox.Show("★☆☆☆☆\n체온도 정상범위이고 수면시간도 좋았지만\n증상이 조금 심각하오니 \n병원에 내원해보시는걸 추천드립니다");
                        streamWriter.WriteLine("★☆☆☆☆");
                    }
                    else if (num <= 15 && num > 0)
                    {
                        MessageBox.Show("★★★★☆\n건강하지만 조심합시다\n체온도 정상범위이고 수면시간도 좋습니다\n 다만 말씀하신 증상들의 완화가 필요하기 때문에\n 아래 건강기능 식품을 참고하세요!\n다음엔 별 5개 받아보아요!");
                        streamWriter.WriteLine("★★★★☆");
                    }
                    else
                    {
                        MessageBox.Show("★★★★★\n아주 건강합니다\n체온도 정상범위이고 수면시간도 좋습니다 \n앞으로도 이 건강 잘 유지하세요!");
                        streamWriter.WriteLine("★★★★★");
                    }
                }
            }

            streamWriter.Flush();
            fs.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try { 
            string path = string.Format(@"c:\member\{0}\{1}.txt", IDD, "healthcheck");
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fs, System.Text.Encoding.Default);
               
                MessageBox.Show(streamReader.ReadLine());
                
                
                fs.Close();
            }
            catch
            {
                MessageBox.Show("지난 결과가 없습니다");
            }
            


        }
    }
}
