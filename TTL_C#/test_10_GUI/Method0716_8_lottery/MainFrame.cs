using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method0716_8_lottery
{
    public partial class MainFrame : Form
    {
        Random ran = new Random();
        const int LOTTO_NUM = 7;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            int[] result_lottery = new int[LOTTO_NUM];
            result_lottery = Lottery_arr();

            for (int i = 0; i < result_lottery.Length; i++)
            {
                Console.Write(result_lottery[i] + " ");
            }
        }

        int[] Lottery_arr()
        {
            int[] lottery_arr = new int[LOTTO_NUM];

            for (int i = 0; i < lottery_arr.Length; i++)
            {
                int lotto = Lotto();

                if (!lottery_arr.Contains(lotto))
                {
                    lottery_arr[i] = lotto;
                }
            }

            return lottery_arr;
        }

        int Lotto()
        {
            int lotto = ran.Next(1, 46);

            return lotto;
        }
    }
}
