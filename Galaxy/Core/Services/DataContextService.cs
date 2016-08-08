using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DTOModels;
using Data.Interfaces;

namespace Core.Services
{
    class DataContextService:IRepository<GlobeDtoModel>
    {
        public void Create(GlobeDtoModel model)
        {
            throw new NotImplementedException();
        }

        public GlobeDtoModel Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(GlobeDtoModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
