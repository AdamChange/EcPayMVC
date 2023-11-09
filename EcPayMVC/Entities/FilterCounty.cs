using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class FilterCounty
{
    public int FilterCountyId { get; set; }

    public int FilterTypeId { get; set; }

    public int CountyId { get; set; }

    public virtual County County { get; set; }

    public virtual FilterType FilterType { get; set; }
}
