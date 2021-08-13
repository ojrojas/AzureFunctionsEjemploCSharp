using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure
{
    public class GenericEfRepository<T> where T : class
    {
        protected readonly AzureFunctionsDbContext _context;

        public GenericEfRepository(AzureFunctionsDbContext context)
        {
            _context = context;
        }

        public async Task<T> Create(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await SaveAsync();
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await SaveAsync();
            return entity;
        }


        private async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}