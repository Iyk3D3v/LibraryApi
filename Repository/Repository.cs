using System.Linq;
using Microsoft.EntityFrameworkCore;
using NetLibraryAPI.Models;

namespace NetLibraryAPI.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class 
   
    {
        private DbSet<TEntity> _dbSet;
        private DataContext _context; 
        public Repository(DataContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public void Delete(TEntity t)
        {
            if(t != null)
                {
                _dbSet.Remove(t);
            }
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<TEntity> GetAll()
        {
           return _dbSet.ToList();
        }

        public System.Collections.Generic.IEnumerable<TEntity> GetByConditionNoTracking(System.Func<TEntity, bool> where)
        {
            return _dbSet.AsNoTracking().Where(where).AsQueryable<TEntity>();
        }

        public System.Collections.Generic.IEnumerable<TEntity> GetByNoTracking(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> where)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(TEntity t)
        {
           if(t != null)
           {
               _dbSet.Add(t);
           }
        }

        public void Update(TEntity t)
        {
            if(t!= null)
            {
                _context.Entry(t).State = EntityState.Detached;
            }
            _dbSet.Attach(t);
            _context.Entry(t).State =EntityState.Modified;
        }
    }
}