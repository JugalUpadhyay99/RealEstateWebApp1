using RealEstate_DataEntity;
using RealEstate_Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_Repository.Concreate
{
    public class CountryMasterRepository : ICountryMasterRepository
    {
        private readonly PractiseExampledb2Context practiseExampledb2Context;
        public CountryMasterRepository() 
        {
            practiseExampledb2Context = new PractiseExampledb2Context();
        }

        public bool AddCountry(CountryMaster countryMaster)
        {
            if (countryMaster.CountryId == 0) 
            {
                practiseExampledb2Context.CountryMasters.Add(countryMaster);
            }
            else
            {
                var d = practiseExampledb2Context.CountryMasters.Find(countryMaster.CountryId);

                d.CountryName = countryMaster.CountryName;

            }
            
            return practiseExampledb2Context.SaveChanges() > 0 ? true : false;
        }

        public List<CountryMaster> GetAllCountries()
        {
            return practiseExampledb2Context.CountryMasters.Where(x => x.IsDeleted == false).ToList();
        }

        public CountryMaster GetCountryById(int id)
        {
            return practiseExampledb2Context.CountryMasters.Find(id);
        }

        public bool RemoveCountry(int id)
        {
            var record = practiseExampledb2Context.CountryMasters.SingleOrDefault(x => x.CountryId == id);
            record.IsDeleted = true;
            return practiseExampledb2Context.SaveChanges()>0? true: false;
        }
    }
}
