using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_03
{
    class Class3
    {
        public void car_salary()
        {

            int excent = 0;
            int excent_price = 1520000;
            int k5 = 0;
            int k5_price = 2340000;
            int genesis = 0;
            int genesus_price = 1740000;
            int price = 0;
            
            string line = "++++++++++++++++++++++++++++++++++++++++++++++++++";
            string br = "\n";
            
            Console.WriteLine(br);
            Console.WriteLine(br);
            Console.WriteLine(br);
            Console.WriteLine(br);
            Console.WriteLine(br);
            Console.WriteLine(line);
            Console.WriteLine(br);
            Console.WriteLine("입고를 원하시는 품목을 골라주세요.");
            Console.WriteLine(br);
            Console.WriteLine("\t발주처 : (주)평화정공");
            Console.WriteLine(br);
            Console.WriteLine("\t\t부품명");
            Console.WriteLine(br);
            Console.WriteLine("1 : 엑센트 LED 포지션 라이트 (가격 : 1520000)");
            Console.WriteLine("2 : K5 LED안개등/14년형 (가격 : 2340000)");
            Console.WriteLine("3 : 제네시스-쿠페 2.0 플라이휠 세트 (가격 : 1740000)");
            Console.WriteLine("4번을 입력하시면 10개씩 증가됩니다.");
            Console.WriteLine(br);
            Console.WriteLine("0 : 종료");
            Console.WriteLine(br);
            Console.WriteLine(line);


            while (true)
            { 
                int call = int.Parse(Console.ReadLine());
                
                switch (call)
                {
                    case 1:
                        excent++;
                        price += excent_price;
                        break;

                    case 2:
                        k5++;
                        price += k5_price;
                        break;

                    case 3:
                        genesis++;
                        price += genesus_price;
                        break;

                    case 4:
                        excent += 10;
                        k5 += 10;
                        genesis += 10;
                        price += (excent_price * 10) + (k5_price * 10) + (genesus_price * 10);
                        break;

                    default:
                        Console.WriteLine("0 ~ 4의 값을 입력해주세요.");
                        break;
                }


                if (call == 1 | call == 2 | call == 3 | call == 4)
                { 
                    int result = excent + k5 + genesis;
                    Console.WriteLine(br);
                    Console.WriteLine("주문하신 엑센트 LED 포지션 라이트의 갯수는 총 {0}개입니다.", excent);
                    Console.WriteLine("주문하신 K5 LED안개등/14년형의 갯수는 총 {0}개입니다.", k5);
                    Console.WriteLine("주문하신 제네시스-쿠페 2.0 플라이휠 세트의 갯수는 총 {0}개입니다.", genesis);
                    Console.WriteLine("주문하신 총구매량은 {0}개입니다.", result);
                    Console.WriteLine("주문하신 총가격은 {0}원입니다.", price);
                    Console.WriteLine("4번을 입력하시면 10개씩 증가됩니다.");
                    Console.WriteLine(br);
                    Console.WriteLine("0 : 종료");
                }


                if (call == 0)
                {
                    break;
                }
            }
        }
    }
}
