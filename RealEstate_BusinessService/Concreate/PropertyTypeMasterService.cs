using RealEstate_BusinessEntity;
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

namespace RealEstate_BusinessService.Concreate
{
    public class PropertyTypeMasterService : IPropertyTypeMasterService
    {
        private readonly IPropertyTypeMasterRepository propertyTypeMasterRepository;
        public PropertyTypeMasterService() 
        {
            propertyTypeMasterRepository = new PropertyTypeMasterRepository();
        }

        public bool AddPropertyType(PropertyTypeMasterViewModel propertyTypeMasterViewModel)
        {
            return propertyTypeMasterRepository.AddPropertyType(propertyTypeMasterViewModel.ToDataModel());
        }

        public List<PropertyTypeMasterViewModel> GetAllPropertyType()
        {
            var propertytype = propertyTypeMasterRepository.GetAllPropertyType();
            return propertytype.ToviewModel();
        }

        public PropertyTypeMasterViewModel GetPropertyTypeById(int id)
        {
            return propertyTypeMasterRepository.GetPropertyTypeById(id).ToViewModel();
        }

        public bool RemovePropertyType(int id)
        {
            return propertyTypeMasterRepository.RemovePropertyType(id);
        }
    }
}
