using RealEstate_BusinessEntity;
using RealEstate_BusinessService.Interface;
using RealEstate_Common;
using RealEstate_Repository.Concreate;
using RealEstate_Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_BusinessService.Concreate
{
    public class RoleMasterService :IRoleMasterService
    {
        private readonly IRoleMasterRepository roleMasterRepository;

        public RoleMasterService()
        {
            roleMasterRepository = new RoleMasterRepository();
        }

        public bool AddRole(RoleMasterViewModel roleMasterViewModel)
        {
            return roleMasterRepository.AddRole(roleMasterViewModel.ToDataModel());
        }

        public List<RoleMasterViewModel> GetAllRole()
        {
            var GetRoles = roleMasterRepository.GetAllRole();
            return GetRoles.ToviewModel();
        }

        public RoleMasterViewModel GetRoleById(int id)
        {
            return roleMasterRepository.GetRoleById(id).ToViewModel();
        }

        public bool RemoveRole(int id)
        {
            return roleMasterRepository.RemoveRole(id);
        }
    }
}
