using RealEstate_BusinessEntity;
using RealEstate_BusinessService.Interface;
using RealEstate_Common;
using RealEstate_Repository.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_BusinessService.Concreate
{
    public class CountryMasterService : ICountryMasterService
    {
        private readonly CountryMasterRepository countryMasterRepository;

        public CountryMasterService()
        {
            countryMasterRepository = new CountryMasterRepository();
        }

        public bool AddCountry(CountryMasterViewModel countryMasterViewModel)
        {
            return countryMasterRepository.AddCountry(countryMasterViewModel.ToDataModel());
        }

        public List<CountryMasterViewModel> GetAllCountries()
        {
            var countryMasters = countryMasterRepository.GetAllCountries();
            return countryMasters.ToviewModel();
        }

        public CountryMasterViewModel GetCountryById(int id)
        {
            return countryMasterRepository.GetCountryById(id).ToViewModel();
        }

        public bool RemoveCountry(int id)
        {
            return countryMasterRepository.RemoveCountry(id);
        }
    }
}
