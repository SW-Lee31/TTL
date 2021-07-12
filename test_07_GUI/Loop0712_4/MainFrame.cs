using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loop0712_4
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
            int checksum = 0;
            int second_value = 0;
            int first_value = 0;
            string replay_ans = "";

            string line_maker = "--------------------------------";
            Console.WriteLine(line_maker);
            Console.WriteLine("입력 받는 수의 합을 구하는 프로그램 V1.0");
            Console.WriteLine(line_maker);

            while (true)
            {
                Console.Write("첫번째 값을 입력해주세요. ");
                string first_num = Console.ReadLine();
                bool check_int = int.TryParse(first_num, out checksum);

                if (check_int == true)
                {
                    first_value = int.Parse(first_num);
                }

                else
                {
                    Console.WriteLine("첫번째 값(문자열이 포함 돼있습니다)을 다시 입력해주세요. ");
                    continue;
                }

                Console.Write("두번째 값을 입력해주세요. ");
                string second_num = Console.ReadLine();
                bool check_int_2 = int.TryParse(second_num, out checksum);

                if (check_int_2 == true)
                {
                    second_value = int.Parse(second_num);

                    if (first_value >= second_value)
                    {
                        while (first_value >= second_value)
                        {
                            Console.Write("Error : 두번째 값(첫번째 값보다 작아야 합니다)을 다시 입력해주세요. ");
                            second_value = int.Parse(Console.ReadLine());

                            if (first_value < second_value)
                            {
                                for (int i = first_value; i <= second_value; i++)
                                {
                                    sum += i;
                                }
                                Console.WriteLine("{0}에서 {1}까지의 합은 : {2}입니다.", first_value, second_value, sum);
                                sum = 0;
                                Console.Write("계속 하시겠습니까? (Y/N) : ");
                                replay_ans = Console.ReadLine();
                                switch (replay_ans)
                                {
                                    case "y":
                                        continue;
                                        break;

                                    case "n":
                                        break;
                                }
                            }

                            else
                            {
                                continue;
                            }
                        }
                    }

                    else if (first_value < second_value)
                    {
                        for (int i = first_value; i <= second_value; i++)
                        {
                            sum += i;
                        }

                        Console.WriteLine("{0}에서 {1}까지의 합은 : {2}입니다.", first_value, second_value, sum);
                        sum = 0;
                        Console.Write("계속 하시겠습니까? (Y/N) : ");
                        replay_ans = Console.ReadLine();
                       
                        switch (replay_ans)
                        {
                            case "y":
                                continue;
                                break;

                            case "n":
                                break;
                        }
                    }
                }

                else
                {
                    Console.WriteLine("두번째 값(문자열이 포함 돼있습니다)을 다시 입력해주세요. ");
                    continue;
                }

                if (replay_ans == "n")
                {
                    break;
                }
            }  
        }
    }
}
