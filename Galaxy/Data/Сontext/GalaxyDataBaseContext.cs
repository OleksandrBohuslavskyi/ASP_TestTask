using System;
using System.Data.Entity;
using System.Linq;
using Data.Entities;

namespace Data.Сontext
{
    public class GalaxyDataBaseContext : DbContext
    {
        public GalaxyDataBaseContext():base("LocalDb")
        {
            
        }
        public DbSet<Globe> Globes { get; set; }
    }
}

