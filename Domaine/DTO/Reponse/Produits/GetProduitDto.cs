using WebApi2.Domaine.Entities.Produits;

namespace WebApi2.Domaine.DTO.Reponse.Produits
{
    public class GetProduitDto
    {
        public long Id { get; set; }
        public string? Designation { get; set; }
        public string? Description { get; set; }
        public int Qte { get; set; }
        public int Prix { get; set; }
        //public string? Image { get; set; }
        public ProduitType TypeProduit { get; set; }

    }
}
