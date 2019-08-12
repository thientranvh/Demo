using System.Collections.Generic;
using System.Linq;
using Demo.Data.Models;
using Demo.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Demo.Repository
{
    public class GenericRepository<T>: IRepository<T> where T:class
    {
        private readonly BookManagementContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(BookManagementContext context)
        {
            this._dbContext = context;
            this._dbSet = this._dbContext.Set<T>();
        }
        
        public IEnumerable<T> GetAll()
        {
            return this._dbSet.ToList();
        }

        public T GetById(int id)
        {
            return this._dbSet.Find(id);
        }

        public void Add(T entity)
        {
            this._dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            this._dbSet.Attach(entity);
            this._dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            this._dbSet.Remove(entity);
        }
    }
}