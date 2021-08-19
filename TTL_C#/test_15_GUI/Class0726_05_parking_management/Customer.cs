using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0726_05_parking_management
{
    class Customer
    {
        private string name;
        private string p_num;
        private string addr;
        Car car;

        public Customer(string name, string p_num, string addr, Car car)
        {
            this.name = name;
            this.p_num = p_num;
            this.addr = addr;
            this.car = car;
        }

        public string Name { get => name; set => name = value; }
        public string P_num { get => p_num; set => p_num = value; }
        public string Addr { get => addr; set => addr = value; }
        internal Car Car { get => car; set => car = value; }

        public override string ToString()
        {
            string data_cus = "고객 이름 : " + name + "\n"
                + "고객번호 : " + p_num + "\n"
                + "고객주소 : " + addr + "\n";

            return data_cus;
        }

        public void printCustomerInfo()
        {
            Console.WriteLine(car.ToString());
            Console.WriteLine(this.ToString());
        }

    }
}
