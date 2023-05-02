namespace WebApi2.Domaine.DTO.Reponse.Produits
{
    public class CreateProduitDto
    {
        public CreateProduitDto(long id)
        {
            Id = id;
        }

        public long Id { get; set; }

    }
}
