using WebApi2.Domaine.DTO.Reponse.Produits;
using WebApi2.Domaine.Entities.Produits;

namespace WebApi2.App.Produits.Queries.GetProduit
{
    public static class GetProduitsQueryExtensions
    {
        public static GetProduitDto MapTo(this Produit produit)
        {
            return new GetProduitDto
            {
                Id = produit.Id,
                Designation = produit.Designation,
                Description = produit.Description,
                Qte = produit.Qte,
                Prix = produit.Prix,
                TypeProduit = produit.TypeProduit,
            };
        }
    }
}
