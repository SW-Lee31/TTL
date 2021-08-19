using Class0727_03_Winform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0727_03_Winform.Adapter
{
    class CarAdapter
    {
        List<Car> order_list = new List<Car>();

        internal List<Car> Order_list { get => order_list; set => order_list = value; }

        public void Add_order_list(Car car_index)
        {
            order_list.Add(car_index);
        }

        public void show_list()
        {
            for (int i = 0; i < order_list.Count; i++)
            {
                order_list[i].Print_salary();
            }
        }
    }
}
