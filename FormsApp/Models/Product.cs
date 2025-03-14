using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FormsApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Display(Name = "Product name")]
        [Required(ErrorMessage = "Please enter a product name")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; } = string.Empty;

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Please enter a price")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive price")]
        public decimal Price { get; set; }

        [Display(Name = "Image")]
        public string? ImageUrl { get; set; }

        [Display(Name = "Is available")]
        [Required(ErrorMessage = "Please enter availability")]
        public bool IsAvailable { get; set; }
        public int CategoryId { get; set; }
    }
}