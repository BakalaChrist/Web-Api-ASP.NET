using MediatR;
using WebApi2.Domaine.DTO.Reponse.Produits;

namespace WebApi2.App.Produits.Queries.DeleteProduitById
{
    public class DeleteProduitQuery : IRequest<GetProduitDto>
    {

        public DeleteProduitQuery(long? id)
        {
            Id = id;
        }

        public long? Id { get; set; }
    }
}
