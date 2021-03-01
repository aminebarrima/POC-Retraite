using GPRC.core.domaine.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
 


namespace GPRC.persistance.Contexts
{
    public class ApplicationDbContext : DbContext  

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
           // builder.HasDefaultSchema("Tarvel");
            base.OnModelCreating(builder);

        }


        public DbSet<Dossier> Dossier { get; set; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
