using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOModels
{
    class GlobeDtoModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GlobeTypeDto Type { get; set; }
        public string Description { get; set; }
        public DateTime Discovered { get; set; }
        public double Distance { get; set; }
    }
}
