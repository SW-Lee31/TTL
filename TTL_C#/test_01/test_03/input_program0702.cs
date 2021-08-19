using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_03
{
    class input_program0702
    {

        static void Main(string[] args)
        {
            Class1 input_t = new Class1();

            Class2 input_r = new Class2();

            Class3 input_x = new Class3();

            string line = "===========================================";
            string br = "\n";

            /*//입력
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();
            Console.Write("당신의 이름은 " + name + "\n");

            Console.Write("숫자 2개를 입력해주세요. ");
            string num__1 = Console.ReadLine();
            string num__2 = Console.ReadLine();
            int num_1 = int.Parse(num__1);
            int num_2 = int.Parse(num__2);
            Console.WriteLine("두 수의 합은 : " + (num_1 + num_2));

            //입력에서의 형변환
            Console.Write("숫자3 입력 : ");
            int num_3 = int.Parse(Console.ReadLine());
            int num_4 = int.Parse(Console.ReadLine());
            Console.WriteLine("두 수의 합은 : " + (num_3 + num_4));*/

            while (true)
            {
                Console.WriteLine(br);
                Console.WriteLine(line);
                Console.WriteLine("원하는 작업을 입력해주세요.\n 1 : 원의 넓이 구하기 \n 2 : 성적표 산출 \n 3 : 섭씨화온도구하기 \n 4 : 인적사항 입력 \n 5 : 차량 부품 입고프로그램 \n \n 0 : 프로그램 종료");
                Console.WriteLine(line);
                int call = int.Parse(Console.ReadLine());
                Console.WriteLine(line);

                switch (call)
                {
                    case 1:
                        input_t.input_task();
                        Console.WriteLine(line);
                        break;

                    case 2:
                        input_t.input_task_2();
                        Console.WriteLine(line);
                        break;

                    case 3:
                        input_t.input_task_3();
                        Console.WriteLine(line);
                        break;

                    case 4:
                        input_r.person_record();
                        Console.WriteLine(line);
                        break;

                    case 5:
                        input_x.car_salary();
                        Console.WriteLine(line);
                        break;
                }
                if (call > 5)
                {
                    Console.WriteLine("0 ~ 4 까지의 값을 입력하세요."); 
                } 
                
                else if (call == 0)
                {
                    break;
                }
            }
        }
    }
}
