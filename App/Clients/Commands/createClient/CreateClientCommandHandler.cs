using MediatR;
using Microsoft.EntityFrameworkCore;
using WebApi2.Domaine.DTO.Reponse.Clients;
using WebApi2.Infra.Repository.Context;

namespace WebApi2.App.Clients.Commands.createClient
{
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, CreateClientDto>
    {
        private readonly ApplicationDbContext _dbContext;
        public CreateClientCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CreateClientDto> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {


            var Client = request.CreateClient();
            await _dbContext.Clients.AddAsync(Client);
            await _dbContext.SaveChangesAsync();

            return new CreateClientDto(Client.Id);
        }
    }
}
