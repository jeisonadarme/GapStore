using System.Collections.Generic;
using Gap.Entities.Stores;

namespace Gap.Stores.Services
{
    public interface IStoreService
    {
        void Insert(Store store);

        IEnumerable<Store> GetAll();
    }
}