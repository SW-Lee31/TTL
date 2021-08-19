using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0722
{
    // 클래스의 첫자는 대문자로 사용(관례)
    // Car() -> 기본 생성자 : 명세 생략가능(컴파일)
    // 
    class Car
    {
        // Car의 속성
        private string model_name;
        private int price;
        private int year;
        private string color;
        private double displacement { set; get; }

        private enum fuel_type
        {
            gasoline,
            gas,
            elec,
            hydrogen
        }

        // 기본생성자 - 인스턴스 생성 시에 사용되는 특수 메서드 + 클래스의 속성변수에 초기값 지정 가능
        public Car()
        {
            Console.WriteLine("인스턴스 생성");

            // 속성변수에 초기값 지정
            model_name = "Sonata";
            price = 34000000;
            year = 2021;
            color = "Ivory";
            displacement = 2.8;
            fuel_type type = fuel_type.gasoline;
        }

        // 사용자지정 생성자 - parameter활용, 클래스의 속성변수에 parameter의 값 활용가능
        public Car(string model_name, int price)
        {
            // 속성변수 호출
            // this : 객체의 시작위치정보 (변수의 이름과 같은 역할) -> 클래스 내부에서만 활용 가능
            this.model_name = model_name;
            this.price = price;
        }

        // OverLoading의 조건
        // 1. parameter의 개수가 달라야 함
        // 2. parameter의 data type이 달라야 함
        public Car(string model_name, int price, int year, string color, double displacement)
        {
            this.model_name = model_name;
            this.price = price;
            this.year = year;
            this.color = color;
            this.displacement = displacement;
            fuel_type type = fuel_type.gasoline;
        }

        // 생성된 객체 정보를 변경하는 메서드 - setter
        public void setcolor(string color)
        {
            this.color = color;
        }

        // 객체의 정보를 얻는 메서드 - getter
        public string getcolor()
        {
            return color;
        }


        public void car_sell()
        {
            Console.WriteLine("구매해주셔서 감사합니다.");
            Console.WriteLine("구매하신 차량의 모델 : {0}", model_name);
            Console.WriteLine("구매하신 차량의 가격 : {0}원", price);
            Console.WriteLine("구매하신 차량의 연식 : {0}년", year);
            Console.WriteLine("구매하신 차량의 색상 : {0}", color);
            Console.WriteLine("구매하신 차량의 배기량 : {0}L", displacement);
            Console.WriteLine("구매하신 차량은 {0}차량입니다.", fuel_type.gasoline);
        }
    }
}
