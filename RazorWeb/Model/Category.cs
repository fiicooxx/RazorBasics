using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RazorWeb.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name="Display Order")]
        [Range(0,100, ErrorMessage = "Display Order must be from 0 to 100!")]
        public int DisplayOrder { get; set; }
    }
}
