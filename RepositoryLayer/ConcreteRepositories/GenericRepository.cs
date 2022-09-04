using CoreLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.ConcreteRepositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly CustomerManagerDbContext _context;

        public GenericRepository(CustomerManagerDbContext customerManagerDbContext)
        {
            _context = customerManagerDbContext;
            
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await Table.AddRangeAsync(entities);
        }

        public Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return Table.AnyAsync(expression);
        }

        public IQueryable<T> GetAll()
        {
            return Table.AsNoTracking().AsQueryable();

        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await Table.FindAsync(id);
        }

        public void Remove(T entity)
        {
            Table.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            Table.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            Table.Update(entity);
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return Table.Where(expression);
        }

        public async Task SaveAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
