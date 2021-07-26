using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0726_03_GetterSetter
{
    class Car // = Car : Object(모든 클래스의 조상)
    {
        public const string AGENCY = "KIA 동대구영업소";

        private string model;
        private string color;
        private int price;
        private string manu_com;

        public Car(string model, string color, int price, string manu_com)
        {
            this.model = model;
            this.color = color;
            this.price = price;
            this.manu_com = manu_com;
        }

        // getter, setter는 변수가 아닌 특수메서드
        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public int Price { get => price; set => price = value; }
        public string Manu_com { get => manu_com; set => manu_com = value; }

        public void show_info()
        {
            Console.WriteLine("모델명 : {0}", model);
            Console.WriteLine("색상 : {0}", color);
            Console.WriteLine("가격 : {0}", price);
            Console.WriteLine("제조사 : {0}", manu_com);
        }
        
        // 부모 클래스에서 상속받은 메서드 -> 자식 클래스에서 재정의
        // 재정의 = 오버라이딩 (상속)
        public override string ToString()
        {
            string data = "제조사 : " + manu_com + "\n";
            data += "색상 : " + color + "\n";
            data += "가격 : " + price + "\n";
            data += "모델 : " + model + "\n";
            return data;
        }
    }
}
