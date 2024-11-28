using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pet.Get;
public class GetUseCase
{
    public ResponseAllPetsJson Execute()
    {
        return new ResponseAllPetsJson
        {
           Pets = new List<ResponsePetsJson>
           {
               new ResponsePetsJson
               {
                    NomePet = "Taz",
                    TipoAnimal = Communication.Enums.TipoAnimal.Cachorro
               }
           }
        };
    }
}
