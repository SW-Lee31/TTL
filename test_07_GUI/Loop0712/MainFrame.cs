using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loop0712
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            // for문
            int[] arr;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("for 반복문 실행 문장 : {0}", i);
            }

            for (int j = 10; j > 0; j--)
            {
                Console.WriteLine("for 반복문 실행 문장 : {0}", j);
            }

            // while문
            int while_index = 0;
            while (while_index < 10)
            {
                Console.WriteLine("while 반복문 실행 문장 : {0}", while_index);
                while_index++;
            }

            Console.WriteLine("while_index 의 값은 while문을 벗어난 현재 : {0}입니다.", while_index);

            while (while_index > 0)
            {
                Console.WriteLine("while 반복문 실행 문장 : {0}", while_index);
                while_index--;
            }

            // do-while문
            do
            {
                Console.WriteLine("do-while 반복문 실행 문장 : {0}", while_index);
                while_index++;
            } while (while_index < 10);

            do
            {
                Console.WriteLine("do-while 반복문 실행 문장 : {0}", while_index);
                while_index--;
            } while (while_index > 0);


                        //#############################################
                        //########## 반복문 -> 합 누적처리 #############
                        //#############################################
            int result = 0;
            for (int i = 0; i < 11; i++)
            {
                result += i;
            }
            Console.WriteLine("for에서의 합 누적 : " + result);

            result = 0;
            int index = 0;
            while (index <= 10)
            {
                result += index;
                index++;
            }
            Console.WriteLine("while에서의 합 누적 : " + result);

            result = 0;
            index = 0;
            do
            {
                result += index;
                index++;
            } while (index <= 10);
            Console.WriteLine("do-while에서의 합 누적 : " + result);

                        //###############################################
                        //############## Infinite Loop ##################
                        //###############################################

            while (true)
            {
                Console.WriteLine("Process is on Infinite Loop...");
                if (Console.ReadLine() == "0")
                {
                    break;
                }
            }

            int count = 0;
            while (true)
            {
                Console.WriteLine("Process is on Infinite Loop on count : " + (count + 1));
                if (count == 99)
                {
                    break;
                }
                count++;
            }

                        //###############################################
                        //######### 1 ~ 10중 홀, 짝수 출력 ###############
                        //###############################################
            for (int i = 0; i < 11; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("0은 값에서 제외하겠습니다.");
                    continue;
                }
                
                else if (i % 2 == 0)
                {
                    Console.WriteLine("{0}(은)는 짝수입니다.", i);
                }

                else
                {
                    Console.WriteLine("{0}(은)는 홀수입니다.", i);
                }
            }

            index = 0;
            while (index < 11)
            {
                if (index == 0)
                {
                    Console.WriteLine("0은 값에서 제외하겠습니다.");
                    index++;
                    continue;
                }

                else if (index % 2 == 0)
                {
                    Console.WriteLine("{0}(은)는 짝수입니다.", index);
                }

                else
                {
                    Console.WriteLine("{0}(은)는 홀수입니다.", index);
                }

                index++;
            }

            index = 0;
            do
            {
                if (index == 0)
                {
                    Console.WriteLine("0은 값에서 제외하겠습니다.");
                    index++;
                    continue;
                }

                else if (index % 2 == 0)
                {
                    Console.WriteLine("{0}(은)는 짝수입니다.", index);
                }

                else
                {
                    Console.WriteLine("{0}(은)는 홀수입니다.", index);
                }

                index++;
            } while (index < 11);

                        //###############################################
                        //######### 무한반복문 활용 메뉴출력 ##############
                        //###############################################

            string line_maker = "###########################################";

                Console.WriteLine();
                Console.WriteLine(line_maker);
                Console.WriteLine("Console Menu Program");
                Console.WriteLine(line_maker);
                Console.WriteLine("1 : manufacturing device 'A'");
                Console.WriteLine("2 : manufacturing device 'B'");
                Console.WriteLine("3 : manufacturing device 'C'");
                Console.WriteLine("4 : manufacturing device 'D'");
                Console.WriteLine("5 : Stop manufacturing process device 'A'");
                Console.WriteLine("6 : Stop manufacturing process device 'B'");
                Console.WriteLine("7 : Stop manufacturing process device 'C'");
                Console.WriteLine("8 : Stop manufacturing process device 'D'");
                Console.WriteLine("9 : Stop all process");
                Console.WriteLine(line_maker);
                Console.WriteLine("0 : Quit the program");
                Console.WriteLine();



            while (1 > 0)
            {
                Console.WriteLine();
                Console.Write("Choose the Action : ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("'A' device is on manufacturing");
                        break;

                    case 2:
                        Console.WriteLine("'B' device is on manufacturing");
                        break;

                    case 3:
                        Console.WriteLine("'C' device is on manufacturing");
                        break;

                    case 4:
                        Console.WriteLine("'D' device is on manufacturing");
                        break;

                    case 5:
                        Console.WriteLine("'A' device is out of manufacturing");
                        break;

                    case 6:
                        Console.WriteLine("'B' device is out of manufacturing");
                        break;

                    case 7:
                        Console.WriteLine("'C' device is out of manufacturing");
                        break;

                    case 8:
                        Console.WriteLine("'D' device is out of manufacturing");
                        break;

                    case 9:
                        Console.WriteLine("all process is out of manufacturing");
                        break;

                    case 0:
                        /*Environment.Exit(0);*/
                        break;
                }
                if (choice == 0)
                {
                    break;
                }
            }

                        //###############################################
                        //############ 이중 반복문(구구단) ###############
                        //###############################################
            for (int i = 2; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    string str = string.Format("{0} X {1} = {2}", i, j, (i * j));
                    Console.Write(str + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("################## 9 X 3방식 표기##################");
            Console.WriteLine();
            for (int i = 2; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    string str = string.Format("{1} X {0} = {2}", i, j, (i * j));
                    Console.Write(str + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("################## while 실행##################");
            Console.WriteLine();
            
            int index_1 = 2;
            int index_2 = 2;
            
            while (index_1 <= 9)
            {
                while (index_2 <= 9)
                {
                    string str = string.Format("{0} X {1} = {2}", index_2, index_1, (index_1 * index_2));
                    Console.Write(str + "\t");
                    index_2++;
                }
                Console.WriteLine();
                index_1++;
                index_2 = 2;
            }

            Console.WriteLine();
            Console.WriteLine("################## do-while 실행##################");
            Console.WriteLine();
            index_1 = 2;
            index_2 = 2;

            while (index_1 <= 9)
            {
                do
                {
                    string str = string.Format("{0} X {1} = {2}", index_2, index_1, (index_1 * index_2));
                    Console.Write(str + "\t");
                    index_2++;
                } while (index_2 <= 9);
                Console.WriteLine();
                index_1++;
                index_2 = 2;
            }



            
        }
    }
}
