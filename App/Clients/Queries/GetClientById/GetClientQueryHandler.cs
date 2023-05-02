using Domaine.DTO.Reponse.Clients;
using MediatR;
using Microsoft.EntityFrameworkCore;
using WebApi2.Domaine.DTO.Reponse.Clients;
using WebApi2.Infra.Repository.Context;

namespace WebApi2.App.Clients.Queries.GetClientById
{
    public class GetClientQueryHandler : IRequestHandler<GetClientQuery, GetClientDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetClientQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetClientDto> Handle(GetClientQuery request, CancellationToken cancellationToken)
        {
            var Client = await _dbContext.Clients.Where(x => x.Id == request.Id).FirstOrDefaultAsync();

            if (Client != null)
            {
                var ClientItem = Client.MapTo();
                return ClientItem;
            }
            return null;
        }
    }
}
