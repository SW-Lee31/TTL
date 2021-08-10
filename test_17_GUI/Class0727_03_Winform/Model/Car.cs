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
        private List<string> brand_list;
        private List<string> model_list;
        private List<string> color_list;
        Customer cus;
        private List<string> se_num_list;
        private List<string> date_list;

        public Car(List<string> brand_list, List<string> model_list, List<string> color_list, Customer cus, List<string> se_num_list, List<string> date_list)
        {
            this.brand_list = brand_list;
            this.model_list = model_list;
            this.color_list = color_list;
            this.cus = cus;
            this.se_num_list = se_num_list;
            this.date_list = date_list;
        }

        public List<string> Brand_list { get => brand_list; set => brand_list = value; }
        public List<string> Model_list { get => model_list; set => model_list = value; }
        public List<string> Color_list { get => color_list; set => color_list = value; }
        public List<string> Date_list { get => date_list; set => date_list = value; }
        public List<string> Se_num_list { get => se_num_list; set => se_num_list = value; }
        internal Customer Cus { get => cus; set => cus = value; }

        public void Print_salary()
        {
            for (int i = 0; i < se_num_list.Count; i++)
            {
                Console.WriteLine("브랜드 : {0},", brand_list[i]);
                Console.WriteLine("모델명 : {0},", model_list[i]);
                Console.WriteLine("색상 : {0},", color_list[i]);
                Console.WriteLine("주문고객명 : {0},", cus.Name);
                Console.WriteLine("시리얼넘버 : {0},", se_num_list[i]);
                Console.WriteLine("주문날짜 : {0},", date_list[i]);
                Console.WriteLine("###########################################");
            }
        }
    }
}
