using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0723_02_library_management
{
    class Customer
    {
        public const string LIBRARY = "수성도서관"; // 생성자와 상관없이 Class로 접근 가능
        private string name;
        private string p_num;
        /*private int age;
        private string addr;
        private string gender;*/

        Book book;

        public Customer(string name, string p_num, Book book)
        {
            this.name = name;
            this.p_num = p_num;
            this.book = book;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void setPnum(string p_num)
        {
            this.p_num = p_num;
        }

        public string getPnum()
        {
            return p_num;
        }

        public void setBook(Book book)
        {
            this.book = book;
        }

        public Book getBook()
        {
            return book;
        }

        public void showCusomerInfo()
        {
            /*Console.WriteLine("대여 도서관 : {0}", LIBRARY)*/;
            Console.WriteLine("대여인 이름 : {0}", name);
            Console.WriteLine("대여인 전화번호 : {0}", p_num);
            Console.WriteLine("대여 책 제목 : {0}", book.getTitle());
            /*book.show_bookinfo();*/
        }
    }
}
