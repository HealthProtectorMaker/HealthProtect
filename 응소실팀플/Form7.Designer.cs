
namespace 응소실팀플
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ltbx = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ltbx
            // 
            this.ltbx.FormattingEnabled = true;
            this.ltbx.ItemHeight = 15;
            this.ltbx.Location = new System.Drawing.Point(20, 197);
            this.ltbx.Name = "ltbx";
            this.ltbx.Size = new System.Drawing.Size(423, 244);
            this.ltbx.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "성분을 누르시면 상세 상품을 확인할 수 있습니다.";
            // 
            // cmbx
            // 
            this.cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbx.FormattingEnabled = true;
            this.cmbx.Items.AddRange(new object[] {
            "L-글루타민산 유래 GABA 함유 분말",
            "나토균배양분말",
            "서목태(쥐눈이콩) 펩타이드 복합물",
            "연어 펩타이드",
            "올리브잎주정추출물 EFLA943",
            "정어리펩타이드",
            "카제인가수분해물",
            "코엔자임Q10"});
            this.cmbx.Location = new System.Drawing.Point(20, 124);
            this.cmbx.Name = "cmbx";
            this.cmbx.Size = new System.Drawing.Size(423, 31);
            this.cmbx.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "피부건강 추천 건강 기능식품 정보";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 497);
            this.Controls.Add(this.ltbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbx);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx;
        private System.Windows.Forms.Label label1;
    }
}