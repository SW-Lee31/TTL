using Class0727_03_Winform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0727_03_Winform.Adapter
{
    class CusAdpater
    {
        List<Customer> cus_list = new List<Customer>();

        internal List<Customer> Cus_list { get => cus_list; set => cus_list = value; }

        public void Addcustomer(Customer cus)
        {
            this.cus_list.Add(cus);
        }

        public void Show_cus_list_added_info()
        {
            for (int i = 0; i < this.cus_list.Count; i++)
            {
                Console.WriteLine("{0}번째 인적사항", (i + 1));
                cus_list[i].show_personal_info();
            }
        }

        public void Show_cus()
        {
            for (int i = 0; i < this.cus_list.Count; i++)
            {
                Console.WriteLine("고객명 : {0}", cus_list[i].Name);
            }
        }
    }
}
