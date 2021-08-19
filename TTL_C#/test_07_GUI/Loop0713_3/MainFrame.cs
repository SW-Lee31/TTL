using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loop0713_3
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Console.WriteLine("#######################################");
            Console.WriteLine("           입력 받은 구구단");
            Console.WriteLine("#######################################");
            Console.Write("1 ~ 9까지의 곱셈값을 원하는 숫자를 입력해주세요 : ");
            int input_num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", input_num, i, (input_num * i));
            }

            ////////////////////////////////////////////////////////////////////////////////
           
            Console.WriteLine("#######################################");
            Console.WriteLine("            9 X 19단 출력");
            Console.WriteLine("#######################################");

            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 19; j++)
                {
                    Console.Write("{0} X {1} = {2}", j, i, (i * j));
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }
}
