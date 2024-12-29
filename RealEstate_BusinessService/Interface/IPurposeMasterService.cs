using RealEstate_BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_BusinessService.Interface
{
    public interface IPurposeMasterService
    {
        List<PurposeMasterViewModel> GetAllPurpopse();

        public bool AddPurpose(PurposeMasterViewModel purposeMasterViewModel);

        public bool RemovePurpose(int id);

        PurposeMasterViewModel GetPurposeById(int id);
    }
}
