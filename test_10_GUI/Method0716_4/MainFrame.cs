using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method0716_4
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Print_arr(Processing_hj(Arr_maker()));
        }

        int[] Arr_maker()
        {
            int[] input_arr = new int[10];

            for (int i = 0; i < input_arr.Length; i++)
            {
                Console.Write("{0}번째 값을 입력해주세요. : ", (i + 1));
                input_arr[i] = int.Parse(Console.ReadLine());
            }

            return input_arr;
        }

        string[] Processing_hj(int[] input_arr)
        {
            string[] result_arr = new string[10];

            for (int i = 0; i < input_arr.Length; i++)
            {
                if (input_arr[i] % 2 == 1)
                {
                    result_arr[i] = "홀";
                }

                else
                {
                    result_arr[i] = "짝";
                }
            }

            return result_arr;
        }

        void Print_arr(string[] result_arr)
        {
            for (int i = 0; i < result_arr.Length; i++)
            {
                Console.WriteLine("{0}번째 값은 \"{1}\" 입니다. ", (i+1), result_arr[i]);
            }
        }

    }
}
