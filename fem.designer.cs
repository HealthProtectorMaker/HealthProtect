
namespace 응소실팀플
{
    partial class fem
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
            this.ltbx.BackColor = System.Drawing.Color.LemonChiffon;
            this.ltbx.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ltbx.FormattingEnabled = true;
            this.ltbx.ItemHeight = 17;
            this.ltbx.Location = new System.Drawing.Point(20, 197);
            this.ltbx.Name = "ltbx";
            this.ltbx.Size = new System.Drawing.Size(423, 242);
            this.ltbx.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "성분을 누르시면 상세 상품을 확인할 수 있습니다.";
            // 
            // cmbx
            // 
            this.cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx.Font = new System.Drawing.Font("나눔스퀘어", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbx.FormattingEnabled = true;
            this.cmbx.Items.AddRange(new object[] {
            "UREX 프로바이오틱스",
            "리스펙타(Respectar) 프로바이오틱스"});
            this.cmbx.Location = new System.Drawing.Point(20, 124);
            this.cmbx.Name = "cmbx";
            this.cmbx.Size = new System.Drawing.Size(423, 25);
            this.cmbx.TabIndex = 6;
            this.cmbx.SelectedIndexChanged += new System.EventHandler(this.cmbx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어_ac Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "질내유익균 증식 추천 건강 기능식품 정보";
            // 
            // fem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(459, 497);
            this.Controls.Add(this.ltbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbx);
            this.Controls.Add(this.label1);
            this.Name = "fem";
            this.Text = "질내유익균 증식";
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