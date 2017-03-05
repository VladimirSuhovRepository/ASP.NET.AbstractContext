using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AbstractContext
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int key);
        TEntity GetByPredicate(Expression<Func<TEntity, bool>> f);
        void Create(TEntity e);
        void Delete(TEntity e);
        void Update(TEntity entity);
    }
}
