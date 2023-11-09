using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class RestaurantsMultimedia
{
    /// <summary>
    /// PK
    /// </summary>
    public int Rmid { get; set; }

    /// <summary>
    /// 餐廳ID
    /// </summary>
    public int RestaurantId { get; set; }

    public string ImageUrl { get; set; }

    public DateTime EditDatetime { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int? Sort { get; set; }

    public DateTime CreateDateTime { get; set; }

    public int Type { get; set; }

    public int Section { get; set; }

    public virtual Restaurant Restaurant { get; set; }
}
