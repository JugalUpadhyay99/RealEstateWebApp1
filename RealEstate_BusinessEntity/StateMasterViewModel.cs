using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_BusinessEntity
{
    public class StateMasterViewModel
    {
        public int StateId { get; set; }

        public int? CountryId { get; set; }

        public string? StateName { get; set; }

        public bool? IsDeleted { get; set; }

        public virtual ICollection<CountryMasterViewModel> CountryMasters { get; set; } = new List<CountryMasterViewModel>();
    }
}
