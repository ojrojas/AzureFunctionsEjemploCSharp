using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure
{
    public class GenericEfRepository<T> : IAsyncRepository<T> where T : BaseEntity, IAggregateRoot
    {
        protected readonly AzureFunctionsDbContext _context;

        public GenericEfRepository()
        {
            _context = new AzureFunctionsDbContext();
        }

        public async Task<T> CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await SaveAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await SaveAsync();
            return entity;
        }

        public async Task<T> FindByIdAsync(Guid Id)
        {
            return await _context.Set<T>().FindAsync(Id);
        }

        public async Task<IReadOnlyList<T>> ListAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> DeleteAsync(Guid Id, T entity)
        {
            var deleteItem = await FindByIdAsync(Id);
            _context.Set<T>().Remove(deleteItem);
            await SaveAsync();
            return entity;
        }

        private async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}