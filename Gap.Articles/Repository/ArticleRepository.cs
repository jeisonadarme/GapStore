using System.Collections.Generic;
using System.Threading.Tasks;
using Gap.Entities;
using Gap.Entities.Articles;
using Microsoft.EntityFrameworkCore;

namespace Gap.Articles.Repository
{
    public class ArticleRepository : GenericRepository<Article>, IArticleRepository
    {
        private readonly ApplicationContext _context;
        internal DbSet<Article> Entities;
        public ArticleRepository(ApplicationContext context) : base(context)
        {
            _context = context;
            this.Entities = context.Set<Article>();
        }

        public async Task<IEnumerable<Article>> GetAllWithStore()
        {
            return await Entities.Include(x => x.Store).ToListAsync();
        }
    }
}