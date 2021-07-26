using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class0726_05_parking_management
{
    public partial class MainFrame : Form
    {
        Random ran = new Random();

        const int num_people = 10;

        string name;
        string p_num;
        string addr;
        private string model;
        private string year;
        private string color;
        private string manu_com;


        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Customer[] customer_list = new Customer[num_people];

            for (int i = 0; i < num_people; i++)
            {
                Name_create();
                Car_property();

                customer_list[i] = new Customer(name, p_num, addr, new Car(model, color, year, manu_com));
                Console.WriteLine("\"{0}\"의 정보 및 차량구매정보입니다.", customer_list[i].Name);
                Console.WriteLine();
                customer_list[i].printCustomerInfo();
                Console.WriteLine("#####################################");
                Console.WriteLine();
            }
        }

        void Name_create()
        {

            string[] name_elements =
               { "홍길동", "김길동", "박길동", "이길동", "최길동", "황길동",
                    "류길동", "양길동", "강길동", "구길동", "피길동"};

            string[] p_num_elements =
                  { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

            string[] addr_elements_city =
                    {"대구시", "서울시", "인천시","평택시",
                "울산시", "광주시", "포항시", "제주시", "영천시", "신안시"};

            string[] addr_elements_area =
                { "동구", "북구", "남구", "서구", "동구", "달서구", "중구", "수성구" };

            name = name_elements[ran.Next(name_elements.Length)];
            p_num = "010-";

            for (int j = 0; j < 4; j++)
            {
                p_num += p_num_elements[ran.Next(p_num_elements.Length)];
            }

            p_num += "-";

            for (int j = 0; j < 4; j++)
            {
                p_num += p_num_elements[ran.Next(p_num_elements.Length)];
            }

            addr = "";

            addr += addr_elements_city[ran.Next(addr_elements_city.Length)];
            addr += addr_elements_area[ran.Next(addr_elements_area.Length)];

            for (int j = 0; j < ran.Next(3); j++)
            {
                addr += p_num_elements[ran.Next(p_num_elements.Length)];
            }

            addr += "번지";
        }

        void Car_property()
        {

            model = "";
            year = "20";

            string[] model_elements =
               { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K" };

            string[] p_num_elements =
                  { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

            string[] color_elements =
                { "블랙", "은색", "크롬", "주황", "빨강", "노랑", "흰색", "쥐색", "시에리" };

            string[] year_elemets =
               { "0", "1", "2" };

            string[] manu_com_elements =
               { "Samsung  Renault", "Audi", "Bentz", "Hyndai", "Kia",
                        "Ssangyong", "LandRover", "Toyota", "Lexus",
                        "Daewoo", "Chevolet", "Volvo"};

            for (int i = 0; i < 3; i++)
            {
                model += model_elements[ran.Next(model_elements.Length)];
            }

            model += " - ";

            for (int i = 0; i < 2; i++)
            {
                model += p_num_elements[ran.Next(p_num_elements.Length)];
            }

            color = color_elements[ran.Next(color_elements.Length)];

            for (int i = 0; i < 2; i++)
            {
                year += year_elemets[ran.Next(year_elemets.Length)];
            }

            manu_com = manu_com_elements[ran.Next(manu_com_elements.Length)];
        }
    }
}
