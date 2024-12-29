using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_BusinessEntity
{
    public class CityMasterViewModel
    {
        public int CityId { get; set; }

        public int? StateId { get; set; }

        public string? CityName { get; set; }

        public bool? IsDeleted { get; set; }

        public virtual ICollection<StateMasterViewModel> StateMasters { get; set; } = new List<StateMasterViewModel>();

    }
}
