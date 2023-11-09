using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class DiningType
{
    public int DiningTypeId { get; set; }

    public string DiningTypeName { get; set; }

    public virtual ICollection<FilterDiningType> FilterDiningTypes { get; set; } = new List<FilterDiningType>();

    public virtual ICollection<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
}
