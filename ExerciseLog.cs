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
using 응소실팀플;

namespace 응소실팀플
{
    public partial class ExerciseLog : Form
    {

        String IDD = LoginForm.ID;
        string date;
        string todayPath;
        string[] txtboxContent = new string[16];
        int totalCal;
   
        public ExerciseLog()
        {
            InitializeComponent();
            textBox1.Text = IDD;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            date = e.Start.ToShortDateString();
            todayPath = string.Format(@"c:\member\{0}\exerciseLog\{1}.txt", IDD,date);
            if (File.Exists(todayPath))
            {
                try
                {
                    FileStream fs = new FileStream(todayPath, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs, System.Text.Encoding.UTF8);
                   
                    //text로 읽어온 한줄 한줄을 배열에 저장
                    for(int i = 0; i < 16; i++)
                    {
                        txtboxContent[i] = sr.ReadLine();
                    }
                 
                    
                    sr.Close();
                    fs.Close();
                    //읽어온 내용 textbox들에 띄워주기
                    txtbox_walk.Invoke(new Action(() => { txtbox_walk.Text = txtboxContent[0]; }));
                    txtbox_stair.Invoke(new Action(() => { txtbox_stair.Text = txtboxContent[1]; }));
                    txtbox_mountain.Invoke(new Action(() => { txtbox_mountain.Text = txtboxContent[2]; }));
                    txtbox_swim.Invoke(new Action(() => { txtbox_swim.Text = txtboxContent[3]; }));
                    txtbox_yoga.Invoke(new Action(() => { txtbox_yoga.Text = txtboxContent[4]; }));
                    txtbox_boxing.Invoke(new Action(() => { txtbox_boxing.Text = txtboxContent[5]; }));
                    txtbox_jumpRope.Invoke(new Action(() => { txtbox_jumpRope.Text = txtboxContent[6]; }));
                    txtbox_cycle.Invoke(new Action(() => { txtbox_cycle.Text = txtboxContent[7]; }));
                    txtbox_run.Invoke(new Action(() => { txtbox_run.Text = txtboxContent[8]; }));
                    txtbox_hola.Invoke(new Action(() => { txtbox_hola.Text = txtboxContent[9]; }));
                    txtbox_runningMachine.Invoke(new Action(() => { txtbox_runningMachine.Text = txtboxContent[10]; }));
                    txtbox_air.Invoke(new Action(() => { txtbox_air.Text = txtboxContent[11]; }));
                    txtbox_situp.Invoke(new Action(() => { txtbox_situp.Text = txtboxContent[12]; }));
                    txtbox_squat.Invoke(new Action(() => { txtbox_squat.Text = txtboxContent[13]; }));

                    label_totalCal.Invoke(new Action(() => { label_totalCal.Text = txtboxContent[14]; }));
                    txtbox_grade.Invoke(new Action(() => { txtbox_grade.Text = txtboxContent[15]; }));

                    for (int i = 0; i < 16; i++)
                    {
                        txtboxContent[i] = null;
                    }
                }
                catch
                {
                    //0으로 초기화
                    txtbox_walk.Invoke(new Action(() => { txtbox_walk.Text = "0"; }));
                    txtbox_stair.Invoke(new Action(() => { txtbox_stair.Text = "0"; }));
                    txtbox_mountain.Invoke(new Action(() => { txtbox_mountain.Text = "0"; }));
                    txtbox_swim.Invoke(new Action(() => { txtbox_swim.Text = "0"; }));
                    txtbox_yoga.Invoke(new Action(() => { txtbox_yoga.Text = "0"; }));
                    txtbox_boxing.Invoke(new Action(() => { txtbox_boxing.Text = "0"; }));
                    txtbox_jumpRope.Invoke(new Action(() => { txtbox_jumpRope.Text = "0"; }));
                    txtbox_cycle.Invoke(new Action(() => { txtbox_cycle.Text = "0"; }));
                    txtbox_run.Invoke(new Action(() => { txtbox_run.Text = "0"; }));
                    txtbox_hola.Invoke(new Action(() => { txtbox_hola.Text = "0"; }));
                    txtbox_runningMachine.Invoke(new Action(() => { txtbox_runningMachine.Text = "0"; }));
                    txtbox_air.Invoke(new Action(() => { txtbox_air.Text = "0"; }));
                    txtbox_situp.Invoke(new Action(() => { txtbox_situp.Text = "0"; }));
                    txtbox_squat.Invoke(new Action(() => { txtbox_squat.Text = "0"; }));

                    label_totalCal.Invoke(new Action(() => { label_totalCal.Text = "0"; }));
                    txtbox_grade.Invoke(new Action(() => { txtbox_grade.Text = "0"; }));
                }
            }
            else
            {
                //0으로 초기화
                txtbox_walk.Invoke(new Action(() => { txtbox_walk.Text = "0"; }));
                txtbox_stair.Invoke(new Action(() => { txtbox_stair.Text = "0"; }));
                txtbox_mountain.Invoke(new Action(() => { txtbox_mountain.Text = "0"; }));
                txtbox_swim.Invoke(new Action(() => { txtbox_swim.Text = "0"; }));
                txtbox_yoga.Invoke(new Action(() => { txtbox_yoga.Text = "0"; }));
                txtbox_boxing.Invoke(new Action(() => { txtbox_boxing.Text = "0"; }));
                txtbox_jumpRope.Invoke(new Action(() => { txtbox_jumpRope.Text = "0"; }));
                txtbox_cycle.Invoke(new Action(() => { txtbox_cycle.Text = "0"; }));
                txtbox_run.Invoke(new Action(() => { txtbox_run.Text = "0"; }));
                txtbox_hola.Invoke(new Action(() => { txtbox_hola.Text = "0"; }));
                txtbox_runningMachine.Invoke(new Action(() => { txtbox_runningMachine.Text = "0"; }));
                txtbox_air.Invoke(new Action(() => { txtbox_air.Text = "0"; }));
                txtbox_situp.Invoke(new Action(() => { txtbox_situp.Text = "0"; }));
                txtbox_squat.Invoke(new Action(() => { txtbox_squat.Text = "0"; }));

                label_totalCal.Invoke(new Action(() => { label_totalCal.Text = "0"; }));
                txtbox_grade.Invoke(new Action(() => { txtbox_grade.Text = "0"; }));
            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string folderPath = @"c:\member\"+IDD+@"\exerciseLog";
            DirectoryInfo dir = new DirectoryInfo(folderPath);

            if (dir.Exists == false)
                dir.Create();

            txtbox_walk.Text = "0";
            txtbox_stair.Text = "0";
            txtbox_mountain.Text = "0";
            txtbox_swim.Text = "0";
            txtbox_yoga.Text = "0";
            txtbox_boxing.Text = "0";
            txtbox_jumpRope.Text = "0";
            txtbox_cycle.Text = "0";
            txtbox_run.Text = "0";
            txtbox_hola.Text = "0";
            txtbox_runningMachine.Text = "0";
            txtbox_air.Text = "0";
            txtbox_situp.Text = "0";
            txtbox_squat.Text = "0";

            label_totalCal.Text = "0";
            txtbox_grade.Text = "0";

            date = DateTime.Now.ToShortDateString();
            todayPath = string.Format(@"c:\member\{0}\exerciseLog\{1}.txt", IDD, date);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            byte[] msg = null;
            try
            {
                FileStream fs = new FileStream(todayPath, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
                //해당 운동 기록 내용을 todayPath 에 한줄씩 저장
                sw.WriteLine(txtbox_walk.Text);
                sw.WriteLine(txtbox_stair.Text);
                sw.WriteLine(txtbox_mountain.Text);
                sw.WriteLine(txtbox_swim.Text);
                sw.WriteLine(txtbox_yoga.Text);
                sw.WriteLine(txtbox_boxing.Text);
                sw.WriteLine(txtbox_jumpRope.Text);
                sw.WriteLine(txtbox_squat.Text);
                sw.WriteLine(txtbox_cycle.Text);
                sw.WriteLine(txtbox_run.Text);
                sw.WriteLine(txtbox_hola.Text);
                sw.WriteLine(txtbox_runningMachine.Text);
                sw.WriteLine(txtbox_air.Text);
                sw.WriteLine(txtbox_situp.Text);
                sw.WriteLine(label_totalCal.Text);
                sw.WriteLine(txtbox_grade.Text);

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
                    //0으로 초기화
                    txtbox_walk.Invoke(new Action(() => { txtbox_walk.Text = "0"; }));
                    txtbox_stair.Invoke(new Action(() => { txtbox_stair.Text = "0"; }));
                    txtbox_mountain.Invoke(new Action(() => { txtbox_mountain.Text = "0"; }));
                    txtbox_swim.Invoke(new Action(() => { txtbox_swim.Text = "0"; }));
                    txtbox_yoga.Invoke(new Action(() => { txtbox_yoga.Text = "0"; }));
                    txtbox_boxing.Invoke(new Action(() => { txtbox_boxing.Text = "0"; }));
                    txtbox_jumpRope.Invoke(new Action(() => { txtbox_jumpRope.Text = "0"; }));
                    txtbox_cycle.Invoke(new Action(() => { txtbox_cycle.Text = "0"; }));
                    txtbox_run.Invoke(new Action(() => { txtbox_run.Text = "0"; }));
                    txtbox_hola.Invoke(new Action(() => { txtbox_hola.Text = "0"; }));
                    txtbox_runningMachine.Invoke(new Action(() => { txtbox_runningMachine.Text = "0"; }));
                    txtbox_air.Invoke(new Action(() => { txtbox_air.Text = "0"; }));
                    txtbox_situp.Invoke(new Action(() => { txtbox_situp.Text = "0"; }));
                    txtbox_squat.Invoke(new Action(() => { txtbox_squat.Text = "0"; }));

                    label_totalCal.Invoke(new Action(() => { label_totalCal.Text = "0"; }));
                    txtbox_grade.Invoke(new Action(() => { txtbox_grade.Text = "0"; }));


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

        private void btn_totalCal_Click(object sender, EventArgs e)
        {
            //사용자 몸무게
            int weight = 50;
            totalCal = 0;

            //각각의 운동시간
            int walk_time = Int32.Parse(txtbox_walk.Text);
            int stair_time = Int32.Parse(txtbox_stair.Text);
            int mountain_time = Int32.Parse(txtbox_mountain.Text);
            int swim_time = Int32.Parse(txtbox_swim.Text);
            int yoga_time = Int32.Parse(txtbox_yoga.Text);
            int boxing_time = Int32.Parse(txtbox_boxing.Text);
            int jumpRope_time = Int32.Parse(txtbox_jumpRope.Text);
            int squat_time = Int32.Parse(txtbox_squat.Text);
            int cycle_time = Int32.Parse(txtbox_cycle.Text);
            int run_time = Int32.Parse(txtbox_run.Text);
            int hola_time = Int32.Parse(txtbox_hola.Text);
            int runningMachine_time = Int32.Parse(txtbox_runningMachine.Text);
            int air_time = Int32.Parse(txtbox_air.Text);
            int situp_time = Int32.Parse(txtbox_situp.Text);

            if (weight <= 29)
            {
                totalCal = 2 * walk_time + 3 * stair_time + 4 * mountain_time + 4 * swim_time + 4 * yoga_time + 4 * boxing_time + 4 * jumpRope_time + 3 * squat_time + 3 * cycle_time + 3 * run_time + 2 * hola_time + 5 * runningMachine_time + 3 * air_time + 3 * situp_time;
            }
            else if (30 <= weight && weight <= 39)
            {
                totalCal = 2 * walk_time + 4 * stair_time + 5 * mountain_time + 5 * swim_time + 6 * yoga_time + 6 * boxing_time + 6 * jumpRope_time + 4 * squat_time + 4 * cycle_time + 4 * run_time + 2 * hola_time + 6 * runningMachine_time + 4 * air_time + 4 * situp_time;
            }
            else if (40 <= weight && weight <= 49)
            {
                totalCal = 3 * walk_time + 6 * stair_time + 6 * mountain_time + 6 * swim_time + 6 * yoga_time + 7 * boxing_time + 8 * jumpRope_time + 9 * squat_time + 7 * cycle_time + 7 * run_time + 4 * hola_time + 8 * runningMachine_time + 5 * air_time + 5 * situp_time;
            }
            else if (50 <= weight && weight <= 59)
            {
                totalCal = 4 * walk_time + 7 * stair_time + 8 * mountain_time + 9 * swim_time + 11 * yoga_time + 10 * boxing_time + 10 * jumpRope_time + 6 * squat_time + 6 * cycle_time + 7 * run_time + 4 * hola_time + 10 * runningMachine_time + 6 * air_time + 6 * situp_time;
            }
            else if (60 <= weight && weight <= 69)
            {
                totalCal = 4 * walk_time + 8 * stair_time + 9 * mountain_time + 9 * swim_time + 10 * yoga_time + 11 * boxing_time + 11 * jumpRope_time + 8 * squat_time + 8 * cycle_time + 8 * run_time + 5 * hola_time + 12 * runningMachine_time + 7 * air_time + 7 * situp_time;
            }
            else if (70 <= weight && weight <= 79)
            {
                totalCal = 5 * walk_time + 9 * stair_time + 11 * mountain_time + 11 * swim_time + 12 * yoga_time + 13 * boxing_time + 15 * jumpRope_time + 15 * squat_time + 10 * cycle_time + 10 * run_time + 10 * hola_time + 6 * runningMachine_time + 16 * air_time + 9 * situp_time;
            }
            else if (80 <= weight && weight <= 89)
            {
                totalCal = 5 * walk_time + 9 * stair_time + 11 * mountain_time + 11 * swim_time + 12 * yoga_time + 13 * boxing_time + 15 * jumpRope_time + 15 * squat_time + 10 * cycle_time + 10 * run_time + 10 * hola_time + 6 * runningMachine_time + 16 * air_time + 9 * situp_time;
            }
            else if (90 <= weight && weight <= 99)
            {
                totalCal = 5 * walk_time + 9 * stair_time + 11 * mountain_time + 11 * swim_time + 12 * yoga_time + 13 * boxing_time + 15 * jumpRope_time + 15 * squat_time + 10 * cycle_time + 10 * run_time + 10 * hola_time + 6 * runningMachine_time + 16 * air_time + 9 * situp_time;
            }
            else
            {
                totalCal = 5 * walk_time + 9 * stair_time + 11 * mountain_time + 11 * swim_time + 12 * yoga_time + 13 * boxing_time + 15 * jumpRope_time + 15 * squat_time + 10 * cycle_time + 10 * run_time + 10 * hola_time + 6 * runningMachine_time + 16 * air_time + 9 * situp_time;
            }

            label_totalCal.Text = totalCal.ToString();

        }
    }
}
