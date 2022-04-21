using Microsoft.EntityFrameworkCore;
using SampleWorkingWebAPI.Model;

namespace SampleWorkingWebAPI.Entities
{
    public class RepositoriesContext : DbContext
    {
        public RepositoriesContext(DbContextOptions options) : base(options) { }

        public DbSet<Studentt> Students { get; set; }

    }
}

