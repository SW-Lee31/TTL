using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Cs_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fibonacci(4));
        }

        static int fibonacci(int num)
        {
            if (num < 3)
            {
                return 1;
            }

            return fibonacci(num - 1) + fibonacci(num - 2);
        }
    }
}
