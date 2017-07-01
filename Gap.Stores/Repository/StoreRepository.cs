using Gap.Entities;
using Gap.Entities.Stores;

namespace Gap.Stores.Services
{
    public class StoreRepository :IStoreRepository
    {
        private readonly ApplicationContext _context;

        public StoreRepository(ApplicationContext context)
        {
            _context = context;
        }

        public void create(Store store)
        {
            _context.Add(store);
            _context.SaveChanges();
        }
    }
}