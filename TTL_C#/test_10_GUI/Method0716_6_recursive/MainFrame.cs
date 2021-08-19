using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method0716_6_recursive
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Console.Write("팩토리얼 값을 원하는 수를 입력해주세요. : ");
            int input_num = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", input_num, recursive_factorial(input_num));
        }

        int recursive_factorial(int num)
        {
            if (num == 1 || num == 0)
            {
                return 1;
            }

            return num * recursive_factorial(num - 1);
        }
    }
}
