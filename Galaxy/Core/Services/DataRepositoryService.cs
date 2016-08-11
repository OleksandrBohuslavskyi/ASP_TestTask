using System.Collections.Generic;
using System.Linq;
using Core.DTOModels;
using Interfaces;

namespace Core.Services
{
    public class DataRepositoryService : IRepository<GlobeDtoModel>
    {
        public void Create(GlobeDtoModel model)
        {
            new Data.Repositories.GlobeRepository().Create(new MappingService().GlobeCoreToData(model));
        }

        public GlobeDtoModel Read(int id)
        {
            return new MappingService().GlobeDataToCore(new Data.Repositories.GlobeRepository().Read(id));
        }

        public void Update(GlobeDtoModel model)
        {
            new Data.Repositories.GlobeRepository().Update(new MappingService().GlobeCoreToData(model));
        }

        public void Delete(int id)
        {
            new Data.Repositories.GlobeRepository().Delete(id);
        }

        public IEnumerable<GlobeDtoModel> GetAll()
        {
            return new Data.Repositories.GlobeRepository().GetAll().Select(globe => new MappingService().GlobeDataToCore(globe)).ToList();
        }
    }
}
