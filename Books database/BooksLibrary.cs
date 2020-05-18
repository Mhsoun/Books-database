using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Books_database
{
    class BooksLibrary
    {
        public List<Book> books;
        public int booksTotal;
        public BooksLibrary()
        {
            books = new List<Book>();
            booksTotal = 0;
        }



    public void AddBook(string title, string author)
        {
            if(booksTotal<=100)
            {

                ++booksTotal;
                books.Add(new Book(title, author));
            }
            else
            {
                Console.WriteLine("library full, please empty some book before adding new one!");
            }
        }

        public void DeleteBook(int bookNumber)
        {
            books.RemoveAt(bookNumber);
        }

 

        public void DisplayBooks()
        {
            books.ForEach(el => Console.WriteLine("author "+ el.BookAuthor + " title " +el.BookTitle));

        }

        public void SearchBookByTitle(string title)
        {
            foreach (var el in books)
            {
                if (el.BookTitle.Contains(title))
                {
                    Console.WriteLine("the book you are looking for is " +"Title : "+ el.BookTitle + "Author : "+ el.BookAuthor);
                }
            }

        }
    }
}
