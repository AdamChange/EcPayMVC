using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class FilterPriceRange
{
    public int FilterPriceRangeId { get; set; }

    public int FilterTypeId { get; set; }

    public int PriceRangeId { get; set; }

    public virtual FilterType FilterType { get; set; }

    public virtual PriceRange PriceRange { get; set; }
}
