using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Cs_triangle
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            Console.Write("삼각형의 크기를 지정해주세요 : ");
            int tri_size = int.Parse(Console.ReadLine());

            int[][] final_tri =  make_triangle(tri_size);

            for (int i = 0; i < final_tri.Length; i++)
            {
                for (int j = 0; j < final_tri[i].Length; j++)
                {
                    Console.Write("triangle[{0}][{1}] = {2}  ", i, j, final_tri[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine(max(final_tri));

        }

        int[][] make_triangle(int tri_size)
        {
            int[][] final_tri = new int[tri_size][];
            
            for (int i = 0; i < final_tri.Length; i++)
            {
                final_tri[i] = new int[i + 1];
            }

            for (int i = 0; i < final_tri.Length; i++)
            {
                for (int j = 0; j < final_tri[i].Length; j++)
                {
                    Console.Write("삼각형의 값을 입력 : triangle[{0}][{1}]", i, j);
                    int input_num = int.Parse(Console.ReadLine());
                    final_tri[i][j] = input_num;
                }

            }

            return final_tri;
        }

        int max(int[][] final_tri)
        {
            int temp = final_tri[0][0];

            for (int i = 1; i < final_tri.Length; i++)
            {
                for (int j = 0; j < final_tri[i - 1].Length; j++)
                {
                    if (temp + final_tri[i][j] > temp + final_tri[i][j + 1])
                    {
                        temp += final_tri[i][j];
                    }

                    else
                    {
                        temp += final_tri[i][j + 1];
                        j++;
                    }
                }
            }

            return temp;
        }


    }
}
