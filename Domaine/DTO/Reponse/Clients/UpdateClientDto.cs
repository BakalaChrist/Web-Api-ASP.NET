namespace WebApi2.Domaine.DTO.Reponse.Clients
{
    public class UpdateClientDto
    {
        public UpdateClientDto(long id)
        {
            Id = id;
        }

        public long Id { get; set; }
    }

}
