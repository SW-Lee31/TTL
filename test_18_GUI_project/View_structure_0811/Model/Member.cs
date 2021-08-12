using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View_structure_0811.Model
{
    class Member : Person
    {
        private string name;
        private string digit;
        private string addr;
        private string date;
        private string gender;

        private string member_digit;
        private List<string> serial_num;

        public Member(string name, string digit, string addr, string gender, string date, string member_digit, List<string> serial_num)
            : base(name, digit, addr, gender, date)
        {
            this.name = name;
            this.digit = digit;
            this.addr = addr;
            this.date = date;
            this.gender = gender;
            this.member_digit = member_digit;
            this.serial_num = serial_num;
        }

        public string Name1 { get => name; set => name = value; }
        public string Digit1 { get => digit; set => digit = value; }
        public string Addr1 { get => addr; set => addr = value; }
        public string Date1 { get => date; set => date = value; }
        public string Gender1 { get => gender; set => gender = value; }
        public string Member_digit { get => member_digit; set => member_digit = value; }
        public List<string> Serial_num { get => serial_num; set => serial_num = value; }
    }
}
