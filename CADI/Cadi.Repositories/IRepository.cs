using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Cadi.Repositories
{
   public  interface IRepository<T,V> where T:class
    {
        bool Delete(T entity);
        bool Update(T entity);
        int Insert(T entity);
        IEnumerable<T> GetList();
        T GetById( V id);
      //  List<T> filter(Expression<Func<T, bool>> predicate);
    }
}
