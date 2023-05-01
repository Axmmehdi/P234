using BookStore.Core.Enums;
using BookStore.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service.Services.Interface
{
    public interface IBookService
    {
        Task<string> CreateAsync(int id, string name, double price, double DiscountPrice, BookCategory Category, bool InStock);
        Task<string> BuyBookAsync(int bkrtid, int bookid , bool InStock);
        Task<string> UpdateAsync(int bkrtid, int bookid, string name, double price, double DiscountPrice, BookCategory Category);
        Task<string> DeleteAsync(int bkrtid, int bookid);
        Task<Book> GetAsync(int bkrtid, int bookid);
    }
}
