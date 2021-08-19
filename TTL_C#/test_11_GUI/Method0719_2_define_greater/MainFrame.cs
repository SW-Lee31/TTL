using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method0719_2_define_greater
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Console.Write("첫번째 값을 입력해주세요. : ");
            int num_1 = int.Parse(Console.ReadLine());
            Console.Write("두번째 값을 입력해주세요. : ");
            int num_2 = int.Parse(Console.ReadLine());
            Console.Write("세번째 값을 입력해주세요. : ");
            int num_3 = int.Parse(Console.ReadLine());

            Define_greater(num_1, num_2, num_3); 
        }

        void Define_greater(int num_1, int num_2, int num_3)
        {
            int first_place;
            int second_place;
            int third_place;

            if (num_1 >= num_2 && num_1 >= num_3 && num_2 >= num_3)
            {
                first_place = num_1;
                second_place = num_2;
                third_place = num_3;
            }

            else if (num_1 >= num_2 && num_1 >= num_3 && num_2 < num_3)
            {
                first_place = num_1;
                second_place = num_3;
                third_place = num_2;
            }

            else if (num_2 > num_1 && num_2 >= num_3 && num_1 >= num_3)
            {
                first_place = num_2;
                second_place = num_1;
                third_place = num_3;
            }

            else if (num_2 > num_1 && num_2 >= num_3 && num_1 < num_3)
            {
                first_place = num_2;
                second_place = num_3;
                third_place = num_1;
            }

            else if (num_3 > num_1 && num_3 >= num_2 && num_1 < num_2)
            {
                first_place = num_3;
                second_place = num_2;
                third_place = num_1;
            }

            else
            {
                first_place = num_3;
                second_place = num_1;
                third_place = num_2;
            }

            Console.WriteLine("{0} --> {1} --> {2}", first_place, second_place, third_place);
        }
    }
}
