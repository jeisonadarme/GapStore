using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        
        public async Task Insert(Store store)
        {
            try
            {
                store.AddedDate = DateTime.Now;
                store.ModifiedDate = DateTime.Now;
                
                await _repository.Insert(store);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }

        public async Task<IEnumerable<Store>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Store> Get(int id)
        {
            return await _repository.Get(id);
        }

        public async Task Update(Store store)
        {
            try{
               await _repository.Update(store);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }

        public async Task Delete(Store store)
        {
            try{
                await _repository.Delete(store);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }
    }
}