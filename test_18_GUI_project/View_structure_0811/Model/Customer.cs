using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View_structure_0811.Model
{
    class Customer
    {
        private string name;
        private string member_digit;
        private string digit;
        private string addr;
        private List<string> serial_num;

        public Customer(string name, string digit, string addr, List<string> serial_num)
        {
            this.name = name;
            this.digit = digit;
            this.addr = addr;
            this.serial_num = serial_num;
        }

        public string Name { get => name; set => name = value; }
        public string Member_digit { get => member_digit; set => member_digit = value; }
        public string Digit { get => digit; set => digit = value; }
        public string Addr { get => addr; set => addr = value; }
        public List<string> Serial_num { get => serial_num; set => serial_num = value; }

        public void print_cus_info()
        {
            Console.WriteLine("이름 : {0}", this.name);

            if (this.member_digit != "")
            {
                Console.WriteLine("고객번호 : {0}", this.member_digit);
            }

            Console.WriteLine("전화번호 : {0}", this.digit);
            Console.WriteLine("주소 : {0}", this.addr);

            Console.WriteLine("주문 시리얼넘버 : {0}", this.serial_num);
            for (int i = 0; i < serial_num.Count; i++)
            {
                Console.Write(this.serial_num);
                
                if (i != serial_num.Count - 1)
                {
                    Console.Write(", ");
                }
            }

        }
    }
}
