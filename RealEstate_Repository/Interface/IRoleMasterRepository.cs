using RealEstate_DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_Repository.Interface
{
    public interface IRoleMasterRepository
    {
        List<RoleMaster> GetAllRole();

        public bool AddRole(RoleMaster roleMaster);

        public bool RemoveRole(int id);

        RoleMaster GetRoleById(int id);
    }
}
