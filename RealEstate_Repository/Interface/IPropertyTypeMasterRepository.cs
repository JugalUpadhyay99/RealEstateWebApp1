using RealEstate_DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_Repository.Interface
{
    public interface IPropertyTypeMasterRepository
    {
        List<PropertyTypeMaster> GetAllPropertyType();

        public bool AddPropertyType(PropertyTypeMaster AddpropertyType);

        public bool RemovePropertyType(int id);

        PropertyTypeMaster GetPropertyTypeById(int id);
    }
}
