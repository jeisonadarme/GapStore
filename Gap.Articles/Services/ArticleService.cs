using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Gap.Articles.Repository;
using Gap.Entities.Articles;
using Microsoft.Extensions.Logging;

namespace Gap.Articles.Services
{
    public class ArticleService : IArticleService
    {
        
        private readonly IArticleRepository _repository;
        private readonly ILogger<ArticleService> _logger;

        public ArticleService(IArticleRepository repository, ILogger<ArticleService> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        
        public async Task Insert(Article article)
        {
            try
            {
                article.AddedDate = DateTime.Now;
                article.ModifiedDate = DateTime.Now;
                
                await _repository.Insert(article);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }

        public async Task<IEnumerable<Article>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Article> Get(int id)
        {
            return await _repository.Get(id);
        }

        public async Task<IEnumerable<Article>> GetAllByStoreId(int id)
        {
            return await _repository.GetAllBy(x => x.StoreId == id, null, "Store");
        }

        public async Task Update(Article article)
        {
            try{
                await _repository.Update(article);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }

        public async Task Delete(Article article)
        {
            try{
                await _repository.Delete(article);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }

        public async Task<IEnumerable<Article>> GetAllWithStore()
        {
            return await _repository.GetAllWithStore();
        }
    }
}