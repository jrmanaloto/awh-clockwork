using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clockwork.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ClockworkContext _context;
        private DbSet<TEntity> _entity;

        public Repository(ClockworkContext context)
        {
            _context = context;
            _entity = context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _entity.Add(entity);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public TEntity Get(object id)
        {
            return _entity.Find(id);
        }

        public IEnumerable<TEntity> GetAll(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, bool disableTracking = false)
        {

            IQueryable<TEntity> query = _entity;

            if (disableTracking)
            {
                query.AsNoTracking();
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            return query;
        }
    }
}
