using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View_structure_0811.Model
{
    class Admin_id
    {
        string id;
        string password;
        string name;
        string digit;
        string addr;

        public Admin_id(string id, string password, string name, string digit, string addr)
        {
            this.id = id;
            this.password = password;
            this.name = name;
            this.digit = digit;
            this.addr = addr;
        }

        public string Id { get => id; set => id = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string Digit { get => digit; set => digit = value; }
        public string Addr { get => addr; set => addr = value; }

        public void show_id_info()
        {
            Console.WriteLine("아이디 : {0}", id);
            Console.WriteLine("비밀번호 : {0}", password);
            Console.WriteLine("이름 : {0}", name);
            Console.WriteLine("전화번호 : {0}", digit);
            Console.WriteLine("주소 : {0}", addr);
        }
    }
}
