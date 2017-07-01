using System;
using System.Collections.Generic;
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
        
        public void Insert(Store store)
        {
            try
            {
                _repository.Insert(store);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }

        public IEnumerable<Store> GetAll()
        {
            return _repository.GetAll();
        }
    }
}