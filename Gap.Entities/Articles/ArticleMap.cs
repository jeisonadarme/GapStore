using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gap.Entities.Articles
{
    public class ArticleMap
    {
        public ArticleMap(EntityTypeBuilder<Article> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);
            entityTypeBuilder.Property(x => x.StoreId).IsRequired();
            
            entityTypeBuilder.Property(x => x.Name).IsRequired();
            entityTypeBuilder.Property(x => x.Description).IsRequired();
            entityTypeBuilder.Property(x => x.Price).IsRequired();
            entityTypeBuilder.Property(x => x.TotalInShelf).IsRequired();
            entityTypeBuilder.Property(x => x.TotalInVault).IsRequired();
            
            entityTypeBuilder.Property(x => x.Name).HasMaxLength(50);
            entityTypeBuilder.Property(x => x.Description).HasMaxLength(250);
            
        }
    }
}