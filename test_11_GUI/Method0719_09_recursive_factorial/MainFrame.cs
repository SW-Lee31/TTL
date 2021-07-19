using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method0719_09_recursive_factorial
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Console.Write("팩토리얼을 원하는 숫자를 입력하세요. : ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}! = {1}", num, Factorial(num));
        }

        int Factorial(int num)
        {
            if (num == 1 || num == 0)
            {
                return 1;
            }

            return num * Factorial(num - 1);
        }
    }
}
