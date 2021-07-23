using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0723_04_Park_management
{
    class Car
    {
        private string model { get; set; }
        private string color { get; set; }
        private int year { get; set; }
        private string company { get; set; }

        public string Model_name
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

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public string Manu_com
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
        }

        public Car(string model, string color, int year, string company)
        {
            this.model = model;
            this.color = color;
            this.year = year;
            this.company = company;
        }

        public void printCarInfo()
        {
            Console.WriteLine("차량 모델명 : {0}", model);
            Console.WriteLine("차량 색상 : {0}", color);
            Console.WriteLine("차량 연식 : {0}", year);
            Console.WriteLine("차량 제조사 : {0}", company);
            Console.WriteLine("#########################################");
            Console.WriteLine();
        }



    }
}
