using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class FilterType
{
    /// <summary>
    /// PK
    /// </summary>
    public int FilterTypeId { get; set; }

    public string FilterName { get; set; }

    public string FilterIcon { get; set; }

    public virtual ICollection<FilterCounty> FilterCounties { get; set; } = new List<FilterCounty>();

    public virtual ICollection<FilterDiningType> FilterDiningTypes { get; set; } = new List<FilterDiningType>();

    public virtual ICollection<FilterMealType> FilterMealTypes { get; set; } = new List<FilterMealType>();

    public virtual ICollection<FilterPriceRange> FilterPriceRanges { get; set; } = new List<FilterPriceRange>();
}
