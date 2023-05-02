using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi2.App.Clients.Commands.createClient;
using WebApi2.App.Clients.Commands.UpdateClient;
using WebApi2.App.Clients.Queries.DeleteClientById;
using WebApi2.App.Clients.Queries.GetClientById;
using WebApi2.Domaine.DTO.Requestes;
using WebApi2.Domaine.DTO.Requests;
using WebApi2.Domaine.Entities.Clients;

namespace WebApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("/CreateClient")]
        public async Task<IActionResult> CreateClient([FromBody] CreateClientRequest request)
        {
            var client = await _mediator.Send(new CreateClientCommand(
            request.Nom,
            request.Prenom,
            request.Email,
            request.Adresse));

            return Ok(client);
        }

        [HttpPut("/UpdateClient")]
        public async Task<IActionResult> UpdateClient([FromBody] UpdateClientRequest request)
        {
            var client = await _mediator.Send(new UpdateClientCommand(
            request.Id,
            request.Nom,
            request.Prenom,
            request.Email,
            request.Adresse));

            return Ok(client);
        }

        [HttpGet("/getClient/{id}")]
        public async Task<IActionResult> GetClient(long id)
        {
            var client = await _mediator.Send(new GetClientQuery(id));

            if (client != null)
            {
                return Ok(client);
            }

            return NotFound($"No Client in database with ID: {id}.");

        }

        [HttpDelete("/DeleteClientById/{id}")]
        public async Task<IActionResult> DeleteClientById(long id)
        {
            var client = await _mediator.Send(new DeleteClientQuery(id));

            if (client != null)
            {
                return Ok(client);
            }

            return NotFound($"Client is deleted with ID: {id}.");
        }

       
    }
}
