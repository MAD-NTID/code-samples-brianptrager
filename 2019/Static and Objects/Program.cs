using System;
using System.Text;

namespace Static_and_Objects
{
    class Program
    {
        public static Book[] books = new Book[0];
        static void Main(string[] args)
        {

            while(true)
            {
                Console.WriteLine(DisplayMenu());
                string choice = Console.ReadLine();

                Book book;

                switch(choice[0].ToString())
                {
                    case "1": //Add a book
                              book = CreateBook();
                              Array.Resize(ref books, books.Length + 1);
                              books[books.Length - 1] = book;
                              break;

                    case "2": //Display book by author
                              Console.Write("Enter author: ");
                              Book bookByAuthor = DisplayBookByKeyword("Author", Console.ReadLine());

                              if(bookByAuthor != null)
                              {
                                  Console.WriteLine(bookByAuthor.ToString());
                              }
                              else
                              {
                                  Console.WriteLine("Author not found!");
                              }
                              break;

                    case "3": //Display book by title
                              Console.Write("Enter title: ");
                              Book bookByTitle = DisplayBookByKeyword("Title", Console.ReadLine());

                              if(bookByTitle != null)
                              {
                                  Console.WriteLine(bookByTitle.ToString());
                              }
                              else
                              {
                                  Console.WriteLine("Author not found!");
                              }
                              break;

                    case "4": //Display all books
                              for(int i = 0; i < books.Length; i++){
                                  Console.WriteLine(books[i].ToString());
                              }
                              break;
                    case "5": //Quit the program
                              Environment.Exit(0);
                              break;

                }//end switch for choice
            }//outer loop

            
        }

        private static string DisplayMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Book Collection System\n\n");
            sb.Append("1. Add a new book\n");
            sb.Append("2. Display a book by author\n");
            sb.Append("3. Display a book by title\n");
            sb.Append("4. Display all books\n");
            sb.Append("5. Exit\n\n");
            sb.Append("Enter choice: ");

            return sb.ToString();
        }

        private static Book CreateBook()
        {
            Console.Write("Enter Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Author: ");
            string author = Console.ReadLine();

            Console.Write("Enter Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Enter Page Count: ");
            int pageCount = int.Parse(Console.ReadLine());

            Console.Write("Enter number of chapters: ");
            int chapters = int.Parse(Console.ReadLine());

            Console.Write("Enter format of book: ");
            string bookFormat = Console.ReadLine();

            Console.Write("Enter Genre: ");
            string genre = Console.ReadLine();

            Book book = new Book(pageCount, bookFormat, author, year, title, genre, chapters);
            return book;
        }

        private static Book DisplayBookByKeyword(string searchType, string keyword)
        {
            for(int i = 0; i < books.Length; i++)
            {
                Book tmpBook = books[i];
                switch(searchType)
                {
                    case "Author":
                                if(tmpBook.Author == keyword)
                                    return tmpBook;
                                break;
                    case "Title":
                                if(tmpBook.Title == keyword)
                                    return tmpBook;
                                break;
                }
                
            }
            return null;
        }
    }
}
