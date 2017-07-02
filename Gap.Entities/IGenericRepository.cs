using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Gap.Entities.Common;

namespace Gap.Entities
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task Insert(T entity);        
        Task Update(T entity);
        Task Delete(T entity);

        Task<IEnumerable<T>> GetAllBy(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "");
    }
}