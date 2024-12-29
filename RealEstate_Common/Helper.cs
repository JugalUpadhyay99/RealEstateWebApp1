using RealEstate_BusinessEntity;
using RealEstate_DataEntity;

namespace RealEstate_Common
{
    public static class Helper
    {
        //Country
        public static CountryMasterViewModel ToViewModel(this CountryMaster countryMaster)
        {
            CountryMasterViewModel viewModel = new CountryMasterViewModel();
            viewModel.CountryId = countryMaster.CountryId;
            viewModel.CountryName = countryMaster.CountryName;
            return viewModel;
        }
        //Country list
        public static List<CountryMasterViewModel> ToviewModel(this List<CountryMaster> countryMaster)
        {
            return countryMaster.Select(x => x.ToViewModel()).ToList();
        }
        public static CountryMaster ToDataModel(this CountryMasterViewModel countryMaster)
        {
            CountryMaster dataModel = new CountryMaster();
            dataModel.CountryId = countryMaster.CountryId;
            dataModel.CountryName = countryMaster.CountryName;
            dataModel.IsDeleted = false;

            return dataModel;
        }

        //State
        public static StateMasterViewModel ToViewModel(this StateMaster stateMaster)
        {
            StateMasterViewModel viewModel = new StateMasterViewModel();
            viewModel.StateId = stateMaster.StateId;
            viewModel.CountryId = stateMaster.CountryId;
            viewModel.StateName = stateMaster.StateName;
            return viewModel;
        }

        public static List<StateMasterViewModel> ToviewModel(this List<StateMaster> stateMaster)
        {
            return stateMaster.Select(x => x.ToViewModel()).ToList();
        }

        public static StateMaster ToDataModel(this StateMasterViewModel stateMaster)
        {
            StateMaster dataModel = new StateMaster();
            dataModel.CountryId = stateMaster.CountryId;
            dataModel.StateName = stateMaster.StateName;
            dataModel.IsDeleted = false;

            return dataModel;
        }

        //City

        public static CityMasterViewModel ToViewModel(this CityMaster cityMaster)
        {
            CityMasterViewModel viewModel = new CityMasterViewModel();
            viewModel.CityId = cityMaster.CityId;
            viewModel.StateId = cityMaster.StateId;
            viewModel.CityName = cityMaster.CityName;
            return viewModel;
        }
        public static List<CityMasterViewModel> ToviewModel(this List<CityMaster> cityMaster)
        {
            return cityMaster.Select(x => x.ToViewModel()).ToList();
        }

        public static CityMaster ToDataModel(this CityMasterViewModel cityMaster)
        {
            CityMaster dataModel = new CityMaster();
            dataModel.CityId = cityMaster.CityId;
            dataModel.CityName = cityMaster.CityName;
            dataModel.IsDeleted = false;

            return dataModel;
        }
        //Role
        public static RoleMasterViewModel ToViewModel(this RoleMaster roleMaster)
        {
            RoleMasterViewModel viewModel = new RoleMasterViewModel();
            viewModel.RoleId = roleMaster.RoleId;
            viewModel.RoleName = roleMaster.RoleName;
            return viewModel;
        }
        public static List<RoleMasterViewModel> ToviewModel(this List<RoleMaster> roleMaster)
        {
            return roleMaster.Select(x => x.ToViewModel()).ToList();
        }
        public static RoleMaster ToDataModel(this RoleMasterViewModel roleMaster)
        {
            RoleMaster dataModel = new RoleMaster();
            dataModel.RoleId = roleMaster.RoleId;
            dataModel.RoleName = roleMaster.RoleName;
            dataModel.IsDeleted = false;

            return dataModel;
        }
        //PropertyType
        public static PropertyTypeMasterViewModel ToViewModel(this PropertyTypeMaster propertyTypeMaster)
        {
            PropertyTypeMasterViewModel viewModel = new PropertyTypeMasterViewModel();
            viewModel.PropertyTypeId = propertyTypeMaster.PropertyTypeId;
            viewModel.PropertyTypeName = propertyTypeMaster.PropertyTypeName;
            return viewModel;
        }
        public static List<PropertyTypeMasterViewModel> ToviewModel(this List<PropertyTypeMaster> propertyTypeMaster)
        {
            return propertyTypeMaster.Select(x => x.ToViewModel()).ToList();
        }
        public static PropertyTypeMaster ToDataModel(this PropertyTypeMasterViewModel propertyTypeMaster)
        {
            PropertyTypeMaster dataModel = new PropertyTypeMaster();
            dataModel.PropertyTypeId = propertyTypeMaster.PropertyTypeId;
            dataModel.PropertyTypeName = propertyTypeMaster.PropertyTypeName;
            dataModel.IsDeleted = false;

            return dataModel;
        }
        //Purpose
        public static PurposeMasterViewModel ToViewModel(this PurposeMaster purposeMaster)
        {
            PurposeMasterViewModel viewModel = new PurposeMasterViewModel();
            viewModel.PurposeId = purposeMaster.PurposeId;
            viewModel.PurposeName = purposeMaster.PurposeName;
            return viewModel;
        }
        public static List<PurposeMasterViewModel> ToviewModel(this List<PurposeMaster> purposeMaster)
        {
            return purposeMaster.Select(x => x.ToViewModel()).ToList();
        }
        public static PurposeMaster ToDataModel(this PurposeMasterViewModel purposeMaster)
        {
            PurposeMaster dataModel = new PurposeMaster();
            dataModel.PurposeId = purposeMaster.PurposeId;
            dataModel.PurposeName = purposeMaster.PurposeName;
            dataModel.IsDeleted = false;

            return dataModel;
        }
    }
}
