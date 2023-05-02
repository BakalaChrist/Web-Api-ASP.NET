using MediatR;
using WebApi2.Domaine.DTO.Reponse.Produits;

namespace WebApi2.App.Produits.Queries.GetProduit
{
    public class GetProduitsQuery : IRequest<IList<GetProduitDto>>
    {
    }
}
