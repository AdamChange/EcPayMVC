using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class TakeOutOrder
{
    /// <summary>
    /// PK 外帶訂單ID
    /// </summary>
    public int TakeOutOrderId { get; set; }

    /// <summary>
    /// FK 會員ID 可為NUll
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// FK 餐廳ID
    /// </summary>
    public int RestaurantId { get; set; }

    /// <summary>
    /// 餐廳名稱
    /// </summary>
    public string RestaurantName { get; set; }

    /// <summary>
    /// 訂單成立時間
    /// </summary>
    public DateTime OrderDatetime { get; set; }

    /// <summary>
    /// 預計下訂時間
    /// </summary>
    public DateTime RequiredDatetime { get; set; }

    /// <summary>
    /// 訂單完成時間
    /// </summary>
    public DateTime? OrderCompletedDatetime { get; set; }

    /// <summary>
    /// 訂單完成狀態
    /// </summary>
    public int OrderFinishStatus { get; set; }

    /// <summary>
    /// 訂購人名稱
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 訂購人電話
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// 訂購人電子郵件
    /// </summary>
    public string Email { get; set; }

    public string EcPayCheckValue { get; set; }

    public string SpecialRequests { get; set; }

    public virtual Restaurant Restaurant { get; set; }

    public virtual ICollection<TakeOutOrderDetail> TakeOutOrderDetails { get; set; } = new List<TakeOutOrderDetail>();

    public virtual User User { get; set; }
}
