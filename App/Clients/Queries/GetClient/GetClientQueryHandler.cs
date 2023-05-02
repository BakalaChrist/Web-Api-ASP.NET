using Domaine.DTO.Reponse.Clients;
using MediatR;
using Microsoft.EntityFrameworkCore;
using WebApi2.Domaine.DTO.Reponse.Clients;
using WebApi2.Infra.Repository.Context;

namespace WebApi2.App.Clients.Queries.GetClient
{
    public class GetClientQueryHandler : IRequestHandler<GetClientQuery, IList<GetClientDto>>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetClientQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<GetClientDto>> Handle(GetClientQuery request, CancellationToken cancellationToken)
        {
            var clients = await _dbContext.Clients.ToListAsync();
            var clientList = new List<GetClientDto>();
            foreach (var Item in clients)
            {
                var client = Item.MapTo();
                clientList.Add(client);
            }

            return clientList;
        }
    }
}
