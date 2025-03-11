using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Display(Name = "Product name")]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        [Display(Name = "Image")]
        public string ImageUrl { get; set; } = string.Empty;
        [Display(Name = "Is available")]
        public bool IsAvailable { get; set; }
        public int CategoryId { get; set; }
    }
}