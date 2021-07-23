using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_03_vehicle
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Vehicle car = new Vehicle("기아", "블랙", 40000000, "K-7");

            car.show_vehi_info();

            // 기본 생성자 - 빈 값 출력
            Vehicle car_basic = new Vehicle();

            car_basic.show_vehi_info();
            Console.WriteLine();

            Console.Write("바꿀 차량 모델명 : {0}  --->  ", car.Model_name);
            car.Model_name = "k8";
            Console.WriteLine("바뀐 차량 모델명 : {0}", car.Model_name);

            Console.Write("바꿀 차량 가격 : {0}  --->   ", car.Price);
            car.Price = 35000000;
            Console.WriteLine("바뀐 차량 가격 : {0}  --->   ", car.Price);
            Console.WriteLine();

            Console.WriteLine("##############################");
            Console.WriteLine("수정된 정보를 출력합니다 .");
            car.show_vehi_info();
        }
    }
}
