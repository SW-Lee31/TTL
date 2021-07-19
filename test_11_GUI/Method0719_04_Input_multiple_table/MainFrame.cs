using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method0719_04_Input_multiple_table
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Console.Write("구구단을 원하는 숫자값을 입력해주세요 : ");
            int input_num = int.Parse(Console.ReadLine());

            Multiple_table(input_num);
        }

        void Multiple_table(int input_num)
        {
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("{0} X {1} = {2}  ", input_num, i, (input_num * i));
            }   
        }
    }
}
