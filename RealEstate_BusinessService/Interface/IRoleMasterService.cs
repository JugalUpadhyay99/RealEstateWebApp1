using RealEstate_BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_BusinessService.Interface
{
    public interface IRoleMasterService
    {
        List<RoleMasterViewModel> GetAllRole();

        public bool AddRole(RoleMasterViewModel roleMasterViewModel);

        public bool RemoveRole(int id);

        RoleMasterViewModel GetRoleById(int id);
    }
}
