using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method0716_2
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            while (true)
            {
                Console.Write("Input first digit : ");
                int first_num = digit_input();
                Console.Write("Input operational code in (+, -, x, /) : ");
                string oper = operation_input();
                Console.Write("Input second digit : ");
                int second_num = digit_input();

                string answer = print_result(first_num, oper, second_num);

                if (answer == "N" || answer == "n")
                {
                    Console.WriteLine("finish the program");
                    break;
                }
            }
        }

        string print_result(int first_num, string oper, int second_num)
        {
            Console.WriteLine("{0} {1} {2} = {3}", first_num, oper, second_num, Calculate(first_num, second_num, oper));
            Console.Write("Do you want to continue? (Y/N) : ");
            string answer = Console.ReadLine();

            return answer;
        }

        int digit_input()
        {
            int digit = int.Parse(Console.ReadLine());

            return digit;
        }

        string operation_input()
        {
            string oper = Console.ReadLine();

            return oper;
        }

        int Calculate(int x, int y, string oper)
        {
            int result = 0;

            switch(oper)
            {
                case "+":
                    result =  x + y;
                    break;

                case "-":
                    result = x - y;
                    break;

                case "x":
                    result = x * y;
                    break;

                case "/":
                    result = x / y;
                    break;

                default:
                    MessageBox.Show("input proper operation_code (+, -, x, /)");
                    break;
            }
            return result;
        }
    }
}
