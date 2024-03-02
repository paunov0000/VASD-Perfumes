using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Infrastructure.Common
{


    /// <summary>
    /// Abstraction of repository access methods
    /// </summary>
    public interface IRepository : IDisposable
    {
        /// <summary>
        /// All records in a table
        /// </summary>
        /// <returns>Queryable expression tree</returns>
        IQueryable<T> All<T>() where T : class;

        /// <summary>
        /// All records in a table by given where clause
        /// </summary>
        /// <returns>Queryable expression tree</returns>
        IQueryable<T> All<T>(Expression<Func<T, bool>> search) where T : class;

        /// <summary>
        /// The result collection won't be tracked by the context
        /// </summary>
        /// <returns>Expression tree</returns>
        IQueryable<T> AllReadonly<T>() where T : class;

        /// <summary>
        /// The result collection by given where clause won't be tracked by the context
        /// </summary>
        /// <returns>Expression tree</returns>
        IQueryable<T> AllReadonly<T>(Expression<Func<T, bool>> search) where T : class;

        /// <summary>
        /// Gets specific record from database by primary key
        /// </summary>
        /// <param name="id">record identificator</param>
        /// <returns>Single record</returns>
        /// <exception cref="InvalidOperationException">Throws an InvalidOperationException when the entity is not found</exception>
        Task<T> GetByIdAsync<T>(object id) where T : class;


        /// <summary>
        /// Gets specific records from database by primary keys
        /// </summary>
        /// <param name="ids">record identificators</param>
        /// <returns>Array of records</returns>
        Task<T> GetByIdsAsync<T>(object[] ids) where T : class;

        /// <summary>
        /// Adds entity to the database
        /// </summary>
        /// <param name="entity">Entity to add</param>
        Task AddAsync<T>(T entity) where T : class;

        /// <summary>
        /// Adds collection of entities to the database
        /// </summary>
        /// <param name="entities">Enumerable collection of entities</param>
        Task AddRangeAsync<T>(IEnumerable<T> entities) where T : class;

        /// <summary>
        /// Updates a record in database
        /// </summary>
        /// <param name="entity">Entity for record to be updated</param>
        void Update<T>(T entity) where T : class;

        /// <summary>
        /// Updates set of records in the database
        /// </summary>
        /// <param name="entities">Enumerable collection of entities to be updated</param>
        void UpdateRange<T>(IEnumerable<T> entities) where T : class;

        /// <summary>
        /// Deletes a record from database
        /// </summary>
        /// <param name="id">Identificator of record to be deleted</param>
        Task DeleteAsync<T>(object id) where T : class;

        /// <summary>
        /// Deletes a record from database
        /// </summary>
        /// <param name="entity">Entity representing record to be deleted</param>
        void Delete<T>(T entity) where T : class;

        /// <summary>
        /// Deletes a set of records from database
        /// </summary>
        /// <param name="entities">An IEnumerable collection of entities to be deleted</param>
        void DeleteRange<T>(IEnumerable<T> entities) where T : class;

        /// <summary>
        /// Deletes a set of records from database by given where clause
        /// </summary>
        void DeleteRange<T>(Expression<Func<T, bool>> deleteWhereClause) where T : class;


        /// <summary>
        /// Detaches given entity from the context
        /// </summary>
        /// <param name="entity">Entity to be detached</param>
        void Detach<T>(T entity) where T : class;

        /// <summary>
        /// Saves all made changes in trasaction
        /// </summary>
        /// <returns>Error code</returns>
        Task<int> SaveChangesAsync();
    }
}
