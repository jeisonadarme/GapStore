using System.Collections.Generic;
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
    }
}