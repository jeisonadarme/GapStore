using System.ComponentModel.DataAnnotations;

namespace Gap.SuperZapatos.Models
{
    public class StoreModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}