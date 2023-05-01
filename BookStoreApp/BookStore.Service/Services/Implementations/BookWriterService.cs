

using BookStore.Core.Models;
using BookStore.Data.Repositories.Writer;
using BookStore.Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using System.Threading.Tasks;

namespace BookStore.Service.Services.Implementations
{
    public class BookWriterService : IBookWriterService
    {
        private readonly BookWriterRepository _repostory = new BookWriterRepository();
        public async Task<string> CreateAsync(string name, string surname, int age)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (!string.IsNullOrEmpty(await ValidateWriter(name, surname, age)))
            {
                return await ValidateWriter(name, surname, age);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            BookWriter bookwriter = new BookWriter(surname, name, age);
            await _repostory.AddAsync(bookwriter);
            bookwriter.UpdatedDate = DateTime.UtcNow.AddHours(4);
            return "Successfully Created";
        }
        public async Task<string> DeleteAsync(int id)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            BookWriter bookwriter = await _repostory.GetAsync(bkrt => bkrt.Id == id);
            if (bookwriter == null)
                return "BookWriter not found";

            bookwriter.UpdatedDate = DateTime.UtcNow.AddHours(4);
            Console.ForegroundColor = ConsoleColor.Green;
            return "Successfully";

        }
        public async Task GetAllAsync()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            foreach (var item in await _repostory.GetAllAsync())
            {
                Console.WriteLine(item);
            }
        }

        public async Task<List<Book>> GetAllBooksAsynnc(int id)
        {
            BookWriter bookwriter = await _repostory.GetAsync(bkrt => bkrt.Id == id);

            if (bookwriter == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("BookWriter not found");
                return null;
            }
            return bookwriter.Books;
        }

        public async Task<BookWriter> GetAsync(int id)
        {
            BookWriter bookwriter = await _repostory.GetAsync(bkrt => bkrt.Id == id);

            if (bookwriter == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("BookWriter not found");
                return null;
            }
            return bookwriter;
        }

        public async Task<string> UpdateAsync(int id, string name, string surname, int age)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            if (!string.IsNullOrEmpty(await ValidateWriter(name, surname, age)))
            {
                return await ValidateWriter(name, surname, age);
            }

            BookWriter bookwriter = await _repostory.GetAsync(x => x.Id == id);
            if (bookwriter == null)
                return "BookWriter not found";
            bookwriter.Name = name;
            bookwriter.Age = age;
            bookwriter.SurName = surname;
            bookwriter.UpdatedDate = DateTime.UtcNow.AddHours(4);

            Console.ForegroundColor = ConsoleColor.Green;

            return "Updated";
        }


            private async Task<string> ValidateWriter(string name, string surname, int age)
            {
                if (string.IsNullOrWhiteSpace(name))
                    return "Add Valid Name";
                if (string.IsNullOrWhiteSpace(surname))
                    return "Add Valid Surname";
                if (age <= 20)
                    return "Add Valid Age";

                return "";
            }
  
    }
}
