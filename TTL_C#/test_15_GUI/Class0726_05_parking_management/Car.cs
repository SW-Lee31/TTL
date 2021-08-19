using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0726_05_parking_management
{
    class Car
    {
        private string model;
        private string color;
        private string year;
        private string manu_com;

        public Car(string model, string color, string year, string manu_com)
        {
            this.model = model;
            this.color = color;
            this.year = year;
            this.manu_com = manu_com;
        }

        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public string Year { get => year; set => year = value; }
        public string Manu_com { get => manu_com; set => manu_com = value; }

        /*public void printCarInfo()
        {
            Console.WriteLine("차량 모델명 : {0}", model);
            Console.WriteLine("차량 색상 : {0}", color);
            Console.WriteLine("차량 연식 : {0}", year);
            Console.WriteLine("차량 제조사 : {0}", manu_com);
        }*/

        public override string ToString()
        {
            string data_car = "차량 모델명 :" + model + "\n"
                + "차량 색상 : " + color + "\n"
                + "차량 연식 : " + year + "년\n"
                + "차량 제조사 : " + manu_com + "\n";

            return data_car;
         }
    }
}
