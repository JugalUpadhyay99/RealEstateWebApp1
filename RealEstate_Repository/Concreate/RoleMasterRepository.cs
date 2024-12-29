using RealEstate_DataEntity;
using RealEstate_Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_Repository.Concreate
{
    public class RoleMasterRepository : IRoleMasterRepository
    {
        private readonly PractiseExampledb2Context practiseExampledb2Context;

        public RoleMasterRepository()
        {
            practiseExampledb2Context = new PractiseExampledb2Context();
        }

        public bool AddRole(RoleMaster roleMaster)
        {
            if(roleMaster.RoleId == 0)
            {
                practiseExampledb2Context.RoleMasters.Add(roleMaster);
            }
            else
            {
                var d = practiseExampledb2Context.RoleMasters.Find(roleMaster.RoleId);
                
                d.RoleName = roleMaster.RoleName;
            }
            return practiseExampledb2Context.SaveChanges() > 0 ? true : false;
        }

        public List<RoleMaster> GetAllRole()
        {
            return practiseExampledb2Context.RoleMasters.Where(x => x.IsDeleted == false).ToList();
        }

        public RoleMaster GetRoleById(int id)
        {
            return practiseExampledb2Context.RoleMasters.Find(id);
        }

        public bool RemoveRole(int id)
        {
            var record = practiseExampledb2Context.RoleMasters.SingleOrDefault(x => x.RoleId == id);
            record.IsDeleted = true;
            return practiseExampledb2Context.SaveChanges() > 0 ? true : false;
        }
    }
}
