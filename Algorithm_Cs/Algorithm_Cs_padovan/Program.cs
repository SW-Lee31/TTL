using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Cs_padovan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("P( ) 안의 수를 입력해주세요. ");
            int input_num = int.Parse(Console.ReadLine());
            Console.WriteLine(Padovan(input_num));
        }

        static int Padovan(int input_num)
        {
            if (input_num <= 3)
            {
                return 1;
            }

            return Padovan(input_num - 2) + Padovan(input_num - 3);
        }
    }
}
