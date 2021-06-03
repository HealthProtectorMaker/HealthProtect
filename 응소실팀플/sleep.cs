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
    public partial class sleep : Form
    {
        public sleep()
        {
            InitializeComponent();
        }

        private void cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltbx.Items.Clear();

            string[] lst1 = { "Antiv Fucan [(주)오투바이오]", "iSeanol [(주)다스코바이오]", "감태잠태 [주식회사 코리아헬스바이오]","감태추출물 [(주)에스앤디]"
            ,"경남혈당닥터 [동서바이오팜(주)]","고려은단 수면비법 [(주)네추럴에프앤피 2공장]","굿모닝 슬립웰 [(주)허브큐어]","굿잠 [콜마비앤에이치(주)푸디팜사업부문]"};
            string[] lst2 = { "365뉴트리션멀티비타민앤미네랄 [동서바이오팜(주)]", "D-포뮬라28 골드 [엠에스바이오텍(주)]", "EBM 비움 M [엘라이프주식회사(주)]",
                "NRC골드멀티비타민 [종근당건강(주)]",
            "SS쾌변데이 [농업회사법인에스에스바이오팜(주)]"};

            if (cmbx.SelectedIndex == 0) ltbx.Items.AddRange(lst1);
            if (cmbx.SelectedIndex == 1) ltbx.Items.AddRange(lst2);
        }
    }
}
