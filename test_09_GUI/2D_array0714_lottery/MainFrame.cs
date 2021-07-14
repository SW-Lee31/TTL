using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_array0714_lottery
{
    public partial class MainFrame : Form
    {
        Random ran = new Random();

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            int[] lottery_arr = new int[7];
            int[] lottery_compare = new int[7]
            {
                0, 0, 0, 0, 0, 0, 0
            };


            for (int i = 0; i < lottery_arr.Length; i++)
            {
                lottery_arr[i] = ran.Next(1, 46);

                for (int j = 0; j < i; j++)
                {
                    if (lottery_arr[i] == lottery_arr[j])
                    {
                        i--;
                        break;
                    }
                }
                Console.Write(lottery_arr[i] + " ");
            }
        }

        private void operate_button_Click(object sender, EventArgs e)
        {
            int[] lottery_arr = new int[7];

            for (int i = 0; i < lottery_arr.Length; i++)
            {
                int lottery_digit = ran.Next(1, 46);
                if (!lottery_arr.Contains(lottery_digit))
                {
                    lottery_arr[i] = lottery_digit;
                }
                Console.WriteLine(lottery_arr[i]);
            }

            output_1.Text = lottery_arr[0].ToString();
            output_2.Text = lottery_arr[1].ToString();
            output_3.Text = lottery_arr[2].ToString();
            output_4.Text = lottery_arr[3].ToString();
            output_5.Text = lottery_arr[4].ToString();
            output_6.Text = lottery_arr[5].ToString();
            output_bonus.Text = lottery_arr[6].ToString();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit?");
            Application.Exit();
        }
    }
}
