using System;
using System.Collections.Generic;

namespace RealEstate_DataEntity;

public partial class PropertyTypeMaster
{
    public int PropertyTypeId { get; set; }

    public string? PropertyTypeName { get; set; }

    public string? Description { get; set; }

    public bool? IsDeleted { get; set; }
}
