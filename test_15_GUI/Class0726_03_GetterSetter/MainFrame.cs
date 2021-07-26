using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class0726_03_GetterSetter
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Car car_1 = new Car("그랜저", "흰색", 45000000, "현대");
            car_1.show_info();
            Console.WriteLine();
            Console.WriteLine(car_1.ToString());

            car_1.Model = "제네시스";
            car_1.Color = "검은색";
            car_1.Price = 670000000;
            car_1.Manu_com = "HYNDAI";

            car_1.show_info();
            Console.WriteLine();
            Console.WriteLine(car_1.ToString());
        }
    }
}
