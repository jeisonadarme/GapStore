using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gap.Entities.Stores
{
    public class StoreMap
    {
        public StoreMap(EntityTypeBuilder<Store> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);

            entityTypeBuilder.Property(x => x.Name).IsRequired();
            entityTypeBuilder.Property(x => x.Address).IsRequired();
            
            entityTypeBuilder.Property(x => x.Name).HasMaxLength(50);
            entityTypeBuilder.Property(x => x.Address).HasMaxLength(250);
        }
    }
}