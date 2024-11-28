using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.Get;
public class GetPetId
{
    public ResponsePetsJson Execute(int id)
    {
        return new ResponsePetsJson {
            NomePet = "Sailor", TipoAnimal = Communication.Enums.TipoAnimal.Gato
        };
    }
}
