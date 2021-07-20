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
        StreamWriter writer = new StreamWriter(@"c:\\c#_work\test_09_GUI\test.txt");
        Random ran = new Random();
        string[] name_arr = new string[50];
        string name_collection = "";
        int index = 0;
        const int INDEX_NUM = 50;

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
                        /*File.WriteAllText("text.txt", name_arr[index]);*/ // 한 번에 다 입력
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
                    Console.WriteLine("작업을 거친 파일내용입니다.");
                    for (int i = 0; i < name_arr.Length; i++)
                    {
                        Console.WriteLine("{0}번 리스트 -> {1}", (i + 1), name_arr[i]);
                    }
                    break;
                }
            }
        }

        private void name_create_button_Click(object sender, EventArgs e)
        {
            name_collection += first_name[ran.Next(9)];
            name_collection += middle_name[ran.Next(9)];
            name_collection += last_name[ran.Next(9)];
            name_arr[index] = name_collection;
            name_output.Text = name_collection + " is created";
            name_collection = "";
            /*File.WriteAllText("text.txt", name_arr[index]);*/
            index++;

            if (index > 50)
            {
                MessageBox.Show("The file is full now please delete elements");
                index = 0;
            }
        }

        private void print_button_Click(object sender, EventArgs e)
        {
            int index_search = int.Parse(print_index_input.Text);

            if (index_search == null)
            {
                MessageBox.Show("Please INPUT number which you want to search");
            }
            
            if (index_search > 50)
            {
                MessageBox.Show("Please INPUT 1 ~ 50 vlaue");
            }

            if (name_arr[index_search - 1] == null)
            {
                MessageBox.Show("The index which one you want to search is now empty");
            }

            name_output.Text = name_arr[index_search - 1];
        }

        private void drop_button_Click(object sender, EventArgs e)
        {
            int index_drop = int.Parse(drop_index_input.Text);

            if (index_drop == null)
            {
                MessageBox.Show("Please INPUT number which you want to search");
            }

            if (index_drop > 50)
            {
                MessageBox.Show("Please INPUT 1 ~ 50 vlaue");
            }

            if (name_arr[index_drop - 1] == null)
            {
                MessageBox.Show("The index which one you want to search is already empty");
            }

            name_output.Text = "\"" + name_arr[index_drop - 1] + "\"" + "is deleted";
            name_arr[index_drop - 1] = null;

            // 텍스트파일에서 자료를 읽어들인다? (배열로? -> 인덱스 활용가능) 
            // streamread 는 읽기 전용? 제한적
            // 1. 이름 생성버튼에서 바로 입력하지말고 배열만 유지 -> commit버튼 따로 생성 (solve)
            
            // 2. 인덱스 값을 삭제 이후 그 위치에 입력받기 위해? index = index_drop - 1 
            // 2. 삭제이후 무시하고 계속해서 진행? index를 건들면 안됨 
            // 2. if문으로 묶기? 버튼하나 또 생성하는 소요 발생.. ()
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to exit?");
            Application.Exit();
        }

        private void commit_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < INDEX_NUM; i++)
            {
                writer.WriteLine("{0}번 리스트 -> {1}", (i + 1), name_arr[i]);
            }
            writer.Close();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < INDEX_NUM; i++)
            {
                name_arr[i] = null;
                index = 0;
            }
            name_output.Text = "All elements are deleted";
            index = 0;
        }
    }
}
