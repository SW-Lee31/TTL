using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loop0713_2
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            int sum = 0;

            Console.WriteLine("###################################################");
            Console.WriteLine("입력받은 수까지의 합을 구하는 프로그램");
            Console.WriteLine("###################################################");
            
            Console.Write("첫번째 수를 입력해주세요 : ");
            double num_1 = double.Parse(Console.ReadLine());
            Console.Write("두번째 수를 입력해주세요 : ");
            double num_2 = double.Parse(Console.ReadLine());

            if (num_2 <= num_1)
            {
                while (num_2 <= num_1)
                {
                    Console.Write("Error : 두번째 수를 다시 입력해주세요(첫번째 숫자 보다 큰 값이어야 합니다 : ");
                    num_2 = double.Parse(Console.ReadLine());
                }

                if (num_2 > num_1)
                {
                    for (int index = (int)num_1; index <= (int)num_2; index++)
                    {
                        sum += index;
                    }
                }
            }    

            else
            {
                for (int index = (int)num_1; index <= (int)num_2; index++)
                {
                    sum += index;
                }
            }
            Console.WriteLine("{0}에서 {1}까지의 수의 합은 {2}입니다.", num_1, num_2, sum);
        }
    }
}
