using Class0727_03_Winform.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0727_03_Winform.Model
{
    class Car
    {
        private string brand;
        private string model;
        private string color;
        private string cus_name;
        private List<string> se_num;
        private string date;


        public Car(string brand, string model, string color, string cus_name, List<string> se_num, string date)
        {
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.cus_name = cus_name;
            this.se_num = se_num;
            this.date = date;
        }

        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }

        public string Cus_name { get => cus_name; set => cus_name = value; }
        public string Date { get => date; set => date = value; }
        public List<string> Se_num { get => se_num; set => se_num = value; }

        public void Print_salary()
        {
            Console.WriteLine("브랜드 : {0},", brand);
            Console.WriteLine("모델명 : {0},", model);
            Console.WriteLine("색상 : {0},", color);
            Console.WriteLine("주문고객명 : {0},", cus_name);
            Console.WriteLine("시리얼넘버 : {0},", se_num);
            Console.WriteLine("주문날짜 : {0},", date);
            Console.WriteLine("###########################################");
        }
    }
}
