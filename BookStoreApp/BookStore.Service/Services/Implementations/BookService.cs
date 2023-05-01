using BookStore.Core.Enums;
using BookStore.Core.Models;
using BookStore.Data.Repositories.Writer;
using BookStore.Service.Services.Interface;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookStore.Service.Services.Implementations
{
    public class BookService : IBookService
    {
        private readonly BookWriterRepository _repostory = new BookWriterRepository();

        public async Task<string> BuyBookAsync(int bkrtid, int bookid, bool InStock) 
        {
            BookWriter bookwriter = await _repostory.GetAsync(bkrt => bkrt.Id == bkrtid);
            
           
                if (bookwriter == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    return "bookwriter not found";
                }
                Book book = bookwriter.Books.FirstOrDefault(bk => bk.Id == bookid);

                if (book == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    return "book not found";
                }
                if (!book.InStock)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    return "book is not instock";
                }
            
                Console.ForegroundColor = ConsoleColor.Green;
              return "successfully bought";
           
        }

        public async Task<string> CreateAsync(int id, string name, double price, double DiscountPrice, BookCategory Category, bool InStock)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            BookWriter bookwriter = await _repostory.GetAsync(bkrt=>bkrt.Id == id);
           
            if (bookwriter == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
               return "Invalid options";
            }
          
            if (await ValidateBook(name, price, DiscountPrice, Category) !=null)
                return await ValidateBook(name, price, DiscountPrice, Category);

            Book book = new Book(name, price, DiscountPrice, Category, bookwriter, true);
                bookwriter.Books.Add(book);
            
            Console.ForegroundColor = ConsoleColor.Green;
            return "Created";
        }

        public async Task<string> DeleteAsync(int bkrtid, int bookid)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            BookWriter bookwriter = await _repostory.GetAsync(bkrt => bkrt.Id == bkrtid);

            if (bookwriter == null)
                return "Bookwriter not found";

            Book book = bookwriter.Books.FirstOrDefault(bk => bk.Id == bookid);
            if (book == null)
                return "Book not found";

            bookwriter.Books.Remove(book);
            Console.ForegroundColor = ConsoleColor.Red;

            return "Deleted";
        }

        public async Task<Book> GetAsync(int bkrtid, int bookid)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            BookWriter bookwriter = await _repostory.GetAsync(bkrt => bkrt.Id == bkrtid);

            if (bookwriter == null)
            {
                Console.WriteLine("BookWriter not found");
                return null;

            }
                


            Book book = bookwriter.Books.FirstOrDefault(bk => bk.Id == bookid);
            book.UpdatedDate = DateTime.UtcNow.AddHours(4 );
            if (book == null)
            {
                Console.WriteLine("Book not found");
                return null;
            }
                return book;
        }

        public async Task<string> UpdateAsync(int bkrtid, int bookid, string name, double price, double DiscountPrice, BookCategory Category)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            BookWriter bookwriter = await _repostory.GetAsync(bkrt => bkrt.Id == bkrtid);
            if (bookwriter == null)
                return "BookWriter not found";
            if (!string.IsNullOrEmpty(await ValidateBook(name, price, DiscountPrice, Category)))
            {
                return await ValidateBook(name, price, DiscountPrice, Category);
            }
            Book book = bookwriter.Books.FirstOrDefault(bk => bk.Id == bookid);

            book.Name = name;
            book.Price = price;
            book.DiscountPrice = DiscountPrice;
            book.Category = Category;
            book.UpdatedDate = DateTime.UtcNow.AddHours(4);


            Console.ForegroundColor = ConsoleColor.Green;
            return "Updated";
        }

        

        private async Task<string> ValidateBook(string name, double price, double DiscountPrice, BookCategory Category)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (string.IsNullOrWhiteSpace(name))
                return "Add valid Name";
            if (price <= 0)
                return "Add valid Price";
            if (DiscountPrice > price || DiscountPrice <= 0)
                return "Add valid DiscountPrice";
            return "";
        }

    }
}