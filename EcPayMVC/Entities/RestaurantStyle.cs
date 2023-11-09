using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class RestaurantStyle
{
    /// <summary>
    /// PK 餐廳種類ID
    /// </summary>
    public int RestaurantStyleId { get; set; }

    /// <summary>
    /// 種類說明
    /// </summary>
    public string RestaurantStyleName { get; set; }

    public virtual ICollection<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
}
