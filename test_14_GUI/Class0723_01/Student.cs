using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0723_01
{
    class Student
    {
        private string name;
        private string gender;
        private int age;
        private string p_num;
        private string addr;

        public Student(string name, string gender, int age, string p_num, string addr)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.p_num = p_num;
            this.addr = addr;
        }

        public void set_name(string name)
        {
            this.name = name;
        }

        public string get_name()
        {
            return name;
        }

        public void show_info()
        {
            Console.WriteLine("#############################");
            Console.WriteLine("이름 : {0}\t성별 : {1}\t나이 : {2}", name, gender, age);
            Console.WriteLine("전화번호 : {0}\t주소 : {1}", p_num, addr);
            Console.WriteLine("#############################");
        }
    }
}
