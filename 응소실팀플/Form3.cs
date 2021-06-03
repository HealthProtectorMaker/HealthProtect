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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltbx.Items.Clear();

            string[] lst1 = { "+발효홍삼진 [(주)네추럴에프앤피 2공장]", "11피엠(PM) 톡 라이트 [코스맥스바이오(주)]", "365뉴트리션멀티비타민앤미네랄 [동서바이오팜(주)]",
                "Enhanced Essential Progiotics(전량수출용) [(주)네추럴에프앤피 2공장]","G7혼합유산균 [풀무원건강생활(주)]","HerBalance(전량수출용) [(주)네추럴에프앤피 2공장]"
                ,"혈천포르테 [코스맥스바이오(주)]",
            "Mr-10 미스터플러스 [(주)서흥 오창공장]","STARMOR(전량수출용 [(주)팜크로스]","간엔다움 [주식회사 다움]"};
            string[] lst2 = { "35베리삼환프리미엄(전량수출용) [노비스바이오(주)]", "4년근인삼농축액15 [대동고려삼(주)]", "6년근 고려홍삼 골드스틱100 [농업회사법인(주)힐링팜]","건강한혈행 [(주)한국씨엔에스팜]",
            "6년근 고려홍삼정진액스틱 [바산 고려홍삼(주)]","6년근인삼농축액20 [대동고려삼(주)]","6년근발효홍삼본액 [(주)서흥 오창공장]"};
            string[] lst3 = { "+간건강 [코스맥스바이오(주)]", "0920 리얼 밀크씨슬 & 홍경천 [네이처퓨어코리아(주)]", "3초습관 플러스타민 종합영양제 [(주)팜크로스]",
            "6년근 면역홍삼사포닌캡슐정 [고려인삼연구(주)]","6년근 발효홍삼CK(씨케이) [(주)파낙스코리아]","6년근 홍삼스틱 힘내삼 [고려홍삼원(주)]"};
            string[] lst4 = { "0118 리얼 테아닌 스트레스 클린 [네이처퓨어코리아(주)","0920 리얼 밀크씨슬 & 홍경천 [네이처퓨어코리아(주)","24다이어트 데이 [(주)한국씨엔에스팜]"
            ,"BF-7 아인슈타인 [콜마비앤에이치(주)푸디팜사업부문]", "ENERGETIC TONIC(수출용) [(주)한국인삼공사]","FOHO-15 [(주)오투바이오","RG프러스정 [(주)한국씨엔에스팜]," ,
            "간건강 [(주)서흥]","간에 좋은 안국 밀크씨슬 [주식회사한미양행]","간엔밀크씨슬 [주시회사 다움]","간조은 [콜마비앤에이치(주)푸디팜사업부문"
            ,"간편한에센셜 [(주)한국씨엔에스팜]","간프로 [이성제약(주)]"};
            string[] lst5 = { "(수진)고려홍삼정 [(주)수진식품]", "+면역비책 발효홍삼 [(주)네추럴에프앤피]", "+발효홍삼진 [(주)네추럴에프앤피 2공장]",
                "+홍삼젤리 [코스맥스바이오(주)]","0225 리얼 히알루론산 워터밤 [네이처퓨어코리아(주)]","0920 리얼 킬크씨슬 & 홍경천 [네이처퓨어코리아(주)]","10대를 위한 기억력 업(UP)홍삼 [(주)건보]",
            "42.195km [(주)비티진]"};

            if (cmbx.SelectedIndex == 0) ltbx.Items.AddRange(lst1);
            if (cmbx.SelectedIndex == 1) ltbx.Items.AddRange(lst2);
            if (cmbx.SelectedIndex == 2) ltbx.Items.AddRange(lst3);
            if (cmbx.SelectedIndex == 3) ltbx.Items.AddRange(lst4);
            if (cmbx.SelectedIndex == 4) ltbx.Items.AddRange(lst5);
        }
    }
}
