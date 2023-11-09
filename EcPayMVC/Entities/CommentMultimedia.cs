using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class CommentMultimedia
{
    /// <summary>
    /// PK
    /// </summary>
    public int Cmid { get; set; }

    /// <summary>
    /// FK
    /// </summary>
    public int CommentId { get; set; }

    public string ImageUrl { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int? Sort { get; set; }
}
