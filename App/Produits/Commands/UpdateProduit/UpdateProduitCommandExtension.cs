
using WebApi2.App.Produits.Commands;
using WebApi2.Domaine.Entities.Produits;

namespace WebApi2.App.Produits.Commands.UpdateProduit
{
    public static class UpdateProduitCommandExtension
    {
        public static Produit UpdateProduit(this UpdateProduitCommand command)
        {
            var Produit = new Produit(command.Designation, command.Description, command.Qte, command.Prix, command.TypeProduit
                    );
            return Produit;
        }
    }
}
