using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
     public interface IAsyncRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<T> DeleteAsync(Guid Id, T entity);
        Task<T> FindByIdAsync(Guid Id);
        Task<T> FindByLoginAsync(T entity);
        Task<IReadOnlyList<T>> ListAsync(Guid Id);
        Task<T> UpdateAsync(T entity);
    }
}