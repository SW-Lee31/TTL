using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0727_03_Winform.Model
{
    class Customer
    {
        private string name;
        private string digit;
        private string addr;
        private string date;
        private string birth;
        private string gender;
        List<string> sub_path = new List<string>();
        private string member_digit;

        public Customer(string name, string digit, string addr, string date, string birth, 
            string gender, List<string> sub_path)
        {
            this.name = name;
            this.digit = digit;
            this.addr = addr;
            this.date = date;
            this.birth = birth;
            this.gender = gender;
            this.sub_path = sub_path;
        }

        public Customer(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }
        public string Digit { get => digit; set => digit = value; }
        public string Addr { get => addr; set => addr = value; }
        public string Date { get => date; set => date = value; }
        public string Birth { get => birth; set => birth = value; }
        public string Gender { get => gender; set => gender = value; }
        public List<string> Sub_path { get => sub_path; set => sub_path = value; }
        public string Member_digit { get => member_digit; set => member_digit = value; }

        public void show_personal_info()
        {
            Console.WriteLine("이름 " + this.name);
            Console.WriteLine("번호 " + this.digit);
            Console.WriteLine("주소 " + this.addr);
            Console.WriteLine("구매일 " + this.date);
            Console.WriteLine("생일 " + this.birth);
            Console.WriteLine("성 " + this.gender);
            Console.WriteLine("가입경로");
            for (int i = 0; i < this.sub_path.Count; i++)
            {
                Console.Write(this.sub_path[i] + "\t");
            }
            Console.WriteLine("회원번호 " + this.member_digit);
            Console.WriteLine();
        }
    }
}
