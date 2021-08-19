using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_array0714
{
    public partial class MainFrame : Form
    {
        const int ROW = 2;
        const int COL = 3;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            /////////////////// 2차원 배열_1 ///////////////////
            Console.WriteLine("\n이차원배열을 선언\n");
            int[,] arr_int =
            {
                {1, 2, 3 }, // ㅡ▶ 행(동)
                {4, 5, 6 },
                {7, 8, 9 },
                {1, 4, 0 }
                // ㅣ
                // ▼
                // 열(호)
            };

            int[,] arr_int_4 = new int[ROW, COL];

            Console.WriteLine("이차원배열의 행의 크기 : " + arr_int_4.GetLength(0));
            Console.WriteLine("이차원배열의 열의 크기 : " + arr_int_4.GetLength(1));

            /////////////// 크기가 정해진(명시) 경우는 .GetLength 사용 ///////////////
            ///////////// 크기가 아직 정해지지 않은 경우는 .Length 사용 //////////////

            Console.WriteLine(arr_int.Length);

            // 행 출력
            for (int i = 0; i < arr_int.GetLength(0); i++)
            {
                // 열 출력
                for (int j = 0; j < arr_int.GetLength(1); j++)
                {
                    Console.Write(arr_int[i, j] + " ");
                }
                Console.WriteLine();
            }

            /////////////// 2차원 배열_2 (빈 값 생성) //////////////
            Console.WriteLine("\n빈행에 열을 삽입하는 이차원배열 선언\n");
            int[][] arr_int2 = new int[4][]; // 행의 크기만(동) 설정가능

            Console.WriteLine("이차원배열의 크기 : " + arr_int2.Length);
            Console.WriteLine("이차원배열의 행의 크기 : " + arr_int2.GetLength(0));
            int sum = 100;

            for (int i = 0; i < arr_int2.GetLength(0); i++)
            {
                // 각 행에 열을 생성
                arr_int2[i] = new int[3]; /*Console.WriteLine("각 행에 열크기\"{0}\" 삽입", arr_int2[i].Length);*/

                for (int j = 0; j < arr_int2[i].Length; j++)
                {
                    arr_int2[i][j] = sum++;
                    Console.Write(arr_int2[i][j] + " ");
                }
                Console.WriteLine();
            }

                        /*Console.WriteLine("arr_int2 이차원배열의 열의 크기 : " + arr_int2.GetLength(1));*/

            /////////////// 2차원 배열_3 (가변적 생성) //////////////
            Console.WriteLine("\n가변적 이차원배열 선언\n");
            string[][] arr_name = new string[4][];
            arr_name[0] = new string[]
            {
                "김길동", "홍길동", "박길동", "유길동"
            };

            arr_name[1] = new string[]
            {
                "최길동", "피길동", "장길동"
            };

            arr_name[2] = new string[]
            {
                "이길동", "황길동"
            };

            arr_name[3] = new string[1];

            Console.WriteLine("arr_name 행의 길이 " + arr_name.GetLength(0));
/*            Console.WriteLine("arr_name 열의 길이" + arr_name.GetLength(1));*/

            for (int i = 0; i < arr_name.GetLength(0); i++)
            {
                for (int j = 0; j < arr_name[i].GetLength(0); j++)
                {
                    Console.Write("arr_name[{0}][{1}] = {2}  ", i, j, arr_name[i][j]);
                }
                Console.WriteLine();
            }

            /////////////// foreach 반복문 //////////////
            string[] arr_fruit = new string[4]
            {
                "사과", "배", "바나나", "딸기"
            };

            Console.WriteLine("\nforeach를 활용한 요소 출력\n");
            foreach (var elements in arr_fruit)
            {
                Console.WriteLine(elements);
            }

            Console.WriteLine("\nfor을 활용한 요소 출력\n");
            for (int elements = 0; elements < arr_fruit.Length; elements++)
            {
                Console.WriteLine(arr_fruit[elements]);
            }


        }
    }
}
