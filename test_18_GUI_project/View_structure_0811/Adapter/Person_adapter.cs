using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View_structure_0811.Model;

namespace View_structure_0811.Adapter
{
    class Person_adapter
    {
        static List<Person> personal_info_list = new List<Person>();

        internal static List<Person> Personal_info_list { get => personal_info_list; set => personal_info_list = value; }

        static public void Add_list(Person person_index)
        {
            personal_info_list.Add(person_index);
        }

        static public void pirnt_personal_list_info()
        {
            for (int i = 0; i < personal_info_list.Count; i++)
            {
                Console.WriteLine("이름 : {0}", personal_info_list[i].Name);
                Console.WriteLine("전화번호 : {0}", personal_info_list[i].Digit);
                Console.WriteLine("주소 : {0}", personal_info_list[i].Addr);
                Console.WriteLine("가입날짜 : {0}", personal_info_list[i].Date);
                Console.WriteLine("성별 : {0}", personal_info_list[i].Gender);
            }
        }
    }
}
