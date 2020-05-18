using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Books_database
{
    class Program
    {
        static void Main(string[] args)
        {
            BooksLibrary library = new BooksLibrary();

            string MainInstrcation()
            {
                Console.WriteLine("please choose what you wanna do");
                Console.WriteLine("• type 1 to Add a book"+
                    "• type 2 to Add data for one book"+
                    "•type 3 to Display all the entered books" +
                    "•tyoe 4 to Search for the book(s) with a certain title" +
                    "• type 5 to Delete a book at a known position" +
                    "• type 6 to Exit the program");
                string userInput = Console.ReadLine();
                
                return userInput;
            }

            void ActualProgram()
            {
                string userInput = MainInstrcation();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("enter the book title");
                        string bookTitle = Console.ReadLine();
                        Console.WriteLine("enter the book author name");
                        string bookAuthor = Console.ReadLine();
                        library.AddBook(bookTitle, bookAuthor);
                        break;

                    case "2":

                        if (library.booksTotal != 0)
                        {
                            var booksIndex = library.booksTotal - 1;
                            Console.WriteLine("from one to " + booksIndex + ", enter the index of the book you wannna add data to");
                            var userChoice = Console.ReadLine();
                            Console.WriteLine("enter the data you wanna enter");
                            library.books[int.Parse(userChoice)].UserData = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("there are no books");
                        }

                        break;

                    case "3":
                        library.DisplayBooks();
                        break;

                    case "4":
                        Console.WriteLine("enter the title of the boo");
                        library.SearchBookByTitle(Console.ReadLine());
                        break;

                    case "5":
                        if (library.booksTotal != 0)
                        {
                            var booksIndex = library.booksTotal - 1;
                            Console.WriteLine("from one to " + booksIndex + ", enter the index of the book you wannna add data to");
                            var userChoice = Console.ReadLine();
                            library.DeleteBook(int.Parse(userChoice));
                        }
                        else
                        {
                            Console.WriteLine("there are no books");
                        }
                        break;

                    case "6":
                        Environment.Exit(0);
                        break;
                }
            }

            while(true)
            {
                ActualProgram();
            }
        }
    }
}
