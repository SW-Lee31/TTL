using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0726
{
    class Car
    {
        // 클래스 변수(생성자와 상관없이 생성 및 활용 가능) - 클래스 이름으로 접근 가능
        public const string AGENCY = "HYNDAI 동대구영업소";

        // 인스턴스 변수 - 객체를 통해서(메서드 활용) 접근 가능
        private string manu_com { get; set; }
        private string color { get; set; }
        private int price { get; set; }
        private string model { get; set; }

        // Constructor
        public Car(string manu_com, string color, int price, string model)
        {
            this.manu_com = manu_com;
            this.color = color;
            this.price = price;
            this.model = model;
        }

        public Car()
        {

        }

        ~Car()
        {
            Console.WriteLine("{0}판매정보가 소멸되었습니다.", model);
        }

        // 각각의 인스턴스 변수의 getter, setter
        public string Manu_com
        {
            get
            {
                return manu_com;
            }
            set
            {
                manu_com = value;
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

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public void show_info()
        {
            Console.WriteLine();
            Console.WriteLine("제조사명 : {0}", manu_com);
            Console.WriteLine("차량색상 : {0}", color);
            Console.WriteLine("차량가격 : {0}", price);
            Console.WriteLine("차량모델명 : {0}", model);
            Console.WriteLine();
        }
    }
}
