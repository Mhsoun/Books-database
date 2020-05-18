using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_database
{
    class Book
    {

        public Book(string bookTitle, string bookAuthor)
        {
            this.BookTitle = bookTitle;
            this.BookAuthor = bookAuthor;
            this.UserData = bookAuthor;
        }

        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public string UserData { get; set; }
    }
}
