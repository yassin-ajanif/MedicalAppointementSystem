using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using MedicalAppointementDataLayer.Interfaces;

namespace MedicalAppointementDataLayer.Repositories
{
    // public class GenericRepository<TEntity> where TEntity : class
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = _context.Set<TEntity>();
        }

        // CREATE
        public bool Add(TEntity entity)
        {
            try
            {
                _dbSet.Add(entity);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                // Log error here
                return false;
            }
        }
  

        // READ
        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public async Task<TEntity> GetByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        // UPDATE
        public bool Update(TEntity entity)
        {
            try
            {
                _dbSet.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                // Log error here
                return false;
            }
        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            try
            {
                _dbSet.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                // Log error here
                return false;
            }
        }

        // DELETE
        public bool Delete(object id)
        {
            try
            {
                var entity = _dbSet.Find(id);
                if (entity == null) return false;

                _dbSet.Remove(entity);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                // Log error here
                return false;
            }
        }

        public async Task<bool> DeleteAsync(object id)
        {
            try
            {
                var entity = await _dbSet.FindAsync(id);
                if (entity == null) return false;

                _dbSet.Remove(entity);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                // Log error here
                return false;
            }
        }

      
     

     
    }
}

