using System.ComponentModel.DataAnnotations;

namespace InventoryMVC.Models;

public class Product
{
    public int Id { get; set; }

    [Required]
    [Display(Name = "Product Name")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [Display(Name = "SKU / Code")]
    public string SKU { get; set; } = string.Empty;

    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "Quantity cannot be negative")]
    public int Quantity { get; set; }

    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "Price cannot be negative")]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }
}
