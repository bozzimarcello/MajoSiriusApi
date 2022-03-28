using Microsoft.EntityFrameworkCore;

namespace MajoSiriusApi.Models
{
    public class MajoSiriusContext : DbContext
    {
        public MajoSiriusContext(DbContextOptions<MajoSiriusContext> options)
            : base(options)
        {
        }

        public DbSet<Stage> Stages { get; set; }
    }
}
