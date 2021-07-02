using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_03
{
    class Class1
    {
        public void input_task()
        {
            //원의 면적 구하기
            const double PI = 3.14;

            Console.WriteLine("원의 면적을 구하는 식입니다.");
            Console.Write("반지름 값을 입력해주세요. -> ");
            double radius = double.Parse(Console.ReadLine());
            double result = radius * radius * PI;
            Console.WriteLine("\n");
            Console.WriteLine("원의 면적은 " + result + "입니다.\n");
        }
            
        public void input_task_2()
        { 
            //성적표
            Console.Write("국어점수를 입력하세요. -> ");
            int korean = int.Parse(Console.ReadLine());
            Console.Write("영어점수를 입력하세요. -> ");
            int english = int.Parse(Console.ReadLine());
            Console.Write("수학점수를 입력하세요. -> ");
            int math = int.Parse(Console.ReadLine());
            Console.Write("과학점수를 입력하세요. -> ");
            int science = int.Parse(Console.ReadLine());
            
            int sum = korean + english + math + science;
            double average = (korean + english + math + science) / 4;

            Console.WriteLine("점수의 총합은 : " + sum);
            Console.WriteLine("점수의 평균은 : " + average);
        }

        public void input_task_3()
        { 
            //온도 섭씨화 
            Console.Write("변화하고 싶은 화씨온도를 입력해 주세요. -> ");
            double f_temp = double.Parse(Console.ReadLine());
            double c_temp = (f_temp - 32) / 1.8;

            Console.WriteLine("입력하신 섭씨온도({0}℉)를 화씨 온도로 변경하면 ({1}℃)입니다.", f_temp, c_temp);
        }
    }
}
