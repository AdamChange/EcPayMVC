using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class RestaurantMealType
{
    public int Id { get; set; }

    /// <summary>
    /// FK
    /// </summary>
    public int RestaurantId { get; set; }

    /// <summary>
    /// FK
    /// </summary>
    public int MealTypeId { get; set; }

    public virtual MealType MealType { get; set; }

    public virtual Restaurant Restaurant { get; set; }
}
