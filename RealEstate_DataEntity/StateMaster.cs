using System;
using System.Collections.Generic;

namespace RealEstate_DataEntity;

public partial class StateMaster
{
    public int StateId { get; set; }

    public int? CountryId { get; set; }

    public string? StateName { get; set; }

    public bool? IsDeleted { get; set; }

  

    public virtual ICollection<CityMaster> CityMasters { get; set; } = new List<CityMaster>();

    public virtual CountryMaster? Country { get; set; }

    public virtual ICollection<UserProfileMaster> UserProfileMasters { get; set; } = new List<UserProfileMaster>();
}
