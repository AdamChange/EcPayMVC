using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class Manager
{
    public int ManagerId { get; set; }

    public string Account { get; set; }

    public string Password { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public DateTime CreateDateTime { get; set; }

    public DateTime? UpdateDateTime { get; set; }

    public int? RestId { get; set; }

    public string Cellphone { get; set; }

    public virtual ICollection<ManagerRole> ManagerRoles { get; set; } = new List<ManagerRole>();
}
