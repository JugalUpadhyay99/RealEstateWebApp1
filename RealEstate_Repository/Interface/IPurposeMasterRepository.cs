using RealEstate_DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_Repository.Interface
{
    public interface IPurposeMasterRepository
    {
        List<PurposeMaster> GetAllPurpose();

        public bool AddPurpose(PurposeMaster Addpurpose);

        public bool RemovePurpose(int id);

        PurposeMaster GetPurposeById(int id);
    }
}
