using System;
using System.Collections.Generic;

namespace RealEstate_DataEntity;

public partial class PurposeMaster
{
    public int PurposeId { get; set; }

    public string? PurposeName { get; set; }

    public bool? IsDeleted { get; set; }
}
