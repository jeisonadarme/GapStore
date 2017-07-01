using System.Collections.Generic;
using System.Threading.Tasks;
using Gap.Entities.Stores;

namespace Gap.Stores.Services
{
    public interface IStoreService
    {
        Task Insert(Store store);

        Task<IEnumerable<Store>> GetAll();

        Task<Store> Get(int id);
        
        Task Update(Store store);
        
        Task Delete(Store store);
    }
}