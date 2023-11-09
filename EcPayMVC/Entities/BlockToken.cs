using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class BlockToken
{
    public int Id { get; set; }

    public string Token { get; set; }

    public DateTimeOffset ExpireTime { get; set; }
}
