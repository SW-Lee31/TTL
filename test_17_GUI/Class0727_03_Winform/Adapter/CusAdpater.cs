using Class0727_03_Winform.Model;
using System;
using System.Collections.Generic;
using System.IO;
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

        public void Load_csv_customer_info()
        {
            StreamWriter csv_customer = new StreamWriter(@"C:\\c#_work\\test_17_GUI\\test.csv", false, Encoding.UTF8);

            csv_customer.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", 
                "고객명", "전화번호", "주소", "가입날짜", "생년월일", "성별", "가입경로", "고객번호");
            string sub_path = "";

            for (int i = 0; i < cus_list.Count; i++)
            {
                for (int j = 0; j < cus_list[i].Sub_path.Count; j++)
                {
                    if (j != (cus_list[i].Sub_path.Count - 1))
                    {
                        sub_path += cus_list[i].Sub_path[j] + " / ";
                    }

                    else
                    {
                        sub_path += cus_list[i].Sub_path[j];
                    }
                }
                csv_customer.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}", cus_list[i].Name, "'" + cus_list[i].Digit,
                   cus_list[i].Addr, cus_list[i].Date, cus_list[i].Birth, cus_list[i].Gender, sub_path);
            }

            csv_customer.Close();
        }
    }
}
