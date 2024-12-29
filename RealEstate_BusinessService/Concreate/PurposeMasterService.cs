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
    public class PurposeMasterService : IPurposeMasterService
    {
        private readonly IPurposeMasterRepository purposeMasterRepository;
        public PurposeMasterService()
        {
            purposeMasterRepository = new PurposeMasterRepository();
        }
        public bool AddPurpose(PurposeMasterViewModel purposeMasterViewModel)
        {
            return purposeMasterRepository.AddPurpose(purposeMasterViewModel.ToDataModel());
        }

        public List<PurposeMasterViewModel> GetAllPurpopse()
        {
            var purposeMasters = purposeMasterRepository.GetAllPurpose();
            return purposeMasters.ToviewModel();
        }

        public PurposeMasterViewModel GetPurposeById(int id)
        {
            return purposeMasterRepository.GetPurposeById(id).ToViewModel();
        }

        public bool RemovePurpose(int id)
        {
            return purposeMasterRepository.RemovePurpose(id);
        }
    }
}
