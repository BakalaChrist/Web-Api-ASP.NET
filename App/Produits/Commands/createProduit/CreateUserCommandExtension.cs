using WebApi2.Domaine.Entities.Produits;

namespace WebApi2.App.Produits.Commands.createProduit
{
    public static class CreateUserCommandExtension
    {
        //interactor 
        public static Produit CreateProduit(this CreateProduitCommand command)
        {
            var Produit = new Produit(command.Designation, command.Description, command.Qte, command.Prix, command.TypeProduit);
            return Produit;
        }
    }
}
