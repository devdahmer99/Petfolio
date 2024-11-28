using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pet.Delete;
using Petfolio.Application.UseCases.Pet.Get;
using Petfolio.Application.UseCases.Pet.Register;
using Petfolio.Application.UseCases.Pet.Update;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PetsController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseCriaPetJson),StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
    public IActionResult CriaRegistroPet([FromBody] RequestCriaPetJson requestPet)
    {
        var useCase = new RegisterPetUseCase();
        var response = useCase.Execute(requestPet);

        return Created(string.Empty, response);
    }

    [HttpPut()]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseAtualizaPetJson), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
    public IActionResult AtualizaPet([FromRoute] int id, [FromBody] RequestAtualizaPetJson request)
    {
        var useCase = new UpdatePetUseCase();
        var response = useCase.Execute(request);

        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<ResponseAllPetsJson>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
    public IActionResult BuscarTodosPets()
    {
        var useCase = new GetUseCase();

        var response = useCase.Execute();

        if(response.Pets.Any())
        {
            return Ok(response.Pets);
        }

        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponsePetsJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
    public IActionResult BuscaPetPorId([FromRoute]int id)
    {
        var useCase = new GetPetId();
        var response = useCase.Execute(id);

        return Ok(response);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponsePetsJson), StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrosJson), StatusCodes.Status400BadRequest)]
    public IActionResult Delete([FromRoute]int id)
    {
        var useCase = new DeletePetUseCase();

        useCase.Execute(id);

        return NoContent();
    }
}
