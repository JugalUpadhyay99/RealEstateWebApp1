using RealEstate_DataEntity;
using RealEstate_Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_Repository.Concreate
{
    public class CityMasterRepository : ICityMasterRepository
    {
        private readonly PractiseExampledb2Context practiseExampledb2Context;

        public CityMasterRepository()
        {
            practiseExampledb2Context = new PractiseExampledb2Context();
        }
        public bool AddCity(CityMaster cityMaster)
        {
            if(cityMaster.CityId == 0)
            {
                practiseExampledb2Context.CityMasters.Add(cityMaster);
            }
            else
            {
                var d = practiseExampledb2Context.CityMasters.Find(cityMaster.CityId);
                d.StateId = cityMaster.StateId;
                d.CityName = cityMaster.CityName;
            }
            return practiseExampledb2Context.SaveChanges() > 0 ? true : false;
        }

        public List<CityMaster> GetAllCity()
        {
            return practiseExampledb2Context.CityMasters.Where(x => x.IsDeleted == false).ToList();
        }

        public CityMaster GetCityById(int id)
        {
            return practiseExampledb2Context.CityMasters.Find(id);
        }

        public bool RemoveCity(int id)
        {
            var record = practiseExampledb2Context.CityMasters.SingleOrDefault(x => x.CityId == id);
            record.IsDeleted = true;
            return practiseExampledb2Context.SaveChanges() > 0 ? true : false;
        }

        
    }
}
