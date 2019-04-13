using System;
using System.Collections.Generic;
using System.Linq;

namespace Clockwork.Data
{
    public interface IRepository<TEntity> where TEntity: class
    {
        TEntity Get(object id);

        IEnumerable<TEntity> GetAll(
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            bool disableTracking = false);

        void Add(TEntity entity);

        void Commit();
    }
}
