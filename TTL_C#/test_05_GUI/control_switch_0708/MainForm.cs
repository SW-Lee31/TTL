using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_switch_0708
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*            char grade = 'A';

                        switch (grade)
                        {
                            case 'A':
                                Console.WriteLine("100 ~ 90점");
                                break;

                            case 'B':
                                Console.WriteLine("89 ~ 80점");
                                break;

                            case 'C':
                                Console.WriteLine("79 ~ 70점");
                                break;

                            default:
                                Console.WriteLine("69 ~ 0점");
                                break;
                        }*/

            //////////////////////////////////////////////////////////////////////

            /*            Console.Write("Month(1 ~ 12)를 입력해주세요.");
                        int month = int.Parse(Console.ReadLine());

                        switch (month)
                        {
                            case 3:
                            case 4:
                            case 5:
                                Console.WriteLine("봄입니다.");
                                break;
                            case 6:
                            case 7:
                            case 8:
                                Console.WriteLine("여름입니다.");
                                break;
                            case 9:
                            case 10:
                            case 11:
                                Console.WriteLine("가을입니다.");
                                break;
                            default:
                                Console.WriteLine("겨울입니다.");
                                break;
                        }*/

            //////////////////////////////////////////////////////////////////////

            Console.WriteLine("=================================================");
            Console.WriteLine("\t생산라인 현장 관리 프로그램");
            Console.WriteLine("=================================================");
            Console.WriteLine("1. 제품A 생산라인 가동");
            Console.WriteLine("2. 제품A 생산라인 중지");
            Console.WriteLine("3. 제품B 생산라인 가동");
            Console.WriteLine("4. 제품B 생산라인 중지");
            Console.WriteLine("5. 전 라인 생산 중지");
            Console.WriteLine("\n");
            Console.WriteLine("0. 프로그램 종료");
            Console.WriteLine("=================================================");
            
            while (true)
            {
                Console.Write("메뉴 선택 : ");
                string menu_deci = Console.ReadLine();

                switch (menu_deci)
                {
                    case "1":
                        Console.WriteLine("제품A is on manufacturing..");
                        break;

                    case "2":
                        Console.WriteLine("quit from 제품A manufacturing..");
                        break;

                    case "3":
                        Console.WriteLine("제품B is on manufacturing..");
                        break;

                    case "4":
                        Console.WriteLine("quit from 제품B manufacturing..");
                        break;

                    case "5":
                        Console.WriteLine("All process is stop");
                        break;

                    case "0":
                        break;

                    default:
                        Console.WriteLine("\nWarning : input number in menu_num(0 ~ 5)");
                        break;
                }

                if (menu_deci == "0")
                {
                    break;
                }
            }

            



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
