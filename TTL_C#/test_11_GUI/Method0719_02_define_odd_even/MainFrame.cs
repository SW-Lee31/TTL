using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method0719_02_define_odd_even
{
    public partial class MainFrame : Form
    {
        Random ran = new Random();

        int[] int_arr = new int[10];

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            int[] made_arr = Create_Random_arr();
            Console.WriteLine("생성된 배열");
            
            for (int i = 0; i < int_arr.Length; i++)
            {
                Console.Write(made_arr[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("홀,짝 판단 결과");

            for (int i = 0; i < int_arr.Length; i++)
            {
                Console.Write(Define_odd_even(made_arr)[i] + ", ");
            }
        }

        int[] Create_Random_arr()
        {
            for (int  i = 0; i < int_arr.Length; i++)
            {
                int ran_int = ran.Next(1, 100);
                int_arr[i] = ran_int;
            }

            return int_arr;
        }

        string[] Define_odd_even(int[] int_arr)
        {
            string[] result = new string[10];

            for (int i = 0; i < result.Length; i++)
            {
                if (int_arr[i] % 2 == 0)
                {
                    result[i] = "짝";
                }

                else
                {
                    result[i] = "홀";
                }
            }

            return result;
        }
    }
}
