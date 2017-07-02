using System.ComponentModel.DataAnnotations;

namespace Gap.SuperZapatos.Models
{
    public class ArticleModel
    {
        public int Id { get; set; }
        [Required]
        public int StoreId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int TotalInShelf { get; set; }
        [Required]
        public int TotalInVault { get; set; }

        public string StoreName { get; set; }
    }
}