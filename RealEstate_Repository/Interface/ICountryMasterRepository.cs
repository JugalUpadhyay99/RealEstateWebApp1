using RealEstate_DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_Repository.Interface
{
    public interface ICountryMasterRepository
    {
        List<CountryMaster> GetAllCountries();

        public bool AddCountry(CountryMaster Addcountry);

        public bool RemoveCountry(int id);

        CountryMaster GetCountryById(int id);
    }
}
