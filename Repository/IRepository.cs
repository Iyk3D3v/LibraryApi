using System.Linq.Expressions;
using System;
using System.Collections.Generic;

namespace NetLibraryAPI.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity: class 
    {
        
        void Insert(TEntity t);

        void Delete(TEntity t);

        void Update(TEntity t);

        IEnumerable<TEntity> GetAll();


        IEnumerable<TEntity> GetByConditionNoTracking(Func<TEntity,bool> where);

        IEnumerable<TEntity> GetByNoTracking(Expression<Func<TEntity,bool>> where);
    }
   
}