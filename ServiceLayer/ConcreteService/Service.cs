using CoreLayer.AbstractService;
using CoreLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer;
using RepositoryLayer.ConcreteRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ConcreteService
{
    public class Service<T> : IService<T> where T : class
    {
        public GenericRepository<T> _repository = new GenericRepository<T>(new CustomerManagerDbContext());


        public async Task<T> AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            await _repository.SaveAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entites)
        {
            await _repository.AddRangeAsync(entites);
            await _repository.SaveAsync();
            return entites;
        }

        public async Task<bool> AnyAsync(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return await _repository.AnyAsync(expression);
            
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAll().ToListAsync() ;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            _repository.Remove(entity);
            await _repository.SaveAsync();

        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities)
        {
            _repository.RemoveRange(entities);
            await _repository.SaveAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _repository.Update(entity);
            await _repository.SaveAsync();
        }

        public IQueryable<T> Where(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return _repository.Where(expression);
        }
    }
}
