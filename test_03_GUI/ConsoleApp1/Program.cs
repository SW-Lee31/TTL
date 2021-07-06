using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 100;
            Console.WriteLine(a);
            a = a % 3;
            b %= 3;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
