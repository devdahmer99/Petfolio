using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.Register;
public class RegisterPetUseCase
{
    public ResponseCriaPetJson Execute(RequestCriaPetJson request)
    {
        return new ResponseCriaPetJson
        {
            Id = 7,
            NomePet = request.NomePet,
        };
    }
}
