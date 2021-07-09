using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch0709
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("식당 메뉴 자동 프로그램 V1.0.1");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("\n");
            Console.WriteLine("원하시는 식사 메뉴를 입력하시오.");
            Console.WriteLine("A. 김치찌개 : 5000원");
            Console.WriteLine("B. 된장찌개 : 5000원");
            Console.WriteLine("C. 칼국수 : 4500원");
            Console.WriteLine("D. 잔치국수 : 4000원");
            Console.WriteLine("E. 비빔밥 : 5000원");
            Console.WriteLine("\n");
            Console.WriteLine("F. 프로그램 종료");

            while (true)
            {
                Console.Write("메뉴 선택 : ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "A":
                        Console.WriteLine("\n");
                        Console.WriteLine("##############################");
                        Console.WriteLine("# 김치찌개를 선택하셨습니다. #");
                        Console.WriteLine("#    가격은 5000원입니다     #");
                        Console.WriteLine("#############################");
                        Console.WriteLine("\n");
                        break;

                    case "B":
                        Console.WriteLine("\n");
                        Console.WriteLine("##############################");
                        Console.WriteLine("# 된장찌개를 선택하셨습니다. #");
                        Console.WriteLine("#    가격은 5000원입니다     #");
                        Console.WriteLine("#############################");
                        Console.WriteLine("\n");
                        break;

                    case "C":
                        Console.WriteLine("\n");
                        Console.WriteLine("##############################");
                        Console.WriteLine("#  칼국수를 선택하셨습니다.  #");
                        Console.WriteLine("#    가격은 4500원입니다     #");
                        Console.WriteLine("#############################");
                        Console.WriteLine("\n");
                        break;

                    case "D":
                        Console.WriteLine("\n");
                        Console.WriteLine("##############################");
                        Console.WriteLine("# 잔치국수를 선택하셨습니다. #");
                        Console.WriteLine("#    가격은 4000원입니다     #");
                        Console.WriteLine("#############################");
                        Console.WriteLine("\n");
                        break;


                    case "E":
                        Console.WriteLine("\n");
                        Console.WriteLine("##############################");
                        Console.WriteLine("#  비빔밥을 선택하셨습니다.  #");
                        Console.WriteLine("#    가격은 5000원입니다     #");
                        Console.WriteLine("#############################");
                        Console.WriteLine("\n");
                        break;

                    case "F":
                        break;

                    default:
                        Console.WriteLine("메뉴 (A ~ E)중 선택하세요.");
                        Console.WriteLine("\n");
                        break;
                }
                
                if (choice == "F")
                {
                    break;
                }
            }

        }
    }
}
