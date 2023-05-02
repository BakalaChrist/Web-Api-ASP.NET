using MediatR;
using WebApi2.Domaine.DTO.Reponse.Clients;

namespace WebApi2.App.Clients.Commands.UpdateClient
{
    public class UpdateClientCommand : IRequest<UpdateClientDto>
    {
        public long Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }

        public UpdateClientCommand(long id, string nom, string prenom, string email, string adresse)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Adresse = adresse;
        }
    }
}
