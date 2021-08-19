using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class0723_02_library_management
{
    class Book
    {
        private string title;
        private string author;
        private string publisher;
        private string genre;

        public Book(string title, string author, string publisher, string genre)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.genre = genre;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public string getTitle()
        {
            return title;
        }

        public void setAuthor(string author)
        {
            this.author = author;
        }

        public string getAuthor()
        {
            return author;
        }

        public void setPublisher(string publisher)
        {
            this.publisher = publisher;
        }

        public string getPublisher()
        {
            return publisher;
        }

        public void setGenre(string genre)
        {
            this.genre = genre;
        }

        public string getGenre()
        {
            return genre;
        }

        public void show_bookinfo()
        {
            Console.WriteLine("######################################");
            Console.WriteLine("책 제목 : {0}", title);
            Console.WriteLine("책 저자 : {0}", author);
            Console.WriteLine("책 출판사 : {0}", publisher);
            Console.WriteLine("책 장르 : {0}", genre);
            Console.WriteLine("######################################");
        }
    }
}
