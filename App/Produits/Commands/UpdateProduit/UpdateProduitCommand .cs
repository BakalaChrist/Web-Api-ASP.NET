using MediatR;
using WebApi2.Domaine.DTO.Reponse.Produits;
using WebApi2.Domaine.Entities.Produits;

namespace WebApi2.App.Produits.Commands.UpdateProduit
{
    public class UpdateProduitCommand : IRequest<UpdateProduitDto>
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public string Designation { get; set; }
        public int Qte { get; set; }
        public int Prix { get; set; }
        public ProduitType TypeProduit { get; set; }

        public UpdateProduitCommand(long Id, string Designation, string Description, int Qte, int Prix,
            ProduitType typeProuit)
        {
            this.Id = Id;
            this.Designation = Designation;
            this.Description = Description;
            this.Qte = Qte;
            this.Prix = Prix;
            this.TypeProduit = typeProuit;
        }
    }
}
