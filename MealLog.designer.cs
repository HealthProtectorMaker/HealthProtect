namespace 식단기록
{
    partial class MealLog
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.check_breakfast = new System.Windows.Forms.CheckBox();
            this.check_firstSnack = new System.Windows.Forms.CheckBox();
            this.check_lunch = new System.Windows.Forms.CheckBox();
            this.check_secondSnack = new System.Windows.Forms.CheckBox();
            this.check_dinner = new System.Windows.Forms.CheckBox();
            this.check_thirdSnack = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_totalCal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_star = new System.Windows.Forms.Label();
            this.btn_grade = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.monthCalendar1.Location = new System.Drawing.Point(18, 67);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_save.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_save.Location = new System.Drawing.Point(63, 291);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(144, 29);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "기록 저장";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_delete.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_delete.Location = new System.Drawing.Point(63, 341);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(144, 29);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "기록 삭제";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // check_breakfast
            // 
            this.check_breakfast.AutoSize = true;
            this.check_breakfast.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.check_breakfast.Location = new System.Drawing.Point(296, 81);
            this.check_breakfast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check_breakfast.Name = "check_breakfast";
            this.check_breakfast.Size = new System.Drawing.Size(58, 21);
            this.check_breakfast.TabIndex = 3;
            this.check_breakfast.Text = "아침";
            this.check_breakfast.UseVisualStyleBackColor = true;
            // 
            // check_firstSnack
            // 
            this.check_firstSnack.AutoSize = true;
            this.check_firstSnack.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.check_firstSnack.Location = new System.Drawing.Point(296, 120);
            this.check_firstSnack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check_firstSnack.Name = "check_firstSnack";
            this.check_firstSnack.Size = new System.Drawing.Size(58, 21);
            this.check_firstSnack.TabIndex = 4;
            this.check_firstSnack.Text = "간식";
            this.check_firstSnack.UseVisualStyleBackColor = true;
            // 
            // check_lunch
            // 
            this.check_lunch.AutoSize = true;
            this.check_lunch.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.check_lunch.Location = new System.Drawing.Point(296, 156);
            this.check_lunch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check_lunch.Name = "check_lunch";
            this.check_lunch.Size = new System.Drawing.Size(58, 21);
            this.check_lunch.TabIndex = 5;
            this.check_lunch.Text = "점심";
            this.check_lunch.UseVisualStyleBackColor = true;
            // 
            // check_secondSnack
            // 
            this.check_secondSnack.AutoSize = true;
            this.check_secondSnack.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.check_secondSnack.Location = new System.Drawing.Point(296, 193);
            this.check_secondSnack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check_secondSnack.Name = "check_secondSnack";
            this.check_secondSnack.Size = new System.Drawing.Size(58, 21);
            this.check_secondSnack.TabIndex = 6;
            this.check_secondSnack.Text = "간식";
            this.check_secondSnack.UseVisualStyleBackColor = true;
            // 
            // check_dinner
            // 
            this.check_dinner.AutoSize = true;
            this.check_dinner.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.check_dinner.Location = new System.Drawing.Point(296, 231);
            this.check_dinner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check_dinner.Name = "check_dinner";
            this.check_dinner.Size = new System.Drawing.Size(58, 21);
            this.check_dinner.TabIndex = 7;
            this.check_dinner.Text = "저녁";
            this.check_dinner.UseVisualStyleBackColor = true;
            // 
            // check_thirdSnack
            // 
            this.check_thirdSnack.AutoSize = true;
            this.check_thirdSnack.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.check_thirdSnack.Location = new System.Drawing.Point(296, 269);
            this.check_thirdSnack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.check_thirdSnack.Name = "check_thirdSnack";
            this.check_thirdSnack.Size = new System.Drawing.Size(58, 21);
            this.check_thirdSnack.TabIndex = 8;
            this.check_thirdSnack.Text = "간식";
            this.check_thirdSnack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(392, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "오늘 섭취 칼로리는?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbox_totalCal
            // 
            this.txtbox_totalCal.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_totalCal.Location = new System.Drawing.Point(413, 186);
            this.txtbox_totalCal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_totalCal.Name = "txtbox_totalCal";
            this.txtbox_totalCal.Size = new System.Drawing.Size(98, 25);
            this.txtbox_totalCal.TabIndex = 10;
            this.txtbox_totalCal.TextChanged += new System.EventHandler(this.txtbox_totalCal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(526, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "kCal";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_star
            // 
            this.label_star.AutoSize = true;
            this.label_star.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_star.Location = new System.Drawing.Point(484, 341);
            this.label_star.Name = "label_star";
            this.label_star.Size = new System.Drawing.Size(78, 17);
            this.label_star.TabIndex = 13;
            this.label_star.Text = "☆☆☆☆☆";
            // 
            // btn_grade
            // 
            this.btn_grade.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_grade.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_grade.Location = new System.Drawing.Point(409, 334);
            this.btn_grade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_grade.Name = "btn_grade";
            this.btn_grade.Size = new System.Drawing.Size(69, 29);
            this.btn_grade.TabIndex = 14;
            this.btn_grade.Text = "평가";
            this.btn_grade.UseVisualStyleBackColor = false;
            this.btn_grade.Click += new System.EventHandler(this.btn_grade_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(558, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "님";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox1.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(453, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 25);
            this.textBox1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(390, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(411, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "기초대사량";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox2.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(413, 274);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(98, 25);
            this.textBox2.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(526, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "kCal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(82, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 31);
            this.label7.TabIndex = 22;
            this.label7.Text = "식단기록";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::응소실_팀플.Properties.Resources.도라에몽5;
            this.pictureBox1.Location = new System.Drawing.Point(213, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // MealLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(589, 413);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_grade);
            this.Controls.Add(this.label_star);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_totalCal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check_thirdSnack);
            this.Controls.Add(this.check_dinner);
            this.Controls.Add(this.check_secondSnack);
            this.Controls.Add(this.check_lunch);
            this.Controls.Add(this.check_firstSnack);
            this.Controls.Add(this.check_breakfast);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.monthCalendar1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MealLog";
            this.Text = "식단기록";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.CheckBox check_breakfast;
        private System.Windows.Forms.CheckBox check_firstSnack;
        private System.Windows.Forms.CheckBox check_lunch;
        private System.Windows.Forms.CheckBox check_secondSnack;
        private System.Windows.Forms.CheckBox check_dinner;
        private System.Windows.Forms.CheckBox check_thirdSnack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_totalCal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_star;
        private System.Windows.Forms.Button btn_grade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}

