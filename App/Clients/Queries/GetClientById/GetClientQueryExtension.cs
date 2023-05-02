using Domaine.DTO.Reponse.Clients;
using WebApi2.Domaine.DTO.Reponse.Clients;
using WebApi2.Domaine.DTO.Reponse.Produits;
using WebApi2.Domaine.Entities.Clients;
using WebApi2.Domaine.Entities.Produits;

namespace WebApi2.App.Clients.Queries.GetClientById
{
    public static class GetClientQueryExtension
    {
        public static GetClientDto MapTo(this Client client)
        {
            return new GetClientDto
            {
                Id = client.Id,
                Nom = client.Nom,
                Prenom = client.Prenom,
                Email = client.Email,
                Adresse = client.Adresse,
            };
        }
    }
}
