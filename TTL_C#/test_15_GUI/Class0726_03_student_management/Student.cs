using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0726_03_student_management
{
    class Student
    {
        private string name;
        private int age;
        private char gender;
        private string address;

        public Student(string name, int age, char gender, string address)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public char Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }

        public override string ToString()
        {
            string show_data = "학생이름 : " + name + "\n";
            show_data += "학생나이 : " + age + "\n";
            show_data += "학생성별 : " + gender + "\n";
            show_data += "학생주소 : " + address + "\n";
            return show_data;
        }
    }
}
