using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class UserLoginVeriCode
{
    public int SerialId { get; set; }

    public int UserId { get; set; }

    public string VerificationCode { get; set; }

    public DateTime CreateDateTime { get; set; }

    public DateTime ValidDateTime { get; set; }

    public virtual User User { get; set; }
}
