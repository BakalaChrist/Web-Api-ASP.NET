using MediatR;
using WebApi2.Domaine.DTO.Reponse.Produits;

namespace WebApi2.App.Produits.Queries.GetProduitById
{
    public class GetProduitQuery : IRequest<GetProduitDto>
    {
        public GetProduitQuery(long? id)
        {
            Id = id;
        }

        public long? Id { get; set; }
    }
}
