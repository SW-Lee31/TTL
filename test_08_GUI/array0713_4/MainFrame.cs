using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array0713_4
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Console.Write("이진화할 숫자를 입력해주세요 : ");
            int input_num = int.Parse(Console.ReadLine());
            int[] result_arr = new int[16];

            int i = 0;

            while (input_num != 0)
            {
                result_arr[i] = input_num % 2;
                input_num /= 2;
                i++;
            }

            Array.Reverse(result_arr);

            for (int index = 0; index < result_arr.Length; index++)
            {
                Console.Write(result_arr[index] + " ");
            }



        }
    }
}
