using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class0726
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Car car_1 = new Car("HYNDAI", "검은색", 45000000, "GRANDIUR");

            Console.WriteLine("대리점명 : {0}", Car.AGENCY);
            car_1.show_info();

            Console.WriteLine("차량 정보 변경");
            car_1.Model = "GENESIS";
            car_1.Price = 67500000;
            Console.WriteLine();
            Console.WriteLine("대리점명 : {0}", Car.AGENCY);
            car_1.show_info();

            Console.WriteLine("차량가격 : {0}", car_1.Price);
        }
    }
}
