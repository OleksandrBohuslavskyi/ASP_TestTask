using System;

namespace Core.DTOModels
{
    public class GlobeDtoModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GlobeTypeDto TypeOfGlobe { get; set; }
        public string Description { get; set; }
        public DateTime Discovered { get; set; }
        public double Distance { get; set; }
    }
}
