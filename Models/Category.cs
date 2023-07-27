using System.ComponentModel.DataAnnotations;
using BlazorShop.Data;

namespace BlazorShop.Models;

public class Category
{
    public Category() { }
    public Category(string name)
    {
        Name = name;
    }

    public int Id { get; set; }

    [Required(ErrorMessage = "O nome não pode ser nulo e deve conter pelo menor 5 caracteres.")]
    [MinLength(5, ErrorMessage = "A categoria deve conter pelo menos 5 caracteres.")]
    [MaxLength(50, ErrorMessage = "A categoria deve conter no máximo 50 caracteres.")]
    public string Name { get; set; }

    public List<Product> Products { get; set; }
}
