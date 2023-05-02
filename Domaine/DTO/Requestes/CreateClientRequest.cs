namespace WebApi2.Domaine.DTO.Requestes
{
    public class CreateClientRequest
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }

        public CreateClientRequest(string nom, string prenom, string email, string adresse)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Adresse = adresse;
        }
    }
}
