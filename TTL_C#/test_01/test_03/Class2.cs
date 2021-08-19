using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_03
{
    class Class2
    {
        public void person_record()
        {
            string line_maker = "=========================================";
            string br = "\n";

            Console.WriteLine("당신의 이름은 : ");
            string en_name = Console.ReadLine();
            Console.WriteLine("당신의 나이는 : ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("당신의 생년월일은 : ");
            int birth = int.Parse(Console.ReadLine());
            Console.WriteLine("당신의 전화번호는 : ");
            string p_num = Console.ReadLine();
            Console.WriteLine("당신의 주소는 : ");
            string address = Console.ReadLine();
            Console.WriteLine("당신의 키는 : ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("당신의 몸무게는  : ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("당신의 이메일은 : ");
            string email = Console.ReadLine();



            Console.WriteLine(br);
            Console.WriteLine(line_maker);
            Console.WriteLine("당신의 이름은 : " + en_name);
            Console.WriteLine("당신의 나이는 : " + age);
            Console.WriteLine("당신의 생년월일은 : " + birth);
            Console.WriteLine("당신의 전화번호는 : " + p_num);
            Console.WriteLine("당신의 주소는 : " + address);
            Console.WriteLine("당신의 키는 : " + height);
            Console.WriteLine("당신의 몸무게는  : " + weight);
            Console.WriteLine("당신의 이메일은 : " + email);
            Console.WriteLine(line_maker);
            Console.WriteLine(br);

        }
    }
}
