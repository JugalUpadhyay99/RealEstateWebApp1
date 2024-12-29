using RealEstate_BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_BusinessService.Interface
{
    public interface ICountryMasterService
    {
        List<CountryMasterViewModel> GetAllCountries();

        public bool AddCountry(CountryMasterViewModel countryMasterViewModel);

        public bool RemoveCountry(int id);

        CountryMasterViewModel GetCountryById(int id);
    }
}
