using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method0719_06_sum
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Console.Write("홀,짝수의 합을 원하는 시작숫자를 입력해주세요. : ");
            int start_num = int.Parse(Console.ReadLine());
            Console.Write("홀,짝수의 합을 원하는 끝나는 숫자를 입력해주세요. : ");
            int last_num = int.Parse(Console.ReadLine());
            
            if (last_num <= start_num)
            {
                MessageBox.Show("첫번째 값보다 큰 값을 입력해주세요.");
                while (last_num <= start_num)
                {
                    Console.Write("홀,짝수의 합을 원하는 끝나는 숫자를 입력해주세요. : ");
                    last_num = int.Parse(Console.ReadLine());
                }
            }

            int[] odd_arr = Odd_sum(start_num, last_num);
            int[] even_arr = Even_sum(start_num, last_num);
            int odd_sum = 0;
            int even_sum = 0;

            for (int i = 0; i < odd_arr.Length; i++)
            {
                odd_sum += odd_arr[i];
                even_sum += even_arr[i];
            }

            Console.WriteLine("입력숫자의 홀수의 합은 {0}, 짝수의 합은 {1}입니다. ", odd_sum, even_sum);
        }
        

        int[] Odd_sum(int start_num, int last_num)
        {
            int[] odd_arr = new int[(last_num - start_num) + 1];
            int index = 0;

            for (int i = start_num; i <= last_num; i++)
            {
                if (i % 2 == 1)
                {
                    odd_arr[index] = i;
                }
                index++;
            }

            return odd_arr;
        }

        int[] Even_sum(int start_num, int last_num)
        {
            int[] even_arr = new int[(last_num - start_num) + 1];
            int index = 0;

            for (int i = start_num; i <= last_num; i++)
            {
                if (i % 2 == 0)
                {
                    even_arr[index] = i;
                }
                index++;
            }

            return even_arr;
        }
    }
}
