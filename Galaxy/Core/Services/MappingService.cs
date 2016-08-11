using Core.DTOModels;
using Data.Entities;

namespace Core.Services
{
    public class MappingService
    {
        public GlobeDtoModel GlobeDataToCore(Globe model)
        {
            return new GlobeDtoModel
            {
                Id = model.Id,
                Description = model.Description,
                Distance = model.Distance,
                Name = model.Name,
                TypeOfGlobe = (GlobeTypeDto)model.TypeOfGlobe
            };
        }

        public Globe GlobeCoreToData(GlobeDtoModel model)
        {
            return new Globe
            {
                Id = model.Id,
                Description = model.Description,
                Distance = model.Distance,
                Name = model.Name,
                TypeOfGlobe = (GlobeType)model.TypeOfGlobe
            };
        }
    }
}
