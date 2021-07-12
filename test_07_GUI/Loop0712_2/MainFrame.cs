using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loop0712_2
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
            //////////////////////////////////////////////////
            ///////////////// 로또 프로그램 ///////////////////
            //////////////////////////////////////////////////
            int[] lottery_arr = { 0, 0, 0, 0, 0, 0, 0};

            for (int i = 0; i < 6; i++)
            {
                int lottery_num = ran.Next(1, 46);

                if (!lottery_arr.Contains(lottery_num)) // 숫자 중복 확인
                {
                    lottery_arr[i] = lottery_num;
                }

                else
                {
                    i--;
                    continue;
                }
                
                Console.Write(lottery_arr[i] + "  ");
            }
            Console.WriteLine();

            while (lottery_arr[6] == 0)
            {
                int bonus_num = ran.Next(1, 46);
                if (!lottery_arr.Contains(bonus_num))
                {
                    Console.WriteLine("★보너스 숫자는 {0}입니다.", bonus_num);
                    lottery_arr[6] = bonus_num;
                }

                else
                {
                    continue;
                }
            }

        }
    }
}
