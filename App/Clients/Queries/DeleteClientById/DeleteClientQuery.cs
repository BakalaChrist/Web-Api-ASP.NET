using Domaine.DTO.Reponse.Clients;
using MediatR;

namespace WebApi2.App.Clients.Queries.DeleteClientById
{
    public class DeleteClientQuery : IRequest<GetClientDto>
    {
        public DeleteClientQuery(long? id)
        {
            Id = id;
        }

        public long? Id { get; set; }
    }
}
