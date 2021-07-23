using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_03_vehicle
{
    class Vehicle
    {
        private const string AGENCY = "대구 수성점";
        private string manu_company { get; set; }
        private string color;
        private int price;
        private string model_name;


        public string Manu_company
        {
            get
            {
                return manu_company;
            }
            set
            {
                manu_company = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public string Model_name
        {
            get
            {
                return model_name;
            }
            set
            {
                model_name = value;
            }
        }


        public Vehicle()
        {
            manu_company = "기본 값";
            color = "기본 값";
            price = 0;
            model_name = "기본 값";
        }

        public Vehicle(string manu_company, string color, int price, string model_name)
        {
            this.manu_company = manu_company;
            this.color = color;
            this.price = price;
            this.model_name = model_name;
        }

        public void show_vehi_info()
        {
            Console.WriteLine("########################################");
            Console.WriteLine("대리점명 : {0}", AGENCY);
            Console.WriteLine("제조사 : {0}", manu_company);
            Console.WriteLine("색상 : {0}", color);
            Console.WriteLine("가격 : {0}원", price);
            Console.WriteLine("모델명 : {0}", model_name);
        }


    }
}
