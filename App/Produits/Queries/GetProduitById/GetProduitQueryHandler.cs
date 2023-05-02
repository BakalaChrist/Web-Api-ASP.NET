using MediatR;
using Microsoft.EntityFrameworkCore;
using WebApi2.Domaine.DTO.Reponse.Produits;
using WebApi2.Infra.Repository.Context;

namespace WebApi2.App.Produits.Queries.GetProduitById
{
    public class GetProduitQueryHandler : IRequestHandler<GetProduitQuery, GetProduitDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetProduitQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetProduitDto> Handle(GetProduitQuery request, CancellationToken cancellationToken)
        {
            var Produit = await _dbContext.Produits.Where(x => x.Id == request.Id).FirstOrDefaultAsync();

            if (Produit != null)
            {
                var ProduitItem = Produit.MapTo();
                return ProduitItem;
            }
            return null;
        }
    }
}
