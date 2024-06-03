using HotelProject.Data.Context;
using HotelProject.Data.Repostories.Abstraction;
using HotelProject.Entity.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Data.Repostories.Concrets
{
    public class Repository<T> : IRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _appDbContext;

        public Repository(AppDbContext _appDbContext)
        {
            this._appDbContext = _appDbContext;
        }

        private DbSet<T> Table { get => _appDbContext.Set<T>();}


        public async Task AddAsync(T entity)
        {
             await Table.AddAsync(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await Table.AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null)
        {
            if(predicate is not null) 
                return await Table.CountAsync(predicate);
            return await Table.CountAsync();

        }

        public Task DeleteAsync(T entity)
        {
            return Task.Run(() => Table.Remove(entity));
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            if (predicate is not null) 
                query = query.Where(predicate); 

            if(includeProperties.Any())
                foreach (var item in includeProperties)
                {
                    query.Include(item);
                }

            return await query.ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate , params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            query = query.Where(predicate);

            if (includeProperties.Any())
                foreach (var item in includeProperties)
                    query = query.Include(item);

            return await query.SingleAsync();
        }

        public async Task<T> GetByGuidAsync(Guid? Id)
        {
            return await Table.FindAsync(Id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(()=>Table.Update(entity));   
            return entity;
        }
    }
}
