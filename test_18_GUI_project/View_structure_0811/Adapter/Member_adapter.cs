using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View_structure_0811.Model;

namespace View_structure_0811.Adapter
{
    class Member_adapter
    {
        static List<Member> member_list = new List<Member>();

        internal static List<Member> Member_list { get => member_list; set => member_list = value; }

        static public void Add_list(Member member_index)
        {
            member_list.Add(member_index);
        }

        static public void print_member_list()
        {
            for (int i = 0; i < member_list.Count; i++)
            {
                Console.WriteLine("멤버 이름 : {0}", member_list[i].Name1);
                Console.WriteLine("멤버 전화번호 : {0}", member_list[i].Digit1);
                Console.WriteLine("멤버 주소 : {0}", member_list[i].Addr1);
                Console.WriteLine("멤버 가입날짜 : {0}", member_list[i].Date1);
                Console.WriteLine("멤버 성별 : {0}", member_list[i].Gender1);
                Console.WriteLine("멤버 고객번호 : {0}", member_list[i].Member_digit);
            }
        }
    }
}
