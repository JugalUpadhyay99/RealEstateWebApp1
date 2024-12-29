using RealEstate_BusinessEntity;
using RealEstate_DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_BusinessService.Interface
{
    public interface ICityMasterService
    {
        List<CityMasterViewModel> GetAllCity();

        public bool AddCity(CityMasterViewModel cityMasterViewModel);

        public bool RemoveCity(int id);

        public CityMasterViewModel GetCityById(int id);
    }
}
