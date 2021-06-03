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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltbx.Items.Clear();

            string[] lst1 = { "가바앤오메가-3 [코스맥스바이오(주)]", "가바앤정 [주식회사 노바렉스]", "가바프리미엄 [주식회사한미양행]",
                "메노포뮬라칼슘위드비타민D [에프엔바이오(주)]","수협혈천골드 [코스맥스바이오(주)]","스트레스 릴렉스 정 [코스맥스바이오(주)]","혈천포르테 [코스맥스바이오(주)]",
            "홍삼 주니어스틱 [(주)일화]"};
            string[] lst2 = { "3-콤보 [코스맥스바이오(주)]", "N-슈퍼엠에스엠 [주식회사 노바렉스]", "건강한 간 밀크씨슬 [(주)비오팜]","건강한혈행 [(주)한국씨엔에스팜]",
            "글로벌비겐 리케어칼슘 [포항바이오파크]","나토&징코 [코스맥스바이오(주)]","나토큐 [(주)세모]"};
            string[] lst3 = { "검은콩펩타이드 [(주)서흥 오창공장]", "더 함소아 프로폴리스 [코스맥스바이오(주)]", "자생 황금 기 [주식회사 노바렉스]",
            "쥐눈이콩펩타이드정제 [콜마비앤에이치(주)푸디팜사업부문]","트리플엑스 [(주)네이처택]","함소아 프로폴리스 [코스맥스바이오(주)]"};
            string[] lst4 = { "0건이 검색되었습니다." };
            string[] lst5 = { "간건강 솔루션 [(주)비오팜]", "건강한 이바넨 [(주)충청바이오텍]", "관절살리도 골드 [코스맥스바이오(주)]",
                "글루코사민1000 [한국바이오팜(주)]","다이어트 플러스 [(주)한풍네이처팜]","다인올브골드 [코스맥스바이오(주)]","닥터이지스A [풀무원건강생활(주)]",
            "도담키즈-드림 [(주)아리바이오에인치앤비]"};
            string[] lst6 = { "굿센 [동서바이오팜(주)]", "닥터 건강 플러스 [태웅식품(주)]", "닥터써큐원D [코스맥스바이오(주)]",
                "닥터징코원 [코스맥스바이오(주)]","듀썸헬씨 유코드 코어사딘 [동서바이오팜(주)]","리턴Q정어리펩타이드SP100N [코스맥스바이오(주)]","리턴큐 [코스맥스바이오(주)]",
            "리턴큐골드 [코스맥스바이오(주)]","맥스톤 [동서바이오팜(주)]","센바로 [동서바이오팜(주)]","서큐렉스오메가3 [주식회사 노바렉스]"};
            string[] lst7 = { "Key-Up(전량수출용) [(주)내츄럴엔도텍]","보움써큘라케어카제인가수분해물 [주식회사 노바렉스]"};
            string[] lst8 = { "+프리맥 [코스맥스바이오(주)]", "0225 리얼 히알루론산 워터밤 [네이처퓨어코리아(주)]", "Amado Ka-ne X(아마도카-네 지)수출용(태국) [에프엔바이오(주)]",
                "Atomy 5-Saw palmetto(수출용) [콜마비앤에이치(주)푸디팜사업부문]","BIOCARE(전량수출용) [주식회사한미양행]"};

            if (cmbx.SelectedIndex == 0) ltbx.Items.AddRange(lst1);
            if (cmbx.SelectedIndex == 1) ltbx.Items.AddRange(lst2);
            if (cmbx.SelectedIndex == 2) ltbx.Items.AddRange(lst3);
            if (cmbx.SelectedIndex == 3) ltbx.Items.AddRange(lst4);
            if (cmbx.SelectedIndex == 4) ltbx.Items.AddRange(lst5);
            if (cmbx.SelectedIndex == 5) ltbx.Items.AddRange(lst6);
            if (cmbx.SelectedIndex == 6) ltbx.Items.AddRange(lst7);
            if (cmbx.SelectedIndex == 7) ltbx.Items.AddRange(lst8);
        }
    }
}
