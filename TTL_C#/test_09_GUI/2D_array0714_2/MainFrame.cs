using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_array0714_2
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
            // 가변 이차원 배열 생성, 출력 //
            int[][] arr_int = new int[5][];

            arr_int[0] = new int[]
            {
                1, 2
            };

            arr_int[1] = new int[]
            {
                2, 4, 6
            };

            arr_int[2] = new int[]
            {
                3, 6
            };

            arr_int[3] = new int[]
            {
                4, 8, 10, 12
            };

            arr_int[4] = new int[]
            {
                10
            };

            for (int i = 0; i < arr_int.GetLength(0); i++)
            {
                for (int j = 0; j < arr_int[i].GetLength(0); j++)
                {
                    Console.Write("arr_int[{0}][{1}] = {2}  ", i, j, arr_int[i][j]);
                }
                Console.WriteLine();
            }

            // 행렬의 덧셈 구하기 // 
            Console.WriteLine();
            Console.WriteLine("###########################행렬의 덧셈 구하기###########################");
            Console.WriteLine();

            int[][] arr_int_1 = new int[3][];
            int[][] arr_int_2 = new int[3][];
            int[,] arr_int_result = new int[3, 3];

            arr_int_1[0] = new int[]
            {
                1, 2, 3
            };

            arr_int_1[1] = new int[]
            {
                4, 5, 6
            };

            arr_int_1[2] = new int[]
            {
                7, 8, 9
            };


            arr_int_2[0] = new int[]
            {
                10, 20, 30
            };

            arr_int_2[1] = new int[]
            {
                40, 50, 60
            };

            arr_int_2[2] = new int[]
            {
                70, 80, 90
            };

            for (int i = 0; i < arr_int_1.GetLength(0); i++)
            {
                for (int j = 0; j < arr_int_1[i].GetLength(0); j++)
                {
                    arr_int_result[i,j] = arr_int_1[i][j] + arr_int_2[i][j];
                    Console.Write(arr_int_result[i,j] + " ");
                }
                Console.WriteLine();
            }
            
            // 구구단 이차배열 // 
            Console.WriteLine();
            Console.WriteLine("#########################구구단 이차배열에 저장하기########################");
            Console.WriteLine();

            int[,] arr_multi = new int[9, 8];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    arr_multi[i, j] = (i + 1) * (j + 2);
                    Console.Write("{0} X {1} = {2}\t", (j + 2), (i + 1), arr_multi[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
