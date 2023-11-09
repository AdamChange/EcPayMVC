using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class TakeOutOrderDetail
{
    /// <summary>
    /// PK 訂單明細ID
    /// </summary>
    public int TakeOutOrderDetailId { get; set; }

    /// <summary>
    /// FK 訂單ID
    /// </summary>
    public int TakeOutOrderId { get; set; }

    /// <summary>
    /// FK 產品ID
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// 記錄原產品名稱
    /// </summary>
    public string InitialProductName { get; set; }

    /// <summary>
    /// 產品價錢
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// 數量
    /// </summary>
    public int Quantity { get; set; }

    public virtual TakeOutOrder TakeOutOrder { get; set; }
}
