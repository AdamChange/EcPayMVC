using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class ProductMultimedia
{
    /// <summary>
    /// PK
    /// </summary>
    public int Pmid { get; set; }

    /// <summary>
    /// FK 產品ID
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// 照片檔URL
    /// </summary>
    public string ImageUrl { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int? Sort { get; set; }

    public bool IsDeleted { get; set; }
}
