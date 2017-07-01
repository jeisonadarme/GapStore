using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Gap.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace Gap.Entities
{
    public class GenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ApplicationContext _context;

        internal DbSet<TEntity> Entities;
        
        public GenericRepository(ApplicationContext context)
        {
            _context = context;
            this.Entities = context.Set<TEntity>();
        }
        
        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = Entities;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }
        
        public IEnumerable<TEntity> GetAll()
        {
            return Entities.AsEnumerable();
        }

        
        public TEntity Get(int id)
        {
            return Entities.SingleOrDefault(s => s.Id == id);
        }
        public void Insert(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            Entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            Entities.Remove(entity);
            _context.SaveChanges();
        }
    }
}