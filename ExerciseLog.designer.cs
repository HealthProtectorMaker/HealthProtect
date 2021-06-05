namespace 응소실팀플
{
    partial class ExerciseLog
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
            this.lbl_star = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_walk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_stair = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_mountain = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbox_swim = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbox_yoga = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbox_boxing = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtbox_jumpRope = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtbox_cycle = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtbox_run = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtbox_hola = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtbox_runningMachine = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtbox_air = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtbox_situp = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtbox_squat = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label_totalCal = new System.Windows.Forms.Label();
            this.btn_totalCal = new System.Windows.Forms.Button();
            this.txtbox_grade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.LemonChiffon;
            this.monthCalendar1.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.monthCalendar1.Location = new System.Drawing.Point(27, 92);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_save.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_save.Location = new System.Drawing.Point(86, 379);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(128, 29);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "기록 저장";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_delete.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_delete.Location = new System.Drawing.Point(86, 436);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(128, 29);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "기록 삭제";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_star
            // 
            this.lbl_star.AutoSize = true;
            this.lbl_star.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_star.Location = new System.Drawing.Point(689, 461);
            this.lbl_star.Name = "lbl_star";
            this.lbl_star.Size = new System.Drawing.Size(23, 17);
            this.lbl_star.TabIndex = 9;
            this.lbl_star.Text = "/5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(337, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "걷기 :";
            // 
            // txtbox_walk
            // 
            this.txtbox_walk.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_walk.Location = new System.Drawing.Point(414, 132);
            this.txtbox_walk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_walk.Name = "txtbox_walk";
            this.txtbox_walk.Size = new System.Drawing.Size(52, 25);
            this.txtbox_walk.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(474, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "분";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(474, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "분";
            // 
            // txtbox_stair
            // 
            this.txtbox_stair.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_stair.Location = new System.Drawing.Point(414, 166);
            this.txtbox_stair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_stair.Name = "txtbox_stair";
            this.txtbox_stair.Size = new System.Drawing.Size(52, 25);
            this.txtbox_stair.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(337, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "계단 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(474, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "분";
            // 
            // txtbox_mountain
            // 
            this.txtbox_mountain.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_mountain.Location = new System.Drawing.Point(414, 199);
            this.txtbox_mountain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_mountain.Name = "txtbox_mountain";
            this.txtbox_mountain.Size = new System.Drawing.Size(52, 25);
            this.txtbox_mountain.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(337, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "등산 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(474, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "분";
            // 
            // txtbox_swim
            // 
            this.txtbox_swim.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_swim.Location = new System.Drawing.Point(414, 233);
            this.txtbox_swim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_swim.Name = "txtbox_swim";
            this.txtbox_swim.Size = new System.Drawing.Size(52, 25);
            this.txtbox_swim.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(337, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "수영 :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(474, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "분";
            // 
            // txtbox_yoga
            // 
            this.txtbox_yoga.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_yoga.Location = new System.Drawing.Point(414, 267);
            this.txtbox_yoga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_yoga.Name = "txtbox_yoga";
            this.txtbox_yoga.Size = new System.Drawing.Size(52, 25);
            this.txtbox_yoga.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(337, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "요가 :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(474, 309);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 17);
            this.label13.TabIndex = 40;
            this.label13.Text = "분";
            // 
            // txtbox_boxing
            // 
            this.txtbox_boxing.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_boxing.Location = new System.Drawing.Point(414, 303);
            this.txtbox_boxing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_boxing.Name = "txtbox_boxing";
            this.txtbox_boxing.Size = new System.Drawing.Size(52, 25);
            this.txtbox_boxing.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(337, 307);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "복싱 :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(474, 343);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 17);
            this.label15.TabIndex = 43;
            this.label15.Text = "분";
            // 
            // txtbox_jumpRope
            // 
            this.txtbox_jumpRope.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_jumpRope.Location = new System.Drawing.Point(414, 337);
            this.txtbox_jumpRope.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_jumpRope.Name = "txtbox_jumpRope";
            this.txtbox_jumpRope.Size = new System.Drawing.Size(52, 25);
            this.txtbox_jumpRope.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(337, 343);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 17);
            this.label16.TabIndex = 41;
            this.label16.Text = "줄넘기 :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(717, 169);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 17);
            this.label17.TabIndex = 46;
            this.label17.Text = "분";
            // 
            // txtbox_cycle
            // 
            this.txtbox_cycle.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_cycle.Location = new System.Drawing.Point(658, 165);
            this.txtbox_cycle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_cycle.Name = "txtbox_cycle";
            this.txtbox_cycle.Size = new System.Drawing.Size(52, 25);
            this.txtbox_cycle.TabIndex = 45;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(540, 168);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 17);
            this.label18.TabIndex = 44;
            this.label18.Text = "자전거 :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(717, 205);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(22, 17);
            this.label19.TabIndex = 49;
            this.label19.Text = "분";
            // 
            // txtbox_run
            // 
            this.txtbox_run.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_run.Location = new System.Drawing.Point(658, 198);
            this.txtbox_run.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_run.Name = "txtbox_run";
            this.txtbox_run.Size = new System.Drawing.Size(52, 25);
            this.txtbox_run.TabIndex = 48;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(540, 205);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 17);
            this.label20.TabIndex = 47;
            this.label20.Text = "달리기 :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(717, 238);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 17);
            this.label21.TabIndex = 52;
            this.label21.Text = "분";
            // 
            // txtbox_hola
            // 
            this.txtbox_hola.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_hola.Location = new System.Drawing.Point(658, 232);
            this.txtbox_hola.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_hola.Name = "txtbox_hola";
            this.txtbox_hola.Size = new System.Drawing.Size(52, 25);
            this.txtbox_hola.TabIndex = 51;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(540, 239);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 17);
            this.label22.TabIndex = 50;
            this.label22.Text = "훌라후프 :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(717, 272);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(22, 17);
            this.label23.TabIndex = 55;
            this.label23.Text = "분";
            // 
            // txtbox_runningMachine
            // 
            this.txtbox_runningMachine.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_runningMachine.Location = new System.Drawing.Point(658, 266);
            this.txtbox_runningMachine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_runningMachine.Name = "txtbox_runningMachine";
            this.txtbox_runningMachine.Size = new System.Drawing.Size(52, 25);
            this.txtbox_runningMachine.TabIndex = 54;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.Location = new System.Drawing.Point(540, 275);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 17);
            this.label24.TabIndex = 53;
            this.label24.Text = "런닝머신 :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.Location = new System.Drawing.Point(717, 306);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(22, 17);
            this.label25.TabIndex = 58;
            this.label25.Text = "분";
            // 
            // txtbox_air
            // 
            this.txtbox_air.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_air.Location = new System.Drawing.Point(658, 299);
            this.txtbox_air.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_air.Name = "txtbox_air";
            this.txtbox_air.Size = new System.Drawing.Size(52, 25);
            this.txtbox_air.TabIndex = 57;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label26.Location = new System.Drawing.Point(540, 308);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 17);
            this.label26.TabIndex = 56;
            this.label26.Text = "에어로빅 :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label27.Location = new System.Drawing.Point(717, 343);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(22, 17);
            this.label27.TabIndex = 61;
            this.label27.Text = "분";
            // 
            // txtbox_situp
            // 
            this.txtbox_situp.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_situp.Location = new System.Drawing.Point(658, 336);
            this.txtbox_situp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_situp.Name = "txtbox_situp";
            this.txtbox_situp.Size = new System.Drawing.Size(52, 25);
            this.txtbox_situp.TabIndex = 60;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label28.Location = new System.Drawing.Point(540, 342);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(101, 17);
            this.label28.TabIndex = 59;
            this.label28.Text = "윗몸일으키기 :";
            // 
            // label29
            // 
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label29.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label29.Location = new System.Drawing.Point(334, 379);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(411, 2);
            this.label29.TabIndex = 62;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label30.Location = new System.Drawing.Point(678, 407);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(34, 17);
            this.label30.TabIndex = 63;
            this.label30.Text = "kcal";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label31.Location = new System.Drawing.Point(540, 136);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(55, 17);
            this.label31.TabIndex = 64;
            this.label31.Text = "스쿼트:";
            // 
            // txtbox_squat
            // 
            this.txtbox_squat.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_squat.Location = new System.Drawing.Point(658, 131);
            this.txtbox_squat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_squat.Name = "txtbox_squat";
            this.txtbox_squat.Size = new System.Drawing.Size(52, 25);
            this.txtbox_squat.TabIndex = 65;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label33.Location = new System.Drawing.Point(717, 136);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(22, 17);
            this.label33.TabIndex = 66;
            this.label33.Text = "분";
            // 
            // label_totalCal
            // 
            this.label_totalCal.AutoSize = true;
            this.label_totalCal.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_totalCal.Location = new System.Drawing.Point(597, 407);
            this.label_totalCal.Name = "label_totalCal";
            this.label_totalCal.Size = new System.Drawing.Size(17, 17);
            this.label_totalCal.TabIndex = 67;
            this.label_totalCal.Text = "0";
            // 
            // btn_totalCal
            // 
            this.btn_totalCal.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_totalCal.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_totalCal.Location = new System.Drawing.Point(362, 401);
            this.btn_totalCal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_totalCal.Name = "btn_totalCal";
            this.btn_totalCal.Size = new System.Drawing.Size(161, 29);
            this.btn_totalCal.TabIndex = 68;
            this.btn_totalCal.Text = "총 칼로리 소비량";
            this.btn_totalCal.UseVisualStyleBackColor = false;
            this.btn_totalCal.Click += new System.EventHandler(this.btn_totalCal_Click);
            // 
            // txtbox_grade
            // 
            this.txtbox_grade.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_grade.Location = new System.Drawing.Point(661, 455);
            this.txtbox_grade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbox_grade.Name = "txtbox_grade";
            this.txtbox_grade.Size = new System.Drawing.Size(25, 25);
            this.txtbox_grade.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(638, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 71;
            this.label1.Text = "★";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(555, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "자가 평가 :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox1.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(625, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 25);
            this.textBox1.TabIndex = 73;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label32.Location = new System.Drawing.Point(743, 19);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(22, 17);
            this.label32.TabIndex = 74;
            this.label32.Text = "님";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label34.Location = new System.Drawing.Point(90, 31);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(110, 31);
            this.label34.TabIndex = 75;
            this.label34.Text = "운동기록";
            // 
            // ExerciseLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(781, 511);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_grade);
            this.Controls.Add(this.btn_totalCal);
            this.Controls.Add(this.label_totalCal);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.txtbox_squat);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtbox_situp);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtbox_air);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtbox_runningMachine);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtbox_hola);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtbox_run);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtbox_cycle);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtbox_jumpRope);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtbox_boxing);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbox_yoga);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbox_swim);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbox_mountain);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbox_stair);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_walk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_star);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.monthCalendar1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ExerciseLog";
            this.Text = "운동기록";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_star;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_walk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox_stair;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbox_mountain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbox_swim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbox_yoga;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbox_boxing;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtbox_jumpRope;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtbox_cycle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtbox_run;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtbox_hola;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtbox_runningMachine;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtbox_air;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtbox_situp;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtbox_squat;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label_totalCal;
        private System.Windows.Forms.Button btn_totalCal;
        private System.Windows.Forms.TextBox txtbox_grade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label34;
    }
}

