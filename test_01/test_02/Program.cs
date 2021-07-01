using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //원의 반지름 값을 입력받아 원의 넓이를 구하는 식 작성
            
            //반지름값 입력
            Console.WriteLine("원의 반지름 값을 입력하세요.\n");
            string input_radius = Console.ReadLine();

            //반지름값 형변화 및 원주율 
            double radius = double.Parse(input_radius);
            double pi = 3.14;

            //원의 면적
            double result = radius * radius * pi;

            Console.WriteLine(result);
        }
    }
}
