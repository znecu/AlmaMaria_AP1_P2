using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlmaMaria_AP1_P2.Models;

public class CombosDetalle
{
    [Key]
    public int DetalleId { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "En este campo solo se permiten numeros")]
    public int Cantidad { get; set; }

    [Required(ErrorMessage = "Este campo es obligatorio")]
    [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "En este campo solo se permiten numeros")]
    public double Costo { get; set; }


    public int ArticuloId { get; set; }
    [ForeignKey("ArticuloId")]
    public Articulos? Articulos { get; set; }


    public int CombosId {  get; set; }  
    [ForeignKey("CombosId")]
    public Combos? Combos { get; set; }


}
