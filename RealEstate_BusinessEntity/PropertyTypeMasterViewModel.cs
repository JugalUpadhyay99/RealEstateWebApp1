using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate_BusinessEntity
{
    public class PropertyTypeMasterViewModel
    {
        public int PropertyTypeId { get; set; }

        public string? PropertyTypeName { get; set; }

        public string? Description { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
