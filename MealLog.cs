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
using 응소실_팀플;

namespace 식단기록
{
    public partial class MealLog : Form
    {
        String IDD = LoginForm.ID;
        string date;
        string todayPath;
        string[] log = new string[8];
        bool[] checkedInfo = new bool[6];
      

        public MealLog()
        {
            InitializeComponent();
            textBox1.Text = IDD;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            todayPath = string.Format(@"c:\member\{0}\basic.txt", IDD);
            if (File.Exists(todayPath))
            {
         
                FileStream fs = new FileStream(todayPath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);
                textBox2.Text = sr.ReadLine();

                double desirable = double.Parse(textBox2.Text);      //기초 대사량
                sr.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show("\"내 정보입력을 작성하고 사용하세요\"");
            }

            

            //@"c:\member\{0}\mealLog\{1}.txt", IDD,date
            string folderPath = @"C:\member\"+IDD+@"\mealLog";
            DirectoryInfo dir = new DirectoryInfo(folderPath);

            if (dir.Exists == false)
                dir.Create();

            check_breakfast.Checked = false;
            check_firstSnack.Checked = false;
            check_lunch.Checked = false;
            check_secondSnack.Checked = false;
            check_dinner.Checked = false;
            check_thirdSnack.Checked = false;

            txtbox_totalCal.Text = "0";

            date = DateTime.Now.ToShortDateString();
            todayPath = string.Format(@"c:\member\{0}\mealLog\{1}.txt", IDD, date);
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            date = e.Start.ToShortDateString();
            todayPath= string.Format(@"c:\member\{0}\mealLog\{1}.txt", IDD, date);
            if (File.Exists(todayPath))
            {
                try
                {
                    FileStream fs = new FileStream(todayPath, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);

                    for (int i = 0; i < 8; i++)
                        log[i] = sr.ReadLine();

                    sr.Close();
                    fs.Close();

                   
                    for(int i = 0; i < 6; i++)
                    {
                        if (log[i].Equals("0"))
                            checkedInfo[i] = false;
                        else if (log[i].Equals("1"))
                            checkedInfo[i] = true;
                    }

           

                    check_breakfast.Invoke(new Action(() => { check_breakfast.Checked = checkedInfo[0]; }));
                    check_firstSnack.Invoke(new Action(() => { check_firstSnack.Checked = checkedInfo[1]; }));
                    check_lunch.Invoke(new Action(() => { check_lunch.Checked = checkedInfo[2]; }));
                    check_secondSnack.Invoke(new Action(() => { check_secondSnack.Checked = checkedInfo[3]; }));
                    check_dinner.Invoke(new Action(() => { check_dinner.Checked = checkedInfo[4]; }));
                    check_thirdSnack.Invoke(new Action(() => { check_thirdSnack.Checked = checkedInfo[5]; }));

                    txtbox_totalCal.Invoke(new Action(() => { txtbox_totalCal.Text = log[6]; }));
                    label_star.Invoke(new Action(() => { label_star.Text = log[7]; }));

                    for (int i = 0; i < 8; i++)
                        log[i] = null;
    
                }
                catch
                {
                    check_breakfast.Invoke(new Action(() => { check_breakfast.Checked = false; }));
                    check_firstSnack.Invoke(new Action(() => { check_firstSnack.Checked = false; }));
                    check_lunch.Invoke(new Action(() => { check_lunch.Checked = false; }));
                    check_secondSnack.Invoke(new Action(() => { check_secondSnack.Checked = false; }));
                    check_dinner.Invoke(new Action(() => { check_dinner.Checked = false; }));
                    check_thirdSnack.Invoke(new Action(() => { check_thirdSnack.Checked = false; }));

                    txtbox_totalCal.Invoke(new Action(() => { txtbox_totalCal.Text = "0"; }));
                    label_star.Invoke(new Action(() => { label_star.Text = "☆☆☆☆☆"; }));
                }
            }
            else
            {
                check_breakfast.Invoke(new Action(() => { check_breakfast.Checked = false; }));
                check_firstSnack.Invoke(new Action(() => { check_firstSnack.Checked = false; }));
                check_lunch.Invoke(new Action(() => { check_lunch.Checked = false; }));
                check_secondSnack.Invoke(new Action(() => { check_secondSnack.Checked = false; }));
                check_dinner.Invoke(new Action(() => { check_dinner.Checked = false; }));
                check_thirdSnack.Invoke(new Action(() => { check_thirdSnack.Checked = false; }));

                txtbox_totalCal.Invoke(new Action(() => { txtbox_totalCal.Text = "0"; }));
                label_star.Invoke(new Action(() => { label_star.Text = "☆☆☆☆☆"; }));
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            todayPath= string.Format(@"c:\member\{0}\mealLog\{1}.txt", IDD, date);
            try
            {
                FileStream fs = new FileStream(todayPath, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);

                //해당 checkbox 기록, 총 섭취량, 별점 기록을 todayPath에 txt로 한줄씩 저장
                //checkbox가 falsed이면 0, true이면 1 저장
                string[] temp = new string[] { "0", "0", "0", "0", "0", "0" };
                if (check_breakfast.Checked == true)
                    temp[0] = "1";
                if (check_firstSnack.Checked == true)
                    temp[1] = "1";
                if (check_lunch.Checked == true)
                    temp[2] = "1";
                if (check_secondSnack.Checked == true)
                    temp[3] = "1";
                if (check_dinner.Checked == true)
                    temp[4] = "1";
                if (check_thirdSnack.Checked == true)
                    temp[5] = "1";

                for (int i = 0; i < 6; i++)
                    sw.WriteLine(temp[i]);

                sw.WriteLine(txtbox_totalCal.Text);
                sw.WriteLine(label_star.Text);

                sw.Flush();
                fs.Close();
                MessageBox.Show("기록 저장 완료");


            }
            catch
            {
                MessageBox.Show("오류");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (File.Exists(todayPath))
            {
                try
                {
                    check_breakfast.Invoke(new Action(() => { check_breakfast.Checked = false; }));
                    check_firstSnack.Invoke(new Action(() => { check_firstSnack.Checked = false; }));
                    check_lunch.Invoke(new Action(() => { check_lunch.Checked = false; }));
                    check_secondSnack.Invoke(new Action(() => { check_secondSnack.Checked = false; }));
                    check_dinner.Invoke(new Action(() => { check_dinner.Checked = false; }));
                    check_thirdSnack.Invoke(new Action(() => { check_thirdSnack.Checked = false; }));

                    txtbox_totalCal.Invoke(new Action(() => { txtbox_totalCal.Text = "0"; }));
                    label_star.Invoke(new Action(() => { label_star.Text = "☆☆☆☆☆"; }));

                    FileInfo f = new FileInfo(todayPath);
                    f.Delete();
                    MessageBox.Show("삭제완료");
                }
                catch
                {
                    MessageBox.Show("오류");
                }

            }
            else
            {
                MessageBox.Show("삭제할 기록이 없습니다.");
            }
        }

        private void btn_grade_Click(object sender, EventArgs e)
        {
            todayPath = string.Format(@"c:\member\{0}\basic.txt", IDD);
            if (File.Exists(todayPath))
            {
                try
                {
                    
                    //기초대사량 대비 하루 식단 평가 후 별점 표시
                    double desirable = double.Parse(textBox2.Text);      //기초 대사량  
                    double totalCal = double.Parse(txtbox_totalCal.Text);
                    double term = desirable / 5;

                    if (desirable - term / 2 <= totalCal && totalCal <= desirable + term / 2)
                        label_star.Text = "★★★★★";
                    else if ((desirable - term / 2 - term <= totalCal && totalCal < desirable - term / 2) || (desirable + term / 2 < totalCal && totalCal <= desirable + term / 2 + term))
                        label_star.Text = "★★★★☆";
                    else if ((desirable - term / 2 - term * 2 <= totalCal && totalCal < desirable - term / 2 - term) || (desirable + term / 2 + term < totalCal && totalCal <= desirable + term / 2 + term * 2))
                        label_star.Text = "★★★★☆";
                    else if ((desirable - term / 2 - term * 3 <= totalCal && totalCal < desirable - term / 2 - term * 2) || (desirable + term / 2 + term * 2 < totalCal && totalCal <= desirable + term / 2 + term * 3))
                        label_star.Text = "★★★★☆";
                    else if ((desirable - term / 2 - term * 4 <= totalCal && totalCal < desirable - term / 2 - term * 3) || (desirable + term / 2 + term * 3 < totalCal && totalCal <= desirable + term / 2 + term * 4))
                        label_star.Text = "★★★★☆";
                    else
                        label_star.Text = "☆☆☆☆☆";

                }
                catch
                {
                    MessageBox.Show("저장해야 평가를 할 수 있습니다");
                }
              }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_totalCal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
