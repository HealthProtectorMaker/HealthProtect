namespace 운동_식단_그래프
{
    partial class ShowGraph
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_exercise = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_meal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_total = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_year = new System.Windows.Forms.ComboBox();
            this.cmb_month = new System.Windows.Forms.ComboBox();
            this.btn_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_exercise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_meal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_total)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_exercise
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_exercise.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_exercise.Legends.Add(legend1);
            this.chart_exercise.Location = new System.Drawing.Point(57, 98);
            this.chart_exercise.Name = "chart_exercise";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_exercise.Series.Add(series1);
            this.chart_exercise.Size = new System.Drawing.Size(866, 149);
            this.chart_exercise.TabIndex = 0;
            this.chart_exercise.Text = "chart1";
            // 
            // chart_meal
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_meal.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_meal.Legends.Add(legend2);
            this.chart_meal.Location = new System.Drawing.Point(57, 283);
            this.chart_meal.Name = "chart_meal";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_meal.Series.Add(series2);
            this.chart_meal.Size = new System.Drawing.Size(866, 149);
            this.chart_meal.TabIndex = 1;
            this.chart_meal.Text = "chart2";
            // 
            // chart_total
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_total.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_total.Legends.Add(legend3);
            this.chart_total.Location = new System.Drawing.Point(57, 468);
            this.chart_total.Name = "chart_total";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_total.Series.Add(series3);
            this.chart_total.Size = new System.Drawing.Size(866, 149);
            this.chart_total.TabIndex = 2;
            this.chart_total.Text = "chart3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "확인하고 싶은 월은?";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(845, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(946, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "님";
            // 
            // cmb_year
            // 
            this.cmb_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_year.FormattingEnabled = true;
            this.cmb_year.Location = new System.Drawing.Point(58, 59);
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.Size = new System.Drawing.Size(113, 23);
            this.cmb_year.TabIndex = 7;
            this.cmb_year.Text = "년(4자)";
            // 
            // cmb_month
            // 
            this.cmb_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb_month.FormattingEnabled = true;
            this.cmb_month.Location = new System.Drawing.Point(191, 59);
            this.cmb_month.Name = "cmb_month";
            this.cmb_month.Size = new System.Drawing.Size(60, 23);
            this.cmb_month.TabIndex = 8;
            this.cmb_month.Text = "월";
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ok.Location = new System.Drawing.Point(284, 57);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 9;
            this.btn_ok.Text = "확인";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // ShowGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(979, 644);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.cmb_month);
            this.Controls.Add(this.cmb_year);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart_total);
            this.Controls.Add(this.chart_meal);
            this.Controls.Add(this.chart_exercise);
            this.Name = "ShowGraph";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_exercise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_meal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_total)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_exercise;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_meal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_year;
        private System.Windows.Forms.ComboBox cmb_month;
        private System.Windows.Forms.Button btn_ok;
    }
}

