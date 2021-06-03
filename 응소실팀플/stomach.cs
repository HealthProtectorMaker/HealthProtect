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
    public partial class stomach : Form
    {
        public stomach()
        {
            InitializeComponent();
        }

        private void cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltbx.Items.Clear();

            string[] lst1 = { "위건강 엔 매스틱 [콜마비앤에이치(주)푸디팜사업부문]", "위건강엔매스틱 [코스맥스바이오(주)]", "3=위매스틱케어 [코스맥스바이오(주)]",
                "위엔매스틱검 [코스맥스바이오(주)]"};
            string[] lst2 = { "레인보우 멀티비타민 [(주)레인보우바이오테크]", "레인보우 비타민C [(주)레인보우바이오테크]", "맨즈 멀티비타민 [콜마비앤에이치(주)푸디파사업부문]",
                "밀크씨슬 실리마린 [콜마비앤에이치(주)푸디팜사업부문]",
            "발효홍삼밀크씨슬포르테 [콜마비앤에이치(주)푸디팜사업부문]","비즈왁스알코올에스제이 [코스맥스바이오(주)]","우리 우먼즈 멀티비타민 [콜마비앤에이치(주)푸디팜사업부문]"};
            string[] lst3 = { "검은콩펩타이드 [(주)서흥 오창공장]", "더 함소아 프로폴리스 [코스맥스바이오(주)]", "자생 황금 기 [주식회사 노바렉스]",
            "쥐눈이콩펩타이드정제 [콜마비앤에이치(주)푸디팜사업부문]","트리플엑스 [(주)네이처택]","함소아 프로폴리스 [코스맥스바이오(주)]"};
            string[] lst4 = { "0건이 검색되었습니다." };
            string[] lst5 = { "간건강 솔루션 [(주)비오팜]", "건강한 이바넨 [(주)충청바이오텍]", "관절살리도 골드 [코스맥스바이오(주)]",
                "글루코사민1000 [한국바이오팜(주)]","다이어트 플러스 [(주)한풍네이처팜]","다인올브골드 [코스맥스바이오(주)]","닥터이지스A [풀무원건강생활(주)]",
            "도담키즈-드림 [(주)아리바이오에인치앤비]"};
          
            if (cmbx.SelectedIndex == 0) ltbx.Items.AddRange(lst1);
            if (cmbx.SelectedIndex == 1) ltbx.Items.AddRange(lst2);
            if (cmbx.SelectedIndex == 2) ltbx.Items.AddRange(lst3);
            if (cmbx.SelectedIndex == 3) ltbx.Items.AddRange(lst4);
            if (cmbx.SelectedIndex == 4) ltbx.Items.AddRange(lst5);

        }
    }
}
