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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltbx.Items.Clear();

            string[] lst1 = { "10종 복합코팅윤산균 에이(A) [일동바이오사이언스(주)]", "7종 복합코팅유산균 [일동바이오사이언스(주)]", "9종 복합코팅유산균 [일동바이오사이언스(주)]",
                "ALBUTAREX [코스맥스바이오(주)]","LactoCran+ [주식회사 노바렉스]","MR-10 올인원맨 [(주)네이처텍]","N-아세틸글루코사민 [(주)창성]",
            "가바앤정 [주식회사 노바렉스]","가이스머슬 게이너 [(주)유유헬스케어]","가이스머슬 웨이 [(주)유유헬스케어]"};
            string[] lst2 = { "(구)츄어블오메가-3 [(주)서흥]", "100억 프로바이오틱스 [코스맥스엔비티(주)]", "10억 생유산균 키즈 [엠에스바이오텍(주)제2공장]","2455레드다이어트 [노비스바이오(주)]",
            "3-콤보 [코스맥스바이오(주)]","333 프로그램 홍삼정차 [주식회사 네추럴웨이]","36.5 다이어트 [(주)양생당]"};
            string[] lst3 = { "구스밸런스푸드 [주식회사 노바렉스]", "레이디피크노제놀 [네이처퓨어코리아(주)]", "바이오 유산균 면역플로스 [주식회사 노바렉스]",
            "바이오 장유산균 [주식회사 노바렉스]","비바이뮨 캡슐 [주식회사 제이비케이랩]","에버콜라겐시그니처앰플 [코스맥스바이오(주)]","원앤원양 [주식회사 동진제약]"
            ,"원앤원음 [주식회사 동진제약]","장유산균 [주식회사 노바렉스]","카테슬림 [주식회사 노바렉스]","코엔자임NatQ [네이처퓨어코리아(주)]", "튼튼닷컴 알로에 쾌변 [주식회사 노바렉스]"};
            string[] lst4 = { "HCA 슬림라인 [(주)유유헬스케어","라피노스 [한국바이오팜(주)]","명작애 홍삼365 [고려홍삼원(주)]","미오나 라피노스 [(주)네추럴에프앤피 음성공장]" };
            string[] lst5 = { "G7 혼합유산균 [풀무", "건강한 이바넨 [(주)충청바이오텍]", "관절살리도 골드 [코스맥스바이오(주)]",
                "글루코사민1000 [한국바이오팜(주)]","다이어트 플러스 [(주)한풍네이처팜]","다인올브골드 [코스맥스바이오(주)]","닥터이지스A [풀무원건강생활(주)]",
            "도담키즈-드림 [(주)아리바이오에인치앤비]"};
            string[] lst6 = { "굿센 [동서바이오팜(주)]", "닥터 건강 플러스 [태웅식품(주)]", "닥터써큐원D [코스맥스바이오(주)]",
                "닥터징코원 [코스맥스바이오(주)]","듀썸헬씨 유코드 코어사딘 [동서바이오팜(주)]","리턴Q정어리펩타이드SP100N [코스맥스바이오(주)]","리턴큐 [코스맥스바이오(주)]",
            "리턴큐골드 [코스맥스바이오(주)]","맥스톤 [동서바이오팜(주)]","센바로 [동서바이오팜(주)]","서큐렉스오메가3 [주식회사 노바렉스]"};
            string[] lst7 = { "Key-Up(전량수출용) [(주)내츄럴엔도텍]", "보움써큘라케어카제인가수분해물 [주식회사 노바렉스]" };
            string[] lst8 = { "+프리맥 [코스맥스바이오(주)]", "0225 리얼 히알루론산 워터밤 [네이처퓨어코리아(주)]", "Amado Ka-ne X(아마도카-네 지)수출용(태국) [에프엔바이오(주)]",
                "Atomy 5-Saw palmetto(수출용) [콜마비앤에이치(주)푸디팜사업부문]","BIOCARE(전량수출용) [주식회사한미양행]"};
            string[] lst9 = { "+프리맥 [코스맥스바이오(주)]", "0225 리얼 히알루론산 워터밤 [네이처퓨어코리아(주)]", "Amado Ka-ne X(아마도카-네 지)수출용(태국) [에프엔바이오(주)]",
                "Atomy 5-Saw palmetto(수출용) [콜마비앤에이치(주)푸디팜사업부문]","BIOCARE(전량수출용) [주식회사한미양행]"};

            string[] lst10 = { "+프리맥 [코스맥스바이오(주)]", "0225 리얼 히알루론산 워터밤 [네이처퓨어코리아(주)]", "Amado Ka-ne X(아마도카-네 지)수출용(태국) [에프엔바이오(주)]",
                "Atomy 5-Saw palmetto(수출용) [콜마비앤에이치(주)푸디팜사업부문]","BIOCARE(전량수출용) [주식회사한미양행]"};

            string[] lst11 = { "+프리맥 [코스맥스바이오(주)]", "0225 리얼 히알루론산 워터밤 [네이처퓨어코리아(주)]", "Amado Ka-ne X(아마도카-네 지)수출용(태국) [에프엔바이오(주)]",
                "Atomy 5-Saw palmetto(수출용) [콜마비앤에이치(주)푸디팜사업부문]","BIOCARE(전량수출용) [주식회사한미양행]"};

            string[] lst12 = { "+프리맥 [코스맥스바이오(주)]", "0225 리얼 히알루론산 워터밤 [네이처퓨어코리아(주)]", "Amado Ka-ne X(아마도카-네 지)수출용(태국) [에프엔바이오(주)]",
                "Atomy 5-Saw palmetto(수출용) [콜마비앤에이치(주)푸디팜사업부문]","BIOCARE(전량수출용) [주식회사한미양행]"};

            string[] lst13 = { "+프리맥 [코스맥스바이오(주)]", "0225 리얼 히알루론산 워터밤 [네이처퓨어코리아(주)]", "Amado Ka-ne X(아마도카-네 지)수출용(태국) [에프엔바이오(주)]",
                "Atomy 5-Saw palmetto(수출용) [콜마비앤에이치(주)푸디팜사업부문]","BIOCARE(전량수출용) [주식회사한미양행]"};

            string[] lst14 = { "+프리맥 [코스맥스바이오(주)]", "0225 리얼 히알루론산 워터밤 [네이처퓨어코리아(주)]", "Amado Ka-ne X(아마도카-네 지)수출용(태국) [에프엔바이오(주)]",
                "Atomy 5-Saw palmetto(수출용) [콜마비앤에이치(주)푸디팜사업부문]","BIOCARE(전량수출용) [주식회사한미양행]"};

            string[] lst15 = { "+프리맥 [코스맥스바이오(주)]", "0225 리얼 히알루론산 워터밤 [네이처퓨어코리아(주)]", "Amado Ka-ne X(아마도카-네 지)수출용(태국) [에프엔바이오(주)]",
                "Atomy 5-Saw palmetto(수출용) [콜마비앤에이치(주)푸디팜사업부문]","BIOCARE(전량수출용) [주식회사한미양행]"};

            string[] lst16 = { "+프리맥 [코스맥스바이오(주)]", "0225 리얼 히알루론산 워터밤 [네이처퓨어코리아(주)]", "Amado Ka-ne X(아마도카-네 지)수출용(태국) [에프엔바이오(주)]",
                "Atomy 5-Saw palmetto(수출용) [콜마비앤에이치(주)푸디팜사업부문]","BIOCARE(전량수출용) [주식회사한미양행]"};


            if (cmbx.SelectedIndex == 0) ltbx.Items.AddRange(lst1);
            if (cmbx.SelectedIndex == 1) ltbx.Items.AddRange(lst2);
            if (cmbx.SelectedIndex == 2) ltbx.Items.AddRange(lst3);
            if (cmbx.SelectedIndex == 3) ltbx.Items.AddRange(lst4);
            if (cmbx.SelectedIndex == 4) ltbx.Items.AddRange(lst5);
            if (cmbx.SelectedIndex == 5) ltbx.Items.AddRange(lst6);
            if (cmbx.SelectedIndex == 6) ltbx.Items.AddRange(lst7);
            if (cmbx.SelectedIndex == 7) ltbx.Items.AddRange(lst8);
            if (cmbx.SelectedIndex == 8) ltbx.Items.AddRange(lst9);
            if (cmbx.SelectedIndex == 9) ltbx.Items.AddRange(lst10);
            if (cmbx.SelectedIndex == 10) ltbx.Items.AddRange(lst11);
            if (cmbx.SelectedIndex == 11) ltbx.Items.AddRange(lst12);
            if (cmbx.SelectedIndex == 12) ltbx.Items.AddRange(lst13);
            if (cmbx.SelectedIndex == 13) ltbx.Items.AddRange(lst14);
            if (cmbx.SelectedIndex == 14) ltbx.Items.AddRange(lst15);
            if (cmbx.SelectedIndex == 15) ltbx.Items.AddRange(lst16);
        }
    }
}
