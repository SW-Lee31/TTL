using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Cs_tile
{
    class Program
    {
        /*string d_zero = "00";
        string a_one = "1";*/

        static void Main(string[] args)
        {
            Console.Write("(총)타일수를 입력해주세요 : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Tile(num));
        }

        static int Tile(int num)
        {
            if (num == 0)
            {
                /*return 0; 실제 타일이 0일때는 0을 반환?*/
                return 1;
            }

            else if (num == 1)
            {
                return 1;
            }

            return Tile(num - 1) + Tile(num - 2);
        }
    }
}
