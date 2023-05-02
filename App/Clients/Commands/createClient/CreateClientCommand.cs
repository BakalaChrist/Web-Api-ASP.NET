using MediatR;

using WebApi2.Domaine.DTO.Reponse.Clients;

namespace WebApi2.App.Clients.Commands.createClient
{
    public class CreateClientCommand : IRequest<CreateClientDto>
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }

        public CreateClientCommand(string nom, string prenom, string email, string adresse)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Adresse = adresse;
        }
    }
}
