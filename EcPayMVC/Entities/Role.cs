using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class Role
{
    public int RoleId { get; set; }

    public string RoleName { get; set; }

    public int RoleType { get; set; }

    public virtual ICollection<ManagerRole> ManagerRoles { get; set; } = new List<ManagerRole>();
}
