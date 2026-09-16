using System.ComponentModel.DataAnnotations;

public class CreateProduct
{
    [Required(ErrorMessage = "اسم المنتج مطلوب.")]
    [MaxLength(100)]
    public string name { get; set; } = string.Empty;

    [Required]
    [Range(0.01, double.MaxValue)]
    public int price { get; set; }
}
