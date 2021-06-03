using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 응소실팀플
{
    public partial class fem : Form
    {
        public fem()
        {
            InitializeComponent();
        }

        private void cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltbx.Items.Clear();

            string[] lst1 = { "뉴오리진 이너플로라 [(주)박솔 반월공장]", "메가 유렉스프로바이오틱스 포 우먼 [(주)빅솔 반월공장]", "유렉스프로바이오틱스 [(주)빅솔 반월공장]"};
            string[] lst2 = { "건강해질 여성유산균 [코스맥스엔비티(주)]", "리스펙타 분말 [코스맥스엔비티(주)]", "미스진 프로바이오틱스 [코스맥스엔비티(주)]",
                "버지니아 케어 [코스맥스엔비티(주)]",
            "우먼케어 건강한질엔 [코스맥스엔비티(주)]","페미밸런스 플러스 [코스맥스엔비티(주)]","핑크 프로바이오틱스 [코스맥스엔비티(주)]"};

            if (cmbx.SelectedIndex == 0) ltbx.Items.AddRange(lst1);
            if (cmbx.SelectedIndex == 1) ltbx.Items.AddRange(lst2);

        }
    }
}
