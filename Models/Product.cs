using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BlazorShop.Models;

public class Product
{
    public Product() { }
    public Product(string name, string description, decimal price, int categoryId)
    {
        Name = name;
        Description = description;
        Price = price;
        CategoryId = categoryId;
    }

    public int Id { get; set; }

    [Required(ErrorMessage = "O nome não pode ser nulo e deve conter pelo menor 5 caracteres.")]
    [MinLength(5, ErrorMessage = "O nome do produto deve conter pelo menos 5 caracteres.")]
    [MaxLength(150, ErrorMessage = "O nome do produto deve conter pelo menos 150 caracteres.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "A descrição não pode ser nula e deve conter pelo menor 10 caracteres.")]
    [MinLength(10, ErrorMessage = "A descrição do produto deve conter pelo menos 10 caracteres.")]
    public string Description { get; set; }

    [Required(ErrorMessage = "O preço não pode ser nulo e deve estar entre 0 e 100.000.")]
    [DataType(DataType.Currency)]
    [Range(0, 9999, ErrorMessage = "O preço do produto deve ser entre 0 e 100.000")]
    public decimal Price { get; set; }

    [Required]
    public int CategoryId { get; set; }

    public Category Category { get; set; } = null!;
}
