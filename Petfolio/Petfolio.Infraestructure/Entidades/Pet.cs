using System.ComponentModel.DataAnnotations;

namespace Petfolio.Infraestructure.Entidades;
public class Pet
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string NomePet { get; set; } = string.Empty;
    [Required]
    public required Enum TipoAnimal { get; set; }
}
