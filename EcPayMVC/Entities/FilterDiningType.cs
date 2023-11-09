using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class FilterDiningType
{
    public int FilterDiningTypeId { get; set; }

    public int FilterTypeId { get; set; }

    public int DiningTypeId { get; set; }

    public virtual DiningType DiningType { get; set; }

    public virtual FilterType FilterType { get; set; }
}
