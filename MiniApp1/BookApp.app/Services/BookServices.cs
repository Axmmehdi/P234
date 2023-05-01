

using book.core.Models;

namespace bookapp.app.Services
{

    internal class BookServices
    {
        private Book[] books = new Book[0];
        public void Showbooks()
        {
            if (books.Length == 0)
            {
                Console.WriteLine("Not available");
            }
            foreach (Book book in books)
            {
                book.GetFullInfo();

            }
        }

        public void CreateBook()
        {
            Book NewBook = new Book();
            Console.WriteLine("add Name");
            NewBook.Name = Console.ReadLine();
            Console.WriteLine("add Price");
            NewBook.Price = Convert.ToDouble(Console.ReadLine());

            Array.Resize(ref books, books.Length + 1);

            books[books.Length - 1] = NewBook;



        }


    }



}
