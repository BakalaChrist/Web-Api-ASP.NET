using Domaine.DTO.Reponse.Clients;
using MediatR;
using WebApi2.Domaine.DTO.Reponse.Clients;

namespace WebApi2.App.Clients.Queries.GetClientById
{
    public class GetClientsQuery : IRequest<IList<GetClientDto>>
    {
    }
}
