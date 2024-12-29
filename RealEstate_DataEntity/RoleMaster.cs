using System;
using System.Collections.Generic;

namespace RealEstate_DataEntity;

public partial class RoleMaster
{
    public int RoleId { get; set; }

    public string? RoleName { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<LoginMaster> LoginMasters { get; set; } = new List<LoginMaster>();

    public virtual ICollection<UserProfileMaster> UserProfileMasters { get; set; } = new List<UserProfileMaster>();
}
