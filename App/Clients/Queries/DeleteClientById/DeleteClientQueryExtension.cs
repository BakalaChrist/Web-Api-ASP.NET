using Domaine.DTO.Reponse.Clients;
using WebApi2.Domaine.Entities.Clients;


namespace WebApi2.App.Clients.Queries.DeleteClientById
{
    public static class DeleteClientQueryExtension
    {
        public static GetClientDto MapTo(this Client Client)
        {
            return new GetClientDto
            {
                Id = Client.Id,
                Nom = Client.Nom,
                Prenom = Client.Prenom,
                Email = Client.Email,
                Adresse = Client.Adresse,
            };
        }
    }
} 


