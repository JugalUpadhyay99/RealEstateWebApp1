using System;
using System.Collections.Generic;

namespace RealEstate_DataEntity;

public partial class CityMaster
{
    public int CityId { get; set; }

    public int? StateId { get; set; }

    public string? CityName { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual StateMaster? State { get; set; }

    public virtual ICollection<UserProfileMaster> UserProfileMasters { get; set; } = new List<UserProfileMaster>();
}
