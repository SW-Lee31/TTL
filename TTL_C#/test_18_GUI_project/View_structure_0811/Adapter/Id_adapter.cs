using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View_structure_0811.Model;

namespace View_structure_0811.Adapter
{
    class Id_adapter
    {
        static List<Admin_id> id_list = new List<Admin_id>();

        internal static List<Admin_id> Id_list { get => id_list; set => id_list = value; }

        static public void add_list(Admin_id id_index)
        {
            id_list.Add(id_index);
        }

        static public void print_add_list()
        {
            for (int i = 0; i < id_list.Count; i++)
            {
                Console.WriteLine("아이디 : {0}", id_list[i].Id);
                Console.WriteLine("비밀번호 : {0}", id_list[i].Password);
                Console.WriteLine("사용자 이름 : {0}", id_list[i].Name);
                Console.WriteLine("사용자 전화번호 : {0}", id_list[i].Digit);
                Console.WriteLine("사용자 주소 : {0}", id_list[i].Addr);
            }
        }
    }
}
