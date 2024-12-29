using System;
using System.Collections.Generic;

namespace RealEstate_DataEntity;

public partial class CountryMaster
{
    public int CountryId { get; set; }

    public string? CountryName { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<StateMaster> StateMasters { get; set; } = new List<StateMaster>();

    public virtual ICollection<UserProfileMaster> UserProfileMasters { get; set; } = new List<UserProfileMaster>();
}
