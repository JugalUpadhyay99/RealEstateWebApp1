using RealEstate_DataEntity;
using RealEstate_Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_Repository.Concreate
{
    public class PropertyTypeMasterRepository : IPropertyTypeMasterRepository
    {
        private readonly PractiseExampledb2Context practiseExampledb2Context;
        public PropertyTypeMasterRepository()
        {
            practiseExampledb2Context = new PractiseExampledb2Context();
        }

        public bool AddPropertyType(PropertyTypeMaster propertyTypeMaster)
        {
            if(propertyTypeMaster.PropertyTypeId == 0)
            {
                practiseExampledb2Context.PropertyTypeMasters.Add(propertyTypeMaster);
            }
            else
            {
                var d = practiseExampledb2Context.PropertyTypeMasters.Find(propertyTypeMaster.PropertyTypeId);

                d.PropertyTypeName = propertyTypeMaster.PropertyTypeName;
            }
            
            return practiseExampledb2Context.SaveChanges() > 0 ? true : false;
        }

        public List<PropertyTypeMaster> GetAllPropertyType()
        {
            return practiseExampledb2Context.PropertyTypeMasters.Where(x => x.IsDeleted == false).ToList();
        }

        public PropertyTypeMaster GetPropertyTypeById(int id)
        {
            return practiseExampledb2Context.PropertyTypeMasters.Find(id);
        }

        public bool RemovePropertyType(int id)
        {
            var record = practiseExampledb2Context.PropertyTypeMasters.SingleOrDefault(x => x.PropertyTypeId == id);
            record.IsDeleted = true;
            return practiseExampledb2Context.SaveChanges() > 0 ? true : false;
        }
    }
}
