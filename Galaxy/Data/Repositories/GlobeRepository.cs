using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Data.Entities;
using Interfaces;
using Data.Сontext;

namespace Data.Repositories
{
    public class GlobeRepository : IRepository<Globe>
    {
        public void Create(Globe model)
        {
            using (var context = new GalaxyDataBaseContext())
            {
                context.Globes.Add(model);
                context.SaveChanges();
            }
        }

        public Globe Read(int id)
        {
            using (var context = new GalaxyDataBaseContext())
            {
                return context.Globes.FirstOrDefault(g => g.Id == id);
            }
        }

        public void Update(Globe model)
        {
            using (var context = new GalaxyDataBaseContext())
            {
                context.Globes.AddOrUpdate(model);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new GalaxyDataBaseContext())
            {
                context.Globes.Remove(context.Globes.FirstOrDefault(g => g.Id == id));
                context.SaveChanges();
            }
        }

        public IEnumerable<Globe> GetAll()
        {
            using (var context = new GalaxyDataBaseContext())
            {
                return context.Globes.ToList();
            }
        }
    }
}
