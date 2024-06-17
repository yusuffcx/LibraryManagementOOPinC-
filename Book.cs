using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book
    {
        private string title;
        private string author;
        private string isbn;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public string Isbn
        {
            get
            {
                return isbn;
            }
            set
            {
                isbn = value;
            }
        }

        public Book(string title, string author , string isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
        }

        public string GetBookInfo()
        {
            return title + " " + author + " " + isbn;
        }


    }
}
