using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method0716_7_multipication_table
{
    public partial class MainFrame : Form
    {
        const int MUL = 9;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            ////////// 입력받은 숫자로 구구단 출력 ////////////////
            Console.WriteLine("##################입력받은 숫자 구구단 출력###################");
            Console.WriteLine();

            Console.Write("구구단계산을 원하는 값을 입력하세요 : ");
            int input_num = int.Parse(Console.ReadLine());
            int[] print_arr = new int[MUL];
            print_arr = input_multi(input_num);
            
            for (int i = 0; i < print_arr.Length; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", input_num, (i + 1), print_arr[i]);
            }

        }

        int[] input_multi(int input_num)
        {
            int[] result_arr = new int[MUL];

            for (int i = 0; i < result_arr.Length; i++)
            {
                result_arr[i] = input_num * (i + 1);
            }

            return result_arr;
        }


    }
}
