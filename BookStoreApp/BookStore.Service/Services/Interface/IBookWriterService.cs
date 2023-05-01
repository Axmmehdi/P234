
using BookStore.Core.Models;
using System.Collections.Generic;
using System.Security.Principal;
using System.Threading.Tasks;

namespace BookStore.Service.Services.Interface
{
    internal interface IBookWriterService
    {
        Task<string> CreateAsync(string name, string surname, int age);
        Task<string> UpdateAsync(int id, string name, string surname, int age);
        Task<string> DeleteAsync(int id);
        Task<BookWriter> GetAsync(int id);

        Task GetAllAsync();
        Task<List<Book>> GetAllBooksAsynnc(int id);



    }
}
