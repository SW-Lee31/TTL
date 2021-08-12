using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View_structure_0811.Model
{
    class Person
    {
        string name;
        string digit;
        string addr;
        string date;
        string gender;

        public Person(string name, string digit, string addr, string date, string gender)
        {
            this.name = name;
            this.digit = digit;
            this.addr = addr;
            this.date = date;
            this.gender = gender;
        }

        public string Name { get => name; set => name = value; }
        public string Digit { get => digit; set => digit = value; }
        public string Addr { get => addr; set => addr = value; }
        public string Date { get => date; set => date = value; }
        public string Gender { get => gender; set => gender = value; }

        public void print_personal_info()
        {
            Console.WriteLine("이름 : {0}", name);
            Console.WriteLine("전화번호 : {0}", digit);
            Console.WriteLine("주소 : {0}", addr);
            Console.WriteLine("가입날짜 : {0}", date);
            Console.WriteLine("성별 : {0}", gender);
        }
    }
}
