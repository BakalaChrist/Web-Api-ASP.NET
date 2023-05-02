using Domaine.DTO.Reponse.Clients;
using MediatR;
using Microsoft.EntityFrameworkCore;
using WebApi2.App.Clients.Queries.GetClient;
using WebApi2.App.Produits.Queries.DeleteProduitById;
using WebApi2.Domaine.DTO.Reponse.Clients;
using WebApi2.Domaine.DTO.Reponse.Produits;
using WebApi2.Infra.Repository.Context;

namespace WebApi2.App.Clients.Queries.DeleteClientById
{
    public class DeleteClientQueryHandler : IRequestHandler<DeleteClientQuery, GetClientDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteClientQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetClientDto> Handle(DeleteClientQuery request, CancellationToken cancellationToken)
        {
            var Client = await _dbContext.Clients.Where(x => x.Id == request.Id).FirstOrDefaultAsync();

            if (Client != null)
            {

                _dbContext.Clients.Remove(Client);
                await _dbContext.SaveChangesAsync();

            }
            return null;
        }
    }
}
