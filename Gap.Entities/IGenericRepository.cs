using System.Collections.Generic;
using Gap.Entities.Common;

namespace Gap.Entities
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Insert(T entity);        
        void Update(T entity);
        void Delete(T entity);
    }
}