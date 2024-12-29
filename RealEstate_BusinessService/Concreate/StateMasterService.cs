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
    public class StateMasterService : IStateMasterService
    {
        private readonly StateMasterRepository stateMasterRepository;
        public StateMasterService() 
        {
            stateMasterRepository = new StateMasterRepository();
        }

        public bool AddState(StateMasterViewModel stateMasterViewModel)
        {
            return stateMasterRepository.AddState(stateMasterViewModel.ToDataModel());
        }

        public List<StateMasterViewModel> GetAllStates()
        {
            var GetStates = stateMasterRepository.GetAllStates();
            return GetStates.ToviewModel();
        }

        public StateMasterViewModel GetStateById(int id)
        {
            return stateMasterRepository.GetStateById(id).ToViewModel();
        }

        public bool RemoveState(int id)
        {
            return stateMasterRepository.RemoveState(id);
        }
    }
}
