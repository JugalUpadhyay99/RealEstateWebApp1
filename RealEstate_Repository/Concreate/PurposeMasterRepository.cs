using RealEstate_DataEntity;
using RealEstate_Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_Repository.Concreate
{
    public class PurposeMasterRepository : IPurposeMasterRepository
    {
        private readonly PractiseExampledb2Context practiseExampledb2Context;

        public PurposeMasterRepository()
        {
            practiseExampledb2Context = new PractiseExampledb2Context();
        }
        public bool AddPurpose(PurposeMaster Addpurpose)
        {
            if (Addpurpose.PurposeId == 0)
            {
                practiseExampledb2Context.PurposeMasters.Add(Addpurpose);
            }
            else
            {
                var d = practiseExampledb2Context.PurposeMasters.Find(Addpurpose.PurposeId);

                d.PurposeName = Addpurpose.PurposeName;
            }
                
            return practiseExampledb2Context.SaveChanges() > 0 ? true : false;
        }

        public List<PurposeMaster> GetAllPurpose()
        {
            return practiseExampledb2Context.PurposeMasters.Where(x => x.IsDeleted == false).ToList();
        }

        public PurposeMaster GetPurposeById(int id)
        {
            return practiseExampledb2Context.PurposeMasters.Find(id);
        }

        public bool RemovePurpose(int id)
        {
            var record = practiseExampledb2Context.PurposeMasters.SingleOrDefault(x => x.PurposeId == id);
            record.IsDeleted = true;
            return practiseExampledb2Context.SaveChanges() > 0 ? true : false;
        }
    }
}
