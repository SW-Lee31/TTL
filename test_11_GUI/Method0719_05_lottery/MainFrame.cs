using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method0719_05_lottery
{
    public partial class MainFrame : Form
    {
        Random ran = new Random();
        const int LOTTO = 7;
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            int[] result = Create_lotto_arr();

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }

        int Create_lotto()
        {
            int lotto = ran.Next(1, 46);

            return lotto;
        }

        int[] Create_lotto_arr()
        {
            int[] lottery_arr = new int[LOTTO];

            for (int i = 0; i < LOTTO; i++)
            {
                lottery_arr[i] = Create_lotto();
                for (int j = 0; j < i; j++)
                {
                    if (lottery_arr[i] == lottery_arr[j])
                    {
                        i--;
                        continue;
                    }
                }
            }

            return lottery_arr;
        }
    }
}
