using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("Category name")]
        public string Name { get; set; }

        [Range(1, 100)]
        [DisplayName("Display order")]
        public int DisplayOrder { get; set; }
    }
}
