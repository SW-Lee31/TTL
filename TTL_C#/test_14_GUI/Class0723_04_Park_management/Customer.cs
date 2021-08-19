using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0723_04_Park_management
{
    class Customer
    {
        private string cus_name { get; set; }
        private string p_num { get; set; }
        private string addr { get; set; }
        Car car { get; set; }

        public string Cus_name
        {
            get
            {
                return cus_name;
            }
            set
            {
                cus_name = value;
            }
        }

        public string P_num
        {
            get
            {
                return p_num;
            }
            set
            {
                p_num = value;
            }
        }

        public string Addr
        {
            get
            {
                return addr;
            }
            set
            {
                addr = value;
            }
        }

        public Car car_getset
        {
            get
            {
                return car;
            }
            set
            {
                car = value;
            }
        }

        public Customer(string cus_name, string p_num, string addr, Car car)
        {
            this.cus_name = cus_name;
            this.p_num = p_num;
            this.addr = addr;
            this.car = car;
        }

        public void print()
        { 
            Console.WriteLine("############# 고객정보 #############");
            Console.WriteLine("고객의 이름 : {0}", cus_name);
            Console.WriteLine("고객의 전화번호 : {0}", p_num);
            Console.WriteLine("고객의 주소 : {0}", addr);
            Console.WriteLine("############# 차량정보 #############");
            car.printCarInfo();
        }
    }
}
