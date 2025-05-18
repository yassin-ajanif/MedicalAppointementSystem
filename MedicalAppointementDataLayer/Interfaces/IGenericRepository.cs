using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointementDataLayer.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        // CREATE
        bool Add(TEntity entity);

        // READ
        IEnumerable<TEntity> GetAll();
        Task<IEnumerable<TEntity>> GetAllAsync();  // Async version

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);  // Async version

        TEntity GetById(object id);
        Task<TEntity> GetByIdAsync(object id);  // Async version

        // UPDATE
        bool Update(TEntity entity);
        Task<bool> UpdateAsync(TEntity entity);  // Async version

        // DELETE
        bool Delete(object id);
        Task<bool> DeleteAsync(object id);  // Async version

     
    }
}
