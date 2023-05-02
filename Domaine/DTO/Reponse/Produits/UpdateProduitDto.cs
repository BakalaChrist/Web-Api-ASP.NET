namespace WebApi2.Domaine.DTO.Reponse.Produits
{
    public class UpdateProduitDto
    {
        public UpdateProduitDto(long id)
        {
            Id = id;
        }

        public long Id { get; set; }
    }
}
