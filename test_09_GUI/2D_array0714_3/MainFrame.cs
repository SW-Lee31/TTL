using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2D_array0714_3
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
            /*string path = @"C:\c#_work\file_management.txt";
            StreamWriter writer;*/

            // 파일 제어 프로그램 // 
            Console.WriteLine();
            Console.WriteLine("#########################파일 제어 프로그램########################");
            Console.WriteLine();

            string[] name_arr = new string[50];
            string name_collection = "";
            int index = 0;

            string[] first_name = new string[]
            {
                "김", "박", "이", "최", "장", "정", "심", "황", "양"
            };

            string[] middle_name = new string[]
            {
                "상", "준", "희", "건", "정", "제", "창", "건", "호"
            };

            string[] last_name = new string[]
            {
                "원", "혁", "환", "윤", "훈", "진", "헌", "현", "영"
            };

            /*name_collection += first_name[ran.Next(4)];
            name_collection += middle_name[ran.Next(4)];
            name_collection += last_name[ran.Next(4)];
            Console.WriteLine(name_collection);*/
            Console.WriteLine("------------------------------------");
            Console.WriteLine("      파일 제어 프로그램 V1.1");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1 : 이름 생성하여 파일에 저장하기");
            Console.WriteLine("2 : 파일에서 이름 읽어오기");
            Console.WriteLine("3 : 파일 내 데이터 제거하기");
            Console.WriteLine("4 : 프로그램 종료");
            Console.WriteLine("------------------------------------");

            while (true)
            {
                Console.Write("메뉴 선택 : ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        name_collection += first_name[ran.Next(9)];
                        name_collection += middle_name[ran.Next(9)];
                        name_collection += last_name[ran.Next(9)];
                        name_arr[index] = name_collection;
                        name_collection = "";
                        Console.WriteLine("\n Notice : \"{0}\"의 이름이 파일에 저장 되었습니다.\n", name_arr[index]);
                        index++;

                        if (index >= 50)
                        {
                            Console.WriteLine("\n Warning : 파일 내 공간이 다 사용 중입니다.\n 3번 옵션으로 파일을 비워주세요. \n");
                            if (choice != 3)
                            {
                                Console.WriteLine("\n Warning : 파일 내 공간이 다 사용 중입니다.\n 3번 옵션으로 파일을 비워주세요. \n");
                                continue;
                            }
                        }
                        break;

                    case 2:
                        Console.Write("\n리스트 내 몇번째 이름을 출력하고 싶으십니까? : ");
                        int name_select = int.Parse(Console.ReadLine());
                        
                        if (name_arr[name_select - 1] == "")
                        {
                            Console.WriteLine("\n Warning : 아직 등록되지 않은 번호입니다.\n");
                        }

                        else
                        {
                            name_collection = name_arr[name_select - 1];
                            Console.WriteLine(name_collection);
                            name_select = 0;
                        }

                        break;

                    case 3:
                        Console.Write("\n리스트 내 몇번째 이름을 제거하고 싶으십니까? : ");
                        name_select = int.Parse(Console.ReadLine());
                        name_arr[name_select - 1] = "";
                        for (int i = 0; i < name_arr.Length; i++)
                        {
                            Console.Write("\n제거작업을 거친 파일내용입니다. : {0}번 메모리 -> {1}", (i + 1), name_arr[i]);
                        }
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("메뉴 옵션 1 ~ 4 까지 중의 수를 입력해주세요.");
                        break;
                }

                if (choice == 4)
                {
                    for (int i = 0; i < name_arr.Length; i++)
                    {
                        Console.WriteLine("작업을 거친 파일내용입니다. : {0}번 메모리 -> {1}", (i + 1), name_arr[i]);
                    }
                    break;
                }
            }
        }
    }
}
