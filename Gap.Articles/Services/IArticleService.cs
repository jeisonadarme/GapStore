using System.Collections.Generic;
using System.Threading.Tasks;
using Gap.Entities.Articles;

namespace Gap.Articles.Services
{
    public interface IArticleService
    {
        Task Insert(Article article);

        Task<IEnumerable<Article>> GetAll();

        Task<Article> Get(int id);

        Task<IEnumerable<Article>> GetAllByStoreId(int id);
        
        Task Update(Article article);
        
        Task Delete(Article article);

        Task<IEnumerable<Article>> GetAllWithStore();
    }
}