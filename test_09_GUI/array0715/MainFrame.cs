using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array0715
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("              가변 이차원배열");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");

            int[][] arr_2d = new int[6][];

            arr_2d[0] = new int[]
            {
                1, 2
            };

            arr_2d[1] = new int[]
            {
                2, 4, 6
            };

            arr_2d[2] = new int[5];

            arr_2d[3] = new int[]
            {
                3, 6
            };

            arr_2d[4] = new int[]
            {
                4, 8, 10, 12
            };

            arr_2d[5] = new int[]
            {
                10
            };


            for (int i = 0; i < arr_2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr_2d[i].GetLength(0); j++)
                {
                    Console.Write("arr[{0}][{1}] = {2}  ", i, j, arr_2d[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("              행렬의 덧셈");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("\nint[,] arr_result (콤마활용)\n");
            int[,] arr_result = new int[3, 3];

            int[,] arr_1 = new int[3, 3]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            int[,] arr_2 = new int[3, 3]
            {
                {10, 20, 30},
                {40, 50, 60},
                {70, 80, 90}
            };

            for (int i = 0; i < arr_1.GetLength(0); i++)
            {
                for (int j = 0; j < arr_1.GetLength(1); j++)
                {
                    arr_result[i, j] = arr_1[i, j] + arr_2[i, j];
                    Console.Write(arr_result[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nint[][] arr_result (대괄호 활용)\n");
            int[][] arr_result_a = new int[3][];
            int[][] arr_1_a = new int[3][];
            int[][] arr_2_a = new int[3][];

            arr_1_a[0] = new int[]
            {
                1, 2, 3
            };

            arr_1_a[1] = new int[]
            {
                4, 5, 6
            };

            arr_1_a[2] = new int[]
            {
                7, 8, 9
            };


            arr_2_a[0] = new int[]
            {
                10, 20, 30
            };

            arr_2_a[1] = new int[]
            {
                40, 50, 60
            };

            arr_2_a[2] = new int[]
            {
                70, 80, 90
            };


            arr_result_a[0] = new int[]
            {
                arr_1_a[0][0] + arr_2_a[0][0], arr_1_a[0][1] + arr_2_a[0][1], arr_1_a[0][2] + arr_2_a[0][2]
            };

            arr_result_a[1] = new int[]
            {
                arr_1_a[1][0] + arr_2_a[1][0], arr_1_a[1][1] + arr_2_a[1][1], arr_1_a[1][2] + arr_2_a[1][2]
            };

            arr_result_a[2] = new int[]
            {
                arr_1_a[2][0] + arr_2_a[2][0], arr_1_a[2][1] + arr_2_a[2][1], arr_1_a[2][2] + arr_2_a[2][2]
            };

            for (int i = 0; i < arr_result_a.GetLength(0); i++)
            {
                for (int j = 0; j < arr_result_a[i].GetLength(0); j++)
                {
                    Console.Write(arr_result_a[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("              행렬 곱하기 2X9");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");
            const int ROW = 9;
            const int COL = 8;

            int[,] arr_multi = new int[ROW, COL];

            for (int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COL; j++)
                {
                    arr_multi[i, j] = (i + 1) * (j + 2);
                    Console.Write("{0} X {1} = {2}\t", (j + 2), (i + 1), arr_multi[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
