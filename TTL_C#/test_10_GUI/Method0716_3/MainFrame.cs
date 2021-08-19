using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method0716_3
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Console.Write("Input first digit : ");
            int first_num = int.Parse(Console.ReadLine());
            Console.Write("Input second digit : ");
            int second_num = int.Parse(Console.ReadLine());
            Console.Write("Input third digit : ");
            int third_num = int.Parse(Console.ReadLine());

            Compare(first_num, second_num, third_num);
        }

        void Compare(int first_num, int second_num, int third_num)
        {
            int place_first = 0;
            int place_second = 0;
            int place_third = 0;

            if (first_num >= second_num && first_num >= third_num && second_num >= third_num)
            {
                place_first = first_num;
                place_second = second_num;
                place_third = third_num;
            }

            else if (first_num >= second_num && first_num >= third_num && second_num < third_num)
            {
                place_first = first_num;
                place_second = third_num;
                place_third = second_num;
            }

            else if (first_num < second_num && first_num >= third_num)
            {
                place_first = second_num;
                place_second = first_num;
                place_third = third_num;
            }

            else if (first_num < second_num && first_num < third_num && second_num > third_num)
            {
                place_first = second_num;
                place_second = third_num;
                place_third = first_num;
            }

            else if (first_num < second_num && first_num < third_num && second_num < third_num)
            {
                place_first = third_num;
                place_second = second_num;
                place_third = first_num;
            }

            else
            {
                place_first = third_num;
                place_second = first_num;
                place_third = second_num;
            }

            Console.WriteLine("{0} -> {1} -> {2}", place_first, place_second, place_third);
        }
    }
}
