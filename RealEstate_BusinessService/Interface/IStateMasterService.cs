using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate_BusinessEntity;

namespace RealEstate_BusinessService.Interface
{
    public interface IStateMasterService
    {
        List<StateMasterViewModel> GetAllStates();

        public bool AddState(StateMasterViewModel stateMasterViewModel);

        public bool RemoveState(int id);

        StateMasterViewModel GetStateById(int id);
    }
}
