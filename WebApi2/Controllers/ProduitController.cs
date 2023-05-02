using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi2.App.Produits.Commands.createProduit;
using WebApi2.Domaine.DTO.Requestes;
using WebApi2.App.Produits.Queries.GetProduit;
using WebApi2.App.Produits.Queries.GetProduitById;
using WebApi2.App.Produits.Queries.DeleteProduitById;
using WebApi2.App.Produits.Commands.UpdateProduit;
using WebApi2.Domaine.DTO.Requests;

namespace WebApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduitController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProduitController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("/CreateProduit")]
        public async Task<IActionResult> CreateProduit([FromBody] CreateProduitRequest request)
        {
            var Produit = await _mediator.Send(new CreateProduitCommand(
            request.Designation,
            request.Description,
            request.Qte,
            request.Prix,
            request.TypeProduit));

            return Ok(Produit);
        }

        [HttpPut("UpdateProduit")]
        public async Task<IActionResult> UpdateProduit([FromBody] UpdateProduitRequest request)
        {
            var Produit = await _mediator.Send(new UpdateProduitCommand(
            request.Id,
            request.Designation,
            request.Description,
            request.Qte,
            request.Prix,
            request.TypeProduit));

            return Ok(Produit);
        }


        [HttpGet("/GetProduits/{id}")]
        public async Task<IActionResult> GetProduit(long id)
        {
            var Produit = await _mediator.Send(new GetProduitQuery(id));

            if (Produit != null)
            {
                return Ok(Produit);
            }

            return NotFound($"No Produit in database with ID: {id}.");

        }

        [HttpDelete("/DeleteProduitById/{id}")]
        public async Task<IActionResult> DeleteById(long id)
        {
            var Produit = await _mediator.Send(new DeleteProduitQuery(id));

            if (Produit != null)
            {
                return Ok(Produit);
            }

            return NotFound($"Product is deleted with ID: {id}.");
        }

        [HttpGet("ListProduit")]
        public async Task<IActionResult> GetProduits()
        {
            var Produits = await _mediator.Send(new GetProduitsQuery());

            if (Produits != null)
            {
                return Ok(Produits);
            }

            return NotFound("No Produits in database. Please add a Produit first.");
        }
    }
}
