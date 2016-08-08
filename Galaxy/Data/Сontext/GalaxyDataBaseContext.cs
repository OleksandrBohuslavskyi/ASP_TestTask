using System.Data.Entity;
using Data.Entities;

namespace Data.Сontext
{
    public class GalaxyDataBaseContext : DbContext
    {
        public DbSet<Globe> Globes { get; set; }
    }
}
