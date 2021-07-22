using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0722_01_vehicle
{
    class Vehicle
    {
        private const string AGENCY = "대구 수성점";
        private string manufact_coper;
        private int price;
        private string model_name;
        private string color;

        // Basic Constuctor
        // 초기값 지정
        public Vehicle()
        {
            manufact_coper = "KIA";
            price = 45000000;
            model_name = "MOHAVE";
            color = "Chrom";
        }

        public Vehicle(string manufact_coper, string color, string model_name, int price)
        {
            this.manufact_coper = manufact_coper;
            this.color = color;
            this.model_name = model_name;
            this.price = price;
        }

        public void setmodel(string model_name)
        {
            this.model_name = model_name;
        }

        public string getmodel()
        {
            return model_name;
        }

        public void setprice(int price)
        {
            this.price = price;
        }

        public int getprice()
        {
            return price;
        }

        public void setmanufact(string manufact_coper)
        {
            this.manufact_coper = manufact_coper;
        }

        public string setmanufact()
        {
            return manufact_coper;
        }

        public void veh_info()
        {
            Console.WriteLine("제조사 : {0}", manufact_coper);
            Console.WriteLine("색상 : {0}", color);
            Console.WriteLine("모델명 : {0}", model_name);
            Console.WriteLine("가격 : {0}원", price);
            Console.WriteLine("대리점 명 : {0}", AGENCY);
        }
    }
}
