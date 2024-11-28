using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.Update;
public class UpdatePetUseCase
{
    public ResponseAtualizaPetJson Execute(RequestAtualizaPetJson request)
    {
        return new ResponseAtualizaPetJson
        {
            NomePet = request.NomePet,
            TipoAnimal = request.TipoAnimal.ToString(),
        };
    }
}
