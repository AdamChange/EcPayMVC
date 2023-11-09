using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class CustomizedMenu
{
    /// <summary>
    /// PK 外帶產品標題
    /// </summary>
    public int CustomizedMenuId { get; set; }

    /// <summary>
    /// 外帶產品標題名稱
    /// </summary>
    public string CustomizedMenuName { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
