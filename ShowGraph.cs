using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using 응소실_팀플;

namespace 운동_식단_그래프
{
    public partial class ShowGraph : Form
    {
        
        //@"c:\member\{0}\mealLog\{1}.txt", IDD, date
        string yearAndMonth;
        string exerciseLogPath= @"c:\member\" + IDD + @"\exerciseLog";
        string mealLogPath = @"c:\member\" + IDD +@"\mealLog";
        List<string> thisMonthMealGrade;
        List<int> thisMonthMealGradeDate;
        List<string> thisMonthExeGrade;
        List<int> thisMonthExeGradeDate;
        List<int> final_thisMonthMealGrade;
        List<int> final_thisMonthExeGrade;
        private static string IDD= LoginForm.ID;

        public ShowGraph()
        {
            InitializeComponent();
            textBox1.Text = IDD;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime localDate = DateTime.Now;
            for (int i = localDate.Year - 1000; i <= localDate.Year + 1000; i++)
                cmb_year.Items.Add(i);
            cmb_year.SelectedIndex = cmb_year.Items.Count/2;
            for (int i = 1; i <= 12; i++)
            {
                if (1 <= i && i <= 9)
                    cmb_month.Items.Add("0" + i.ToString());
                else
                    cmb_month.Items.Add(i.ToString());
            }
            

            chart_exercise.Titles.Add("월별 운동 기록 평가");
            chart_exercise.Series["Series1"].LegendText = "운동 평가";
            chart_exercise.Series["Series1"].ChartType = SeriesChartType.Line;

            
            chart_meal.Titles.Add("월별 식단 기록 평가");
            chart_meal.Series["Series1"].LegendText = "식단 평가";
            chart_meal.Series["Series1"].ChartType = SeriesChartType.Line;


            chart_total.Titles.Add("월별 합산 기록 평가");
            chart_total.Series["Series1"].LegendText = "합산 평가";
            chart_total.Series["Series1"].ChartType = SeriesChartType.Line;

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            chart_exercise.Series["Series1"].Points.Clear();
            chart_meal.Series["Series1"].Points.Clear();
            chart_total.Series["Series1"].Points.Clear();


            yearAndMonth = cmb_year.Text + "-" + cmb_month.Text;

            final_thisMonthExeGrade = new List<int>();
            final_thisMonthMealGrade = new List<int>();

            //meal log 그래프 출력
            thisMonthMealGrade = new List<string>();
            thisMonthMealGradeDate = new List<int>();
            
            DirectoryInfo mealLogDirInfo = new DirectoryInfo(mealLogPath);
            FileInfo[] mealLogfiArray = mealLogDirInfo.GetFiles();

            foreach (FileInfo fi in mealLogfiArray)
            {
                int lineNum = 0;
                if (String.Equals(fi.Name.Substring(0, 7), yearAndMonth))
                {
                    string tempPath = mealLogPath + "\\" + fi.Name;
                    StreamReader sr = new StreamReader(tempPath,System.Text.Encoding.Default);
                    string line;
                    int date = Int32.Parse(fi.Name.Substring(8, 2));
                    //textBox1.Text = date.ToString();
                    while((line = sr.ReadLine())!= null){
                        lineNum++;
                        if (lineNum == 8)
                        {
                            thisMonthMealGrade.Add(line);
                            thisMonthMealGradeDate.Add(date);
                        }
                    }
                }
            }


            //읽어온 식단 기록들 출력
            int starCount = 0;
            for(int i = 1; i < 32; i++)
            {
                starCount = 0;
                //thisMonthMealGradeDate 에 i가 속한다면 그래프에 해당 값으로 add
                for(int j = 0; j < thisMonthMealGradeDate.Count; j++)
                {
                    if (i == thisMonthMealGradeDate[j])
                    {
                        if (thisMonthMealGrade[j] == "★★★★★")
                            starCount = 5;
                        else if (thisMonthMealGrade[j] == "★★★★☆")
                            starCount = 4;
                        else if (thisMonthMealGrade[j] == "★★★☆☆")
                            starCount = 3;
                        else if (thisMonthMealGrade[j] == "★★☆☆☆")
                            starCount = 2;
                        else if (thisMonthMealGrade[j] == "★☆☆☆☆")
                            starCount = 1;
                        else
                            starCount = 0;
                    }
                }
                //없다면 0으로 add
                chart_meal.Series["Series1"].Points.Add(starCount);
                final_thisMonthMealGrade.Add(starCount);
            }



            //exeLog 그래프 출력
            thisMonthExeGrade = new List<string>();
            thisMonthExeGradeDate = new List<int>();

            DirectoryInfo exeLogDirInfo = new DirectoryInfo(exerciseLogPath);
            FileInfo[] exeLogfiArray = exeLogDirInfo.GetFiles();

            foreach (FileInfo fi in exeLogfiArray)
            {
                int lineNum = 0;
                if (String.Equals(fi.Name.Substring(0, 7), yearAndMonth))
                {
                    string tempPath = exerciseLogPath + "\\" + fi.Name;
                    StreamReader sr = new StreamReader(tempPath, System.Text.Encoding.Default);
                    string line;
                    int date = Int32.Parse(fi.Name.Substring(8, 2));
                    //textBox1.Text = date.ToString();
                    while ((line = sr.ReadLine()) != null)
                    {
                        lineNum++;
                        if (lineNum == 16)
                        {
                            thisMonthExeGrade.Add(line);
                            thisMonthExeGradeDate.Add(date);
                        }
                    }
                }
            }


            //읽어온 운동 기록들 출력
            int grade = 0;
            for (int i = 1; i < 32; i++)
            {
                grade = 0;
                //thisMonthExeGradeDate 에 i가 속한다면 그래프에 해당 값으로 add
                for (int j = 0; j < thisMonthExeGradeDate.Count; j++)
                {
                    if (i == thisMonthExeGradeDate[j])
                    {
                        if (thisMonthExeGrade[j] == "5")
                            grade = 5;
                        else if (thisMonthExeGrade[j] == "4")
                            grade = 4;
                        else if (thisMonthExeGrade[j] == "3")
                            grade = 3;
                        else if (thisMonthExeGrade[j] == "2")
                            grade = 2;
                        else if (thisMonthExeGrade[j] == "1")
                            grade = 1;
                        else
                            grade = 0;
                    }
                }
                //없다면 0으로 add
                chart_exercise.Series["Series1"].Points.Add(grade);
                final_thisMonthExeGrade.Add(grade);
            }


            //합산 기록 출력
            int total_grade = 0;
            for (int i = 0; i < 31; i++)
            {
                total_grade = (final_thisMonthExeGrade[i] + final_thisMonthMealGrade[i]) / 2;
                chart_total.Series["Series1"].Points.Add(total_grade);
            }

           
        }

      
    }
}
