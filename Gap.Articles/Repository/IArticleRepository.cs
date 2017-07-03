using System.Collections.Generic;
using System.Threading.Tasks;
using Gap.Entities;
using Gap.Entities.Articles;

namespace Gap.Articles.Repository
{
    public interface IArticleRepository : IGenericRepository<Article>
    {
        Task<IEnumerable<Article>> GetAllWithStore();
        
        Task<Article> GetWithStore(int id);
    }
}