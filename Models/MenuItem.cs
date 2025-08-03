using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelPortal.Models
{
    public class MenuItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Item name is required")]
        [StringLength(100, ErrorMessage = "Item name cannot exceed 100 characters")]
        public string Name { get; set; } = string.Empty;

        [StringLength(300, ErrorMessage = "Description cannot exceed 300 characters")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 10000, ErrorMessage = "Price must be between 0.01 and 10,000")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Category is required")]
        [StringLength(50, ErrorMessage = "Category cannot exceed 50 characters")]
        public string Category { get; set; } = string.Empty;

        public string? ImageUrl { get; set; }

        public bool IsAvailable { get; set; } = true;

        public bool IsVegetarian { get; set; } = false;

        public bool IsVegan { get; set; } = false;

        public bool IsGlutenFree { get; set; } = false;

        [StringLength(100, ErrorMessage = "Allergen information cannot exceed 100 characters")]
        public string? AllergenInfo { get; set; }

        [Range(0, 5000, ErrorMessage = "Calories must be between 0 and 5000")]
        public int? Calories { get; set; }

        [Range(1, 60, ErrorMessage = "Preparation time must be between 1 and 60 minutes")]
        public int? PreparationTimeMinutes { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? UpdatedDate { get; set; }

        // Foreign key
        [Required]
        public int HotelId { get; set; }

        // Navigation property
        [ForeignKey("HotelId")]
        public Hotel Hotel { get; set; } = null!;
    }
}