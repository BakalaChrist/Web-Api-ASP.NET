using MediatR;
using WebApi2.App.Produits.Commands;
using WebApi2.App.Produits.Commands.UpdateProduit;
using WebApi2.Domaine.DTO.Reponse.Produits;
using WebApi2.Infra.Repository.Context;

namespace Application.Produit.Commands.UpdateProduit
{
    public class UpdateProduitCommandHandler : IRequestHandler<UpdateProduitCommand, UpdateProduitDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public UpdateProduitCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UpdateProduitDto> Handle(UpdateProduitCommand request, CancellationToken cancellationToken)
        {
            var Produit = request.UpdateProduit();
            Produit.Id = request.Id;
            Produit.Designation = request.Designation;
            Produit.Description = request.Description;
            Produit.Qte = request.Qte;
            Produit.Prix = request.Prix;
            Produit.TypeProduit = request.TypeProduit;
            _dbContext.Produits.Update(Produit);
            await _dbContext.SaveChangesAsync();

            return new UpdateProduitDto(Produit.Id);

        }



    }
}
