using System.ComponentModel.DataAnnotations;

namespace P1_AP1_SAMILCRUZ.Models;

public class Registro
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Nombre es requerido")]
    public string Nombres { get; set; }
}
