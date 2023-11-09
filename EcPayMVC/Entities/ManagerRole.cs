using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class ManagerRole
{
    public int ManagerRoleId { get; set; }

    public int ManagerId { get; set; }

    public int RoleId { get; set; }

    public virtual Manager Manager { get; set; }

    public virtual Role Role { get; set; }
}
