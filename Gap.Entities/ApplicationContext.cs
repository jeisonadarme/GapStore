using Gap.Entities.Articles;
using Gap.Entities.Stores;
using Microsoft.EntityFrameworkCore;

namespace Gap.Entities
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }      
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            new StoreMap(modelBuilder.Entity<Store>());
            new ArticleMap(modelBuilder.Entity<Article>());
        }
    }
}

