using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class ShopCart
{
    /// <summary>
    /// PK 購物車ID
    /// </summary>
    public int ShopCartId { get; set; }

    /// <summary>
    /// FK 餐廳ID
    /// </summary>
    public int RestaurantId { get; set; }

    /// <summary>
    /// FK 會員ID 可NULL
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// 預定下購日期
    /// </summary>
    public DateTime RequireDatetime { get; set; }

    public string SpecialRequests { get; set; }

    public virtual Restaurant Restaurant { get; set; }

    public virtual ICollection<ShopCartsDetail> ShopCartsDetails { get; set; } = new List<ShopCartsDetail>();

    public virtual User User { get; set; }
}
