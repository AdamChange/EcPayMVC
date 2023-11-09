using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class FilterMealType
{
    public int FilterMealTypeId { get; set; }

    public int FilterTypeId { get; set; }

    /// <summary>
    /// FK
    /// </summary>
    public int MealTypeId { get; set; }

    public virtual FilterType FilterType { get; set; }

    public virtual MealType MealType { get; set; }
}
