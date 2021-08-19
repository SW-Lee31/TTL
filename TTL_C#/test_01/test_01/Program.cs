using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_0701_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = "Lee sangwon";

            int age;
            age = 27;

            string phone_num;
            phone_num = "010-6291-9710";

            string sex;
            sex = "male";

            string address;
            address = "대구시 수성구 동원로 110, 301동 307호";

            double height;
            height = 185.5;

            double weight;
            weight = 115.5;

            string email;
            email = "sangwon3232@naver.com";

            string line_change;
            line_change = "\n";

            //Console.Write("이름 :  " + name + line_change + "나이 : " + age + line_change + "전화번호 : " + phone_num + line_change + "주소 : " + address + line_change + "키 : " + height + line_change + "몸무게 : " + weight + line_change + "이메일 : " + email + line_change);

            Console.WriteLine("이름 : " + name);
            Console.WriteLine("나이 : " + age);
            Console.WriteLine("전화번호 : " + phone_num);
            Console.WriteLine("성별 : " + sex);
            Console.WriteLine("주소 : " + address);
            Console.WriteLine("키 : " + height);
            Console.WriteLine("몸무게 : " + weight);
            Console.WriteLine("이메일 : " + email);
            Console.WriteLine("=====================================");

            string company_name;
            company_name = "삼성";

            string team;
            team = "영업부";

            string level;
            level = "과장";

            string employee_name;
            employee_name = "홍길동";

            int payment;
            payment = 4500000;

            int employee_age;
            employee_age = 32;

            string employee_id;
            employee_id = "abcdefg";

            Console.WriteLine(line_change);
            Console.WriteLine("\t <직원상세정보>");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("회사명 : " + company_name);
            Console.WriteLine("부서 : " + team);
            Console.WriteLine("직급 : " + level);
            Console.WriteLine("사원명 : " + employee_name);
            Console.WriteLine("월급여 : " + payment);
            Console.WriteLine("사원나이 : " + employee_age);
            Console.WriteLine("직원아이디 : " + employee_id);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(line_change);

            Console.WriteLine("이름을 입력하세요\n");
            string input_name = Console.ReadLine();
            Console.WriteLine(line_change);
            Console.WriteLine("나이를 입력하세요\n");
            Console.WriteLine(line_change);
            string input_age = Console.ReadLine();

            Console.WriteLine(line_change);
            Console.WriteLine("이름은 " + input_name + "이고 나이는 " + input_age + "입니다\n");

        }
    }
}
