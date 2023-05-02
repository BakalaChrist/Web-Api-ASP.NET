using Domaine.DTO.Reponse.Clients;
using MediatR;
using WebApi2.Domaine.DTO.Reponse.Clients;

namespace WebApi2.App.Clients.Queries.GetClientById
{
    public class GetClientQuery : IRequest<GetClientDto>
    {
        public GetClientQuery(long? id)
        {
            Id = id;
        }

        public long? Id { get; set; }
    }
}
