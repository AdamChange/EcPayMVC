using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class PriceRange
{
    /// <summary>
    /// PK 價錢級距ID
    /// </summary>
    public int PriceRangeId { get; set; }

    /// <summary>
    /// 級距說明
    /// </summary>
    public string PriceRangeType { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int? PriceRangeLevel { get; set; }

    public virtual ICollection<FilterPriceRange> FilterPriceRanges { get; set; } = new List<FilterPriceRange>();

    public virtual ICollection<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
}
