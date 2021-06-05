using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 식단기록;
using 응소실_팀플;
using 운동_식단_그래프;

namespace 응소실팀플
{
    public partial class Home : Form
    {
        String IDD = LoginForm.ID;
        public Home()
        {

            InitializeComponent();
            textBox1.Text = IDD;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            healthcheck hc = new healthcheck();
            hc.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            spec sp = new spec();
            sp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExerciseLog el = new ExerciseLog();
            el.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MealLog ml = new MealLog();
            ml.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowGraph sg = new ShowGraph();
            sg.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            corona cr = new corona();
            cr.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
