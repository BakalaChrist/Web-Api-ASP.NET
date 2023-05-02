using MediatR;
using WebApi2.Infra.Repository.Context;
using WebApi2.Domaine.DTO.Reponse.Produits;
using Microsoft.EntityFrameworkCore;

namespace WebApi2.App.Produits.Queries.GetProduit
{
    public class GetProduitsQueryHandler : IRequestHandler<GetProduitsQuery, IList<GetProduitDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetProduitsQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<GetProduitDto>> Handle(GetProduitsQuery request, CancellationToken cancellationToken)
        {
            var produits = await _dbContext.Produits.ToListAsync();
            var produitList = new List<GetProduitDto>();
            foreach (var Item in produits)
            {
                var produit = Item.MapTo();
                produitList.Add(produit);
            }

            return produitList;
        }
    }
}
