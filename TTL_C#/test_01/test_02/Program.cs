using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*const double PI = 3.14*/

namespace test_02
{
    class Program
    {
        /*double PI = 3.14;*/

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

            Console.WriteLine("\n==============================================================");

            //성적표 구하기
            Console.WriteLine("\t성적표구하기");
            int korean = 90;
            /*Console.WriteLine(korean);*/
            int english = 80;
            /*Console.WriteLine(english);*/
            int math = 70;
            /*Console.WriteLine(math);*/
            int science = 60;
            /*Console.WriteLine(science);*/

            //평균, 총점
            int sum = korean + english + math + science;
            double average = (korean + english + math + science) / 4;
            Console.WriteLine("국어점수 : " + korean + "영어점수 : " + english + "수학점수  : " + math + "과학점수 : " + science);
            Console.WriteLine("점수합계 : " + sum + "\n" + "점수평균 : " + average);


            Console.WriteLine("\n==============================================================");


            //온도구하기
            Console.WriteLine("\t온도구하기");
            string temperature_f = Console.ReadLine();
            double temp_f = double.Parse(temperature_f);
            double temperatue_c = (temp_f - 32) / 1.8;
            Console.WriteLine((int)temperatue_c);


            Console.WriteLine("\n==============================================================");

            //스캐너
            Console.WriteLine("\t성적산출");
            string korean_input = Console.ReadLine();
            string english_input = Console.ReadLine();
            string math_input = Console.ReadLine();
            string science_input = Console.ReadLine();

            int kor = int.Parse(korean_input);
            int eng = int.Parse(english_input);
            int mat = int.Parse(math_input);
            int sci = int.Parse(science_input);

            int sum_2 = kor + eng + mat + sci;
            double average_2 = (kor + eng + mat + sci) / 4;

            Console.WriteLine("점수합산 : " + sum_2 + "\n" + "점수평균 : " + average_2);
 
        }
    }
}
