using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
     public interface IAsyncRepository<T>
    {
        Task<T> CreateAsync(T entity);
        Task<T> DeleteAsync(Guid Id, T entity);
        Task<T> FindByIdAsync(Guid Id);
        Task<IReadOnlyList<T>> ListAsync();
        Task<T> UpdateAsync(T entity);
    }
}