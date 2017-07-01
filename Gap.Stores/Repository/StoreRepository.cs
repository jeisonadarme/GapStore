using System.Collections.Generic;
using Gap.Entities;
using Gap.Entities.Stores;

namespace Gap.Stores.Services
{
    public class StoreRepository : GenericRepository<Store>, IStoreRepository
    {
        private readonly ApplicationContext _context;

        public StoreRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

    }
}