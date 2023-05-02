using MediatR;
using WebApi2.Domaine.DTO.Reponse.Produits;
using WebApi2.Infra.Repository.Context;

namespace WebApi2.App.Produits.Commands.createProduit
{
    public class CreateUserCommandHandler : IRequestHandler<CreateProduitCommand, CreateProduitDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public CreateUserCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CreateProduitDto> Handle(CreateProduitCommand request, CancellationToken cancellationToken)
        {


            var Produit = request.CreateProduit();
            await _dbContext.Produits.AddAsync(Produit);
            await _dbContext.SaveChangesAsync();

            return new CreateProduitDto(Produit.Id);
        }
    }
}
