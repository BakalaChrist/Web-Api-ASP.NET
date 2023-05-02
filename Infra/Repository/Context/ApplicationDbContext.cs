using Microsoft.EntityFrameworkCore;
using WebApi2.Domaine.Entities.Clients;
using WebApi2.Domaine.Entities.Produits;

namespace WebApi2.Infra.Repository.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        { }
        //public DbSet<User> Users { get; set; }
        //public DbSet<Catalogue> Catalogues { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
