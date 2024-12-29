using RealEstate_BusinessEntity;
using RealEstate_DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_BusinessService.Interface
{
    public interface IPropertyTypeMasterService
    {
        List<PropertyTypeMasterViewModel> GetAllPropertyType();

        public bool AddPropertyType(PropertyTypeMasterViewModel AddpropertyType);

        public bool RemovePropertyType(int id);

        PropertyTypeMasterViewModel GetPropertyTypeById(int id);

    }
}
