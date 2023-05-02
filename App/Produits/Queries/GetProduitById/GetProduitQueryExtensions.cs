using WebApi2.Domaine.DTO.Reponse.Produits;
using WebApi2.Domaine.Entities.Produits;

namespace WebApi2.App.Produits.Queries.GetProduitById
{
    public  static class GetProduitQueryExtensions
    {
        public static GetProduitDto MapTo(this Produit Produit)
        {
            return new GetProduitDto
            {
                Id = Produit.Id,
                Designation = Produit.Designation,
                Description = Produit.Description,
                TypeProduit = Produit.TypeProduit,
                Qte = Produit.Qte
            };
        }
    }
}
