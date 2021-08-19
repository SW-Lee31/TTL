using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace while0708
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Console.WriteLine("2 ~ 9까지의 구구단");

            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine("{0} X {1} = {2}", i, j, i * j);
                }
            }
            Console.Write("1 ~ 9까지의 수를 곱해지기를 원하는 수를 입력하세요. ");
            int f_num = int.Parse(Console.ReadLine());
            int s_num = 1;

            do
            {
                Console.WriteLine("{0} X {1} = {2}", f_num, s_num, f_num * s_num);
                s_num++;
                if (s_num == 10)
                {
                    s_num = 0;
                    f_num++;
                }
            } while (s_num < 11 && f_num < 10);
        }
    }
}
