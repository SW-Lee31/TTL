using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array0713_3
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            int[] arr_int = new int[100];

            for (int i = 1; i <= 100; i++)
            {
                arr_int[i - 1] = i;
                
                if (i % 5 == 0)
                {
                    Console.Write(arr_int[i - 1] + " ");
                }

                if (i == 91)
                {
                    Console.WriteLine();
                    Console.WriteLine("현재 index의 위치는 {0}이고 값은 {1}입니다. \n출력을 중지하겠습니다. ", (i - 1), arr_int[i - 1]);
                    break;
                }
            }

            /////////////////////////////////////////////////////////////////////
            Console.WriteLine();

            int[] arr_int_1 = new int[10]
            {
                10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };

            int[] arr_int_2 = new int[10];

            int desc = (arr_int_1.Length - 1);

            for (int i = 0; i < arr_int_2.Length; i++)
            {
/*                arr_int_2[i] = arr_int_1[-i - 1];*/
                arr_int_2[i] = arr_int_1[desc];
                Console.WriteLine("arr_int_2[{0}] = {1}", i, arr_int_2[i]);
                desc--;
            }
        }
    }
}
