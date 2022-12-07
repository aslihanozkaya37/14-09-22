using System.ComponentModel.DataAnnotations;

namespace KitaplikUygulama.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Name can not be longer than 10 characters")]
        public string Name { get; set; }
        [Range(1, 100, ErrorMessage = "Display order should be between 1 and 100")]
        public int DisplayOrder { get; set; }
        public DateTime? CreatedDateTime { get; set; } = DateTime.Now;
    }
}
