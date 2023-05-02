
namespace WebApi2.Domaine.Entities.Clients
{
    public class Client
    {
        public long Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }    

        public Client (string nom, string prenom, string email, string adresse)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Adresse = adresse;
        }
    }
}
