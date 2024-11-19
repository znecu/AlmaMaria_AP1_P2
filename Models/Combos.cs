using System.ComponentModel.DataAnnotations;

namespace AlmaMaria_AP1_P2.Models;

public class Combos
{
    [Key]
    public int CombosId { get; set; }

    [Required]
    public DateTime Fecha {  get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "En este campo solo se permiten letras. ")]
    public string? Descripcion {  get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "En este campo solo se permiten numeros")]
    public double Precio {  get; set; }    

    [Required]
    public bool Vendido { get; set; }    
}
