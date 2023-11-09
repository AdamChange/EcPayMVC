using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class FavoriteRestaurant
{
    /// <summary>
    /// PK
    /// </summary>
    public int FavoriteId { get; set; }

    /// <summary>
    /// FK 餐廳ID
    /// </summary>
    public int RestaurantId { get; set; }

    /// <summary>
    /// FK 會員ID
    /// </summary>
    public int UserId { get; set; }

    public virtual Restaurant Restaurant { get; set; }

    public virtual User User { get; set; }
}
