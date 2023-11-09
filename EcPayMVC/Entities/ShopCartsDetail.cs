using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class ShopCartsDetail
{
    public int ShopCartDetailsId { get; set; }

    public int ShopCartId { get; set; }

    /// <summary>
    /// FK 產品ID
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// 數量
    /// </summary>
    public int Quantity { get; set; }

    public virtual ShopCart ShopCart { get; set; }
}
