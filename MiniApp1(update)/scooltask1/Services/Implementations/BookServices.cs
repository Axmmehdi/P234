

using book.core.Models;
using book.core.Models.BaseModels;
using BookApp.App.Services.Interface;

namespace BookApp.App.Services.Implementations
{

    public class BookServices: IBookService
    {
        private Books[] books = new Books[0];
        public void Showbooks()
        {
            if (books.Length == 0)
            {
                Console.WriteLine("Not available");
            }
            foreach (Books book in books)
            {
                
                book.GetFullInfo();

            }
        }
        public DateTime CreateDateTime()
        {
            return DateTime.UtcNow.AddHours(4);
        }
        public void CreateBook()
        {
           
            Books NewBook = new Books();
            Console.WriteLine("add Name");
            NewBook.Name = Console.ReadLine();
            Console.WriteLine("add Price");
            NewBook.Price = Convert.ToDouble(Console.ReadLine());
            
       
            Array.Resize(ref books, books.Length + 1);

            books[books.Length - 1] = NewBook;

            
       

        }

    }



}
