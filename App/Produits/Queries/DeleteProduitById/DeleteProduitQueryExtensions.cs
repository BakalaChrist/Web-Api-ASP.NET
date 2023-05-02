using WebApi2.Domaine.DTO.Reponse.Produits;
using WebApi2.Domaine.Entities.Produits;

namespace WebApi2.App.Produits.Queries.DeleteProduitById
{
    public static class DeleteProduitQueryExtensions
    {
        public static GetProduitDto MapTo(this Produit Produit)
        {
            return new GetProduitDto
            {
                Id = Produit.Id,
                Designation = Produit.Designation,
                Description = Produit.Description,
                Qte = Produit.Qte,
                Prix = Produit.Prix,
                TypeProduit = Produit.TypeProduit,
            };
        }

    }
}
