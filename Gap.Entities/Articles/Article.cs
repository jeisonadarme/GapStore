using Gap.Entities.Common;
using Gap.Entities.Stores;

namespace Gap.Entities.Articles
{
    public class Article : BaseEntity
    {
        public int StoreId { get; set; }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int TotalInShelf { get; set; }
        public int TotalInVault { get; set; }

        public virtual Store Store { get; set; }
    }
}