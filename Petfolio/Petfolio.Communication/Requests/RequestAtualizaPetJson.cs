using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Requests;
public class RequestAtualizaPetJson
{
    public string NomePet { get; set; } = string.Empty;
    public TipoAnimal TipoAnimal { get; set; }
}
