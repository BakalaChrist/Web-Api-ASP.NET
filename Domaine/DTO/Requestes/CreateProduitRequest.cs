using WebApi2.Domaine.Entities.Produits;

namespace WebApi2.Domaine.DTO.Requestes
{
    public class CreateProduitRequest
    {
        //public long Id { get; set; }
        public string? Designation { get; set; }
        public string? Description { get; set; }
        public int Qte { get; set; }
        public int Prix { get; set; }
        //public string? Image { get; set; }
        public ProduitType TypeProduit { get; set; }

        public CreateProduitRequest(string? designation, string? description, int qte, int prix, ProduitType typeProduit)
        {
            Designation = designation;
            Description = description;
            Qte = qte;
            Prix = prix;
            TypeProduit = typeProduit;
        }
    }
}
