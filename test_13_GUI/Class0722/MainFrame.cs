using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class0722
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            // Car 클래스 객체 생성
            Car car_salary_1 = new Car(); 
            /*Car.fuel_type car_salary_1_fuel = new Car.fuel_type();*/

            // Car 클래스에 인스턴스 변수 할당
            /*car_salary_1.model_name = "Grandeur";
            car_salary_1.price = 27310000;
            car_salary_1.year = 2021;
            car_salary_1.color = "black";
            car_salary_1.displacement = 2.4;*/
            /*car_salary_1_fuel = Car.fuel_type.gasoline;*/
            car_salary_1.car_sell();
            
            Console.WriteLine();

            Car car_salary_2 = new Car();
            /*Car.fuel_type car_salary_2_fuel = new Car.fuel_type();*/
            /*car_salary_2.model_name = "genesis";
            car_salary_2.price = 48800000;
            car_salary_2.year = 2018;
            car_salary_2.color = "gray";
            car_salary_2.displacement = 3.7;*/
            /*car_salary_2_fuel = Car.fuel_type.gasoline;*/
            car_salary_2.car_sell();

            Console.WriteLine();

            Car car_salary_3 = new Car("audi", 65700000);
            car_salary_3.car_sell();

            Console.WriteLine();

            Car car_salary_4 = new Car("bentz", 74000000, 2021, "black", 4.5);
            car_salary_4.car_sell();


            Console.WriteLine();

            Car car_salary_5 = new Car("land_rover", 82500000, 2020, "chrom", 5.9);
            car_salary_5.car_sell();

            Console.Write("차량색상을 {0}에서 ", car_salary_5.getcolor());
            car_salary_5.setcolor("orange");
            Console.Write("{0}로 바꾸었습니다.\n", car_salary_5.getcolor());
        }
    }
}
