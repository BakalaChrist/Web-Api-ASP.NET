using MediatR;
using WebApi2.Domaine.DTO.Reponse.Clients;
using WebApi2.Infra.Repository.Context;

namespace WebApi2.App.Clients.Commands.UpdateClient
{
    public class UpdateClientCommandHandler : IRequestHandler<UpdateClientCommand, UpdateClientDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public UpdateClientCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UpdateClientDto> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
        {
            var Client = request.UpdateClient();
            Client.Id = request.Id;
            Client.Nom = request.Nom;
            Client.Prenom = request.Prenom;
            Client.Email = request.Email;
            Client.Adresse = request.Adresse;
            _dbContext.Clients.Update(Client);
            await _dbContext.SaveChangesAsync();

            return new UpdateClientDto(Client.Id);

        }
    }
}
