using RealEstate_BusinessService.Interface;
using RealEstate_Common;
using RealEstate_DataEntity;
using RealEstate_Repository.Concreate;
using RealEstate_Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate_BusinessEntity;


namespace RealEstate_BusinessService.Concreate
{
    public class CityMasterService : ICityMasterService
    {
        private readonly ICityMasterRepository cityMasterRepository;

        public CityMasterService()
        {
            cityMasterRepository = new CityMasterRepository();
        }
        public bool AddCity(CityMasterViewModel cityMasterViewModel)
        {
            return cityMasterRepository.AddCity(cityMasterViewModel.ToDataModel());
        }

        public List<CityMasterViewModel> GetAllCity()
        {
            var GetCities = cityMasterRepository.GetAllCity();
            return GetCities.ToviewModel();
        }

        public CityMasterViewModel GetCityById(int id)
        {
            return cityMasterRepository.GetCityById(id).ToViewModel();
        }

        public bool RemoveCity(int id)
        {
            return cityMasterRepository.RemoveCity(id);
        }
    }
}
