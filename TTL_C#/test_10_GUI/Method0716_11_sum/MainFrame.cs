using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method0716_11_sum
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Console.WriteLine("###############입력값의 홀, 짝의 합##################");
            int[] input_arr = input();
            Console.WriteLine("입력하신 값의 홀수 합은 : {0}입니다.", odd(input_arr));
            Console.WriteLine("입력하신 값의 짝수 합은 : {0}입니다.", even(input_arr));

            Console.WriteLine();
            Console.WriteLine("###############입력값의 합##################");
            Console.WriteLine("1에서 입력한 값까지의 합은 : {0}", Sum(Input_num()));
        }

        int[] input()
        {
            int index = 0;
            Console.WriteLine("입력하신 숫자 사이의 홀수, 짝수의 합을 출력하겠습니다.");
            Console.Write("시작할 숫자를 입력해주세요. : ");
            int first_num = int.Parse(Console.ReadLine());
            Console.Write("끝나는 숫자를 입력해주세요. : ");
            int second_num = int.Parse(Console.ReadLine());

            int[] input_arr = new int[(second_num - first_num) + 1];

            for (int i = first_num; i <= second_num; i++)
            {
                input_arr[index] = i;
                index++;
            }

            return input_arr;
        }

        int odd(int[] input_arr)
        {
            int sum = 0;

            for (int i = 0; i < input_arr.Length; i++)
            {
                if (input_arr[i] % 2 == 1)
                {
                    sum += input_arr[i];
                }
            }

            return sum;
        }

        int even(int[] input_arr)
        {
            int sum = 0;

            for (int i = 0; i < input_arr.Length; i++)
            {
                if (input_arr[i] % 2 == 0)
                {
                    sum += input_arr[i];
                }
            }

            return sum;
        }

        int Input_num()
        {
            Console.Write("1부터 합산할 값을 입력하세요 : ");
            int input_num = int.Parse(Console.ReadLine());

            return input_num;
        }

        int Sum(int input_num)
        {
            int sum = 0;

            for (int i = 0; i < input_num; i++)
            {
                sum += (i + 1);
            }

            return sum;
        }
    }
}
