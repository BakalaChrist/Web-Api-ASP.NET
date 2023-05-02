using MediatR;
using WebApi2.Domaine.DTO.Reponse.Produits;
using WebApi2.Domaine.Entities.Produits;

namespace WebApi2.App.Produits.Commands.createProduit
{
    public class CreateProduitCommand : IRequest<CreateProduitDto>
    {
        public CreateProduitCommand(string? designation, string? description, int qte, int prix, ProduitType typeProduit)
        {
            Designation = designation;
            Description = description;
            Qte = qte;
            Prix = prix;
            TypeProduit = typeProduit;
        }

        public string? Designation { get; set; }
        public string? Description { get; set; }
        public ProduitType TypeProduit { get; set; }
        public int Qte { get; set; }
        public int Prix { get; set; }



    }
}
