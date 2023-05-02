
using WebApi2.Domaine.Entities.Clients;

namespace WebApi2.App.Clients.Commands.UpdateClient
{
    public static class UpdateClientCommandExtension
    {
        public static Client UpdateClient(this UpdateClientCommand command)
        {
            var Produit = new Client(command.Nom, command.Prenom, command.Email, command.Adresse
                    );
            return Produit;
        }
    }
}
