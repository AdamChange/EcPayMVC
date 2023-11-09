using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class LineLogin
{
    /// <summary>
    /// PK Line會員ID
    /// </summary>
    public int LineLoginId { get; set; }

    /// <summary>
    /// FK 會員ID
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// 電子郵件
    /// </summary>
    public string Email { get; set; }

    public string SubLineId { get; set; }

    public DateTime CreateDateTime { get; set; }

    public virtual User User { get; set; }
}
