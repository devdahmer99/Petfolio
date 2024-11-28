using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Responses;
public class ResponsePetsJson
{
    public string NomePet { get; set; } = string.Empty;
    public TipoAnimal TipoAnimal { get; set; }
}
