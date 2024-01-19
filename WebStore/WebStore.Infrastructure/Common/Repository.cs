using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebStore.Infrastructure.Data;

namespace WebStore.Infrastructure.Common
{
    /// <summary>
    /// Abstraction of repository access methods
    /// </summary>
    public class Repository : IRepository
    {
        private readonly WebStoreDbContext context;

        protected DbSet<T> DbSet<T>() where T : class
        {
            return context.Set<T>();
        }

        public Repository(WebStoreDbContext context)
        {
            this.context = context;
        }

        public async Task AddAsync<T>(T entity) where T : class
        {
            await DbSet<T>().AddAsync(entity);
        }

        public async Task AddRangeAsync<T>(IEnumerable<T> entities) where T : class
        {
            await DbSet<T>().AddRangeAsync(entities);
        }

        public IQueryable<T> All<T>() where T : class
        {
            return DbSet<T>().AsQueryable();
        }

        public IQueryable<T> All<T>(Expression<Func<T, bool>> search) where T : class
        {
            return DbSet<T>().Where(search).AsQueryable();
        }

        public IQueryable<T> AllReadonly<T>() where T : class
        {
            return DbSet<T>().AsNoTracking();
        }

        public IQueryable<T> AllReadonly<T>(Expression<Func<T, bool>> search) where T : class
        {
            return DbSet<T>().Where(search).AsNoTracking();
        }

        public void Delete<T>(T entity) where T : class
        {
            var dbEntityEntry = context.Entry(entity);           //TODO: see if this would work properly?? idk 
                                                                 //TODO: see if this would work properly?? idk 
            if (dbEntityEntry.State != EntityState.Deleted)      //TODO: see if this would work properly?? idk 
            {                                                    //TODO: see if this would work properly?? idk 
                dbEntityEntry.State = EntityState.Deleted;       //TODO: see if this would work properly?? idk 
            }                                                    //TODO: see if this would work properly?? idk 
            else                                                 //TODO: see if this would work properly?? idk 
            {                                                    //TODO: see if this would work properly?? idk 
                DbSet<T>().Attach(entity);                       //TODO: see if this would work properly?? idk 
                DbSet<T>().Remove(entity);                       //TODO: see if this would work properly?? idk 
            }
        }

        public async Task DeleteAsync<T>(object id) where T : class
        {
            var entity = await GetByIdAsync<T>(id);

            if (entity == null)
            {
                throw new InvalidOperationException("Entity not found");
            }

            await DeleteAsync<T>(entity);
        }

        public void DeleteRange<T>(IEnumerable<T> entities) where T : class
        {
            DbSet<T>().RemoveRange(entities);
        }

        public void DeleteRange<T>(Expression<Func<T, bool>> deleteWhereClause) where T : class
        {
            var entities = DbSet<T>().Where(deleteWhereClause).AsEnumerable();

            if (entities == null)
            {
                throw new InvalidOperationException("Entity not found");
            }

            DeleteRange(entities);
        }

        public void Detach<T>(T entity) where T : class
        {
            var dbEntityEntry = context.Entry(entity);

            if (dbEntityEntry.State != EntityState.Detached)
            {
                dbEntityEntry.State = EntityState.Detached;
            }
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public async Task<T> GetByIdAsync<T>(object id) where T : class
        {
            var entity = await DbSet<T>().FindAsync(id);

            if (entity == null)
            {
                throw new InvalidOperationException("Entity not found");
            }

            return entity;
        }

        public async Task<T> GetByIdsAsync<T>(object[] ids) where T : class
        {
            var entities = await DbSet<T>().FindAsync(ids);

            if (entities == null)
            {
                throw new InvalidOperationException("Entity not found");
            }

            return entities;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }

        public void Update<T>(T entity) where T : class
        {
            DbSet<T>().Update(entity);
        }

        public void UpdateRange<T>(IEnumerable<T> entities) where T : class
        {
            DbSet<T>().UpdateRange(entities);
        }
    }
}
