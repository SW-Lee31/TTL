using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loop0712_3
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            string make_line = "--------------------------------";

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine(make_line);
                Console.WriteLine("간단한 파일 관리 프로그램 V1.0");
                Console.WriteLine(make_line);
                Console.WriteLine("1. 파일 생성 및 쓰기");
                Console.WriteLine("2. 파일 읽기");
                Console.WriteLine();
                Console.WriteLine("3. 종료");
                Console.WriteLine(make_line);
                Console.Write("메뉴를 선택하세요. ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("파일 생성 및 쓰기 실행됩니다.");
                        break;

                    case "2":
                        Console.WriteLine("파일 읽기 실행됩니다.");
                        break;

                    case "3":
                        Console.WriteLine("프로그램이 종료됩니다.");
                        break;

                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                }

                if (choice == "3")
                {
                    break;
                }
            }
        }
    }
}
