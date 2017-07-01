using System;
using Gap.Entities.Stores;
using Microsoft.Extensions.Logging;

namespace Gap.Stores.Services
{
    public class StoreService : IStoreService
    {
        private readonly IStoreRepository _repository;
        private readonly ILogger<StoreService> _logger;

        public StoreService(IStoreRepository repository, ILogger<StoreService> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        
        public void Create(Store store)
        {
            try
            {
                _repository.create(store);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }
    }
}