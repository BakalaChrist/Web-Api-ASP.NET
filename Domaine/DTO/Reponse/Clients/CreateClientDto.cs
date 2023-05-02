namespace WebApi2.Domaine.DTO.Reponse.Clients
{
    public class CreateClientDto
    {
        public CreateClientDto(long id)
        {
            Id = id;
        }

        public long Id { get; set; }
    }
}
