using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gap.Entities.Stores
{
    public class StoreMap
    {
        public StoreMap(EntityTypeBuilder<Store> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);

            entityTypeBuilder.Property(x => x.Name).IsRequired();
            entityTypeBuilder.Property(x => x.Adress).IsRequired();
            
            entityTypeBuilder.Property(x => x.Name).HasMaxLength(50);
            entityTypeBuilder.Property(x => x.Adress).HasMaxLength(250);
        }
    }
}