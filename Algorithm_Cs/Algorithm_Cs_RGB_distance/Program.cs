using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Cs_RGB_distance
{
    class Program
    {
        const int COLOR_NUM = 3;

        static void Main(string[] args)
        {
            Console.Write("집의 개수를 입력하세요 : ");
            int house_num = int.Parse(Console.ReadLine());
            int[][] input_arr = Input_arr(house_num);
            int compare_result = input_arr[0][0];
            int compare_sum = 0;

            for (int i = 0; i < input_arr.Length; i++)
            {
                
                for (int j = 0; j < input_arr[i].Length; j++)
                {
                    int loop = input_arr[i][j];

                    if (loop < compare_result)
                    {
                        compare_result = loop;
                        compare_sum += compare_result;
                    }
                }
            }

            Console.WriteLine(compare_result);
            Console.WriteLine(compare_sum);




        }

        static int[][] Input_arr(int house_num)
        {
            int red = 0;
            int green = 0;
            int blue = 0;

            int[][] input_arr = new int[house_num][];

            for (int i = 0; i < COLOR_NUM; i++)
            {
                Console.Write("{0}번째 집의 RED색의 가격을 입력해주세요 : ", (i + 1));
                red = int.Parse(Console.ReadLine());
                Console.Write("{0}번째 집의 GREEN색의 가격을 입력해주세요 : ", (i + 1));
                green = int.Parse(Console.ReadLine());
                Console.Write("{0}번째 집의 BLUE색의 가격을 입력해주세요 : ", (i + 1));
                blue = int.Parse(Console.ReadLine());

                for (int j = 0; j < house_num; j++)
                {
                    input_arr[i] = new int[]
                    {
                        red, green, blue
                    };
                }
                Console.WriteLine();
            }

            return input_arr;
        }
    }
}
