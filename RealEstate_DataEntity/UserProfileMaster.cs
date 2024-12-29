using System;
using System.Collections.Generic;

namespace RealEstate_DataEntity;

public partial class UserProfileMaster
{
    public int UserId { get; set; }

    public int? LoginId { get; set; }

    public int? RoleId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public int? CityId { get; set; }

    public int? StateId { get; set; }

    public int? CountryId { get; set; }

    public int? ZipCode { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual CityMaster? City { get; set; }

    public virtual CountryMaster? Country { get; set; }

    public virtual LoginMaster? Login { get; set; }

    public virtual RoleMaster? Role { get; set; }

    public virtual StateMaster? State { get; set; }
}
