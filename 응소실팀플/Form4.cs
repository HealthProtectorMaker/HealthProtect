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
            string[] lst5 = { "G7 혼합유산균 [풀무원건강생활(주)]", "고은다이어트슬림식이섬유 [(주)비오팜]", "골든볼 [에스케이내추럴팜(주)]",
                "굿모닝 쾌변 플러스 다이어트 [(주)오투바이오]","네오바디 클린팻파우더S [주식회사한미양행]","녹십초닥터센스진 [(주)녹십초알로에]","더리얼신바이오틱스 [코스맥스바이오(주)]",
            "데일리 프로바이오틱스 [풀무원건강생활(주)]"};
            string[] lst6 = { "100억 프로바이오틱스 [코스맥스엔비티(주)]", "V-바이오틱스 [콜마비앤에이치(주)푸디팜사업부문]", "굿락투유 키즈 프로바이오틱스 [엠에스바이오텍(주)]",
                "그린핏유산균[엠에스바이오텍(주)제2공장]","글로벌비겐 리케어칼슘 [포항바이오파크]","나이트슬림다이어트 [엠에스바이오텍(주)]","닥터 3세대 유산균 [엠에스바이오텍(주)제2공장]",
            };            


            if (cmbx.SelectedIndex == 0) ltbx.Items.AddRange(lst1);
            if (cmbx.SelectedIndex == 1) ltbx.Items.AddRange(lst2);
            if (cmbx.SelectedIndex == 2) ltbx.Items.AddRange(lst3);
            if (cmbx.SelectedIndex == 3) ltbx.Items.AddRange(lst4);
            if (cmbx.SelectedIndex == 4) ltbx.Items.AddRange(lst5);
            if (cmbx.SelectedIndex == 5) ltbx.Items.AddRange(lst6);
        }
    }
}
