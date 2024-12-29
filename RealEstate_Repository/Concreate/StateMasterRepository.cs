using RealEstate_DataEntity;
using RealEstate_Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_Repository.Concreate
{
    public class StateMasterRepository : IStateMasterRepository
    {
        private readonly PractiseExampledb2Context practiseExampledb2Context;
        public StateMasterRepository() 
        {
            practiseExampledb2Context = new PractiseExampledb2Context();
        }

        public bool AddState(StateMaster stateMaster)
        {
            if(stateMaster.StateId == 0)
            {
                practiseExampledb2Context.StateMasters.Add(stateMaster);
            }
            else
            {
                var d = practiseExampledb2Context.StateMasters.Find(stateMaster.StateId);
                d.CountryId = stateMaster.CountryId;
                d.StateName = stateMaster.StateName;

            }          
            return practiseExampledb2Context.SaveChanges() > 0 ? true : false;
        }

        public List<StateMaster> GetAllStates()
        {
            return practiseExampledb2Context.StateMasters.Where(x => x.IsDeleted == false).ToList();
        }

        public StateMaster GetStateById(int id)
        {
            return practiseExampledb2Context.StateMasters.Find(id);
        }

        public bool RemoveState(int id)
        {
            var record = practiseExampledb2Context.StateMasters.SingleOrDefault(x => x.StateId == id);
            record.IsDeleted = true;
            return practiseExampledb2Context.SaveChanges() > 0 ? true : false;
        }
    }
}
