using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class MealType
{
    /// <summary>
    /// PK 餐點種類ID
    /// </summary>
    public int MealTypeId { get; set; }

    /// <summary>
    /// 種類說明
    /// </summary>
    public string MealTypeName { get; set; }

    public virtual ICollection<FilterMealType> FilterMealTypes { get; set; } = new List<FilterMealType>();

    public virtual ICollection<RestaurantMealType> RestaurantMealTypes { get; set; } = new List<RestaurantMealType>();
}
