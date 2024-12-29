using System;
using System.Collections.Generic;

namespace RealEstate_DataEntity;

public partial class LoginMaster
{
    public int LoginId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int? RoleId { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual RoleMaster? Role { get; set; }

    public virtual ICollection<UserProfileMaster> UserProfileMasters { get; set; } = new List<UserProfileMaster>();
}
