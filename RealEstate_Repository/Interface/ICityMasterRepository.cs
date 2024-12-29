using RealEstate_DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_Repository.Interface
{
    public interface ICityMasterRepository
    {
        List<CityMaster> GetAllCity();

        public bool AddCity(CityMaster cityMaster);

        public bool RemoveCity(int id);
        public CityMaster GetCityById(int id);
    }
}
