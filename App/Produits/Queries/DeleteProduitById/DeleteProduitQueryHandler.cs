using MediatR;
using Microsoft.EntityFrameworkCore;
using WebApi2.Domaine.DTO.Reponse.Produits;
using WebApi2.Infra.Repository.Context;

namespace WebApi2.App.Produits.Queries.DeleteProduitById
{
    public class DeleteProduitQueryHandler : IRequestHandler<DeleteProduitQuery, GetProduitDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteProduitQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetProduitDto> Handle(DeleteProduitQuery request, CancellationToken cancellationToken)
        {
            var Produit = await _dbContext.Produits.Where(x => x.Id == request.Id).FirstOrDefaultAsync();

            if (Produit != null)
            {

                _dbContext.Produits.Remove(Produit);
                await _dbContext.SaveChangesAsync();

            }
            return null;
        }
    }
}
