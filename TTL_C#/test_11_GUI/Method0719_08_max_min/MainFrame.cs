using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method0719_08_max_min
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Console.Write("비교를 원하는 첫번째 값을 입력해주세요. : ");
            int num_1 = int.Parse(Console.ReadLine());
            Console.Write("비교를 원하는 두번째 값을 입력해주세요. : ");
            int num_2 = int.Parse(Console.ReadLine());
            Console.Write("비교를 원하는 세번째 값을 입력해주세요. : ");
            int num_3 = int.Parse(Console.ReadLine());

            int[] result = Compare(num_1, num_2, num_3);

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " --> ");
            }
        }

        int[] Compare(int num_1, int num_2, int num_3)
        {
            int[] compare_arr = new int[3]
            {
                num_1, num_2, num_3
            };

            for (int i = 0; i < compare_arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (compare_arr[j] > compare_arr[i])
                    {
                        int temp = compare_arr[j];
                        compare_arr[j] = compare_arr[i];
                        compare_arr[i] = temp;
                    }
                }
            }

            return compare_arr;
        }
    }
}
