

using BookStore.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Core.Repositories
{
    public interface IRepository<T> where T : BaseModel
    {
        Task AddAsync(T model);

        Task<T> GetAsync(Func<T, bool> expression);
        Task<List<T>> GetAllAsync();
        Task  RemoveAsync (T model);
        


    }

}