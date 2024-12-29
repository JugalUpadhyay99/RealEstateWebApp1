using RealEstate_DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_Repository.Interface
{
    public interface IStateMasterRepository
    {
        List<StateMaster> GetAllStates();

        public bool AddState (StateMaster stateMaster);

        public bool RemoveState (int id);

        StateMaster GetStateById(int id);

    }
}
