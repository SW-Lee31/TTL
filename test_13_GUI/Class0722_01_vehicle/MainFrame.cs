using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class0722_01_vehicle
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Vehicle car_1 = new Vehicle();
            car_1.veh_info();

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");

            Vehicle car_2 = new Vehicle("Hyndai", "wine", "Palisade", 54000000);
            car_2.veh_info();

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");

            Vehicle car_3 = new Vehicle();
            car_3.veh_info();
            Console.WriteLine();
            Console.WriteLine("차량 모델과 가격을 변동합니다.");

            Console.Write("기존의 모델({0} || 가격 : {1})에서 ", car_3.getmodel(), car_3.getprice());
            car_3.setmodel("Sportage");
            car_3.setprice(47600000);
            Console.WriteLine("모델({0} || 가격 : {1})로 변경되었습니다.", car_3.getmodel(), car_3.getprice());
            Console.WriteLine();
            Console.WriteLine("변경된 차량정보입니다.");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            car_3.veh_info();
        }
    }
}
