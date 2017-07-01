using Gap.Entities.Stores;

namespace Gap.Stores.Services
{
    public interface IStoreRepository
    {
        void create(Store  store);
    }
}