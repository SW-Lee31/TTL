using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class0723_04_Park_management
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동",
            "황길동", "주길동", "류길동", "탁길동", "양길동" };

            string[] tel = { "010-1234-5678", "010-4321-5678", "010-3478-1278", 
                "010-4523-1978", "010-7890-2134", "010-9292-9999", "010-1111-2222",
            "010-3333-4444", "010-1230-0000", "010-1092-9711" };

            string[] address = {"대구시 동구 신암4동", "서울시 동구 신암4동",
                "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동",
            "울산시 동구 신암4동", "포항시 동구 신암4동", "철원시 동구 신암4동",
            "전주시 동구 신암4동", "성남시 동구 신암4동" };

            string[] model = { "SM6", "SONATA", "SANTAFE", "K7", "GRADEUR",
            "AUDI", "LANDROVER", "BMW", "BENTZ", "SPORTAGE"};

            string[] color = { "블랙", "은색", "흰색", "회색", "빨강", "크롬",
            "주황", "노랑", "쥐색", "파랑" };

            int[] year = { 2016, 2017, 2016, 2017, 2016, 2021, 2020, 2018, 2017, 2019 };

            string[] company = { "삼성르노", "현대", "현대", "기아", "현대", "아우디",
            "BMW", "랜드로버", "벤츠", "기아"};

            Customer[] customer_list = new Customer[10];

            for (int i = 0; i < customer_list.Length; i++)
            {
                Console.WriteLine("\t{0}번째 고객님의 정보입니다.", (i + 1));
                Console.WriteLine();
                customer_list[i] = new Customer(name[i], tel[i], address[i], 
                    new Car(model[i], color[i], year[i], company[i]));

                
                customer_list[i].print();
            }

        }
    }
}
