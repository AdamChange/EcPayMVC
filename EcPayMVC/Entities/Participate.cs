using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class Participate
{
    /// <summary>
    /// PK流水號
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK 訂單ID
    /// </summary>
    public int OrderId { get; set; }

    /// <summary>
    /// FK 會員ID 受邀的人
    /// </summary>
    public int UserId { get; set; }

    public virtual BookingOrder User { get; set; }

    public virtual User UserNavigation { get; set; }
}
