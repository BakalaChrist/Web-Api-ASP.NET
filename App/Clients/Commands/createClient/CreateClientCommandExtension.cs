
using WebApi2.Domaine.Entities.Clients;

namespace WebApi2.App.Clients.Commands.createClient
{
    public static class CreateClientCommandExtension
    {
        //interactor 
        public static Client CreateClient(this CreateClientCommand command)
        {
            var Produit = new Client(command.Nom, command.Prenom, command.Email, command.Adresse);
            return Produit;
        }
    }
}
