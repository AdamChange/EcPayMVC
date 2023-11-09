using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class BookingOrder
{
    /// <summary>
    /// PK 訂單ID
    /// </summary>
    public int BookingOrderId { get; set; }

    /// <summary>
    /// FK 會員ID NULL
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// FK 餐廳ID
    /// </summary>
    public int RestaurantId { get; set; }

    /// <summary>
    /// 訂單成立時間
    /// </summary>
    public DateTime OrderDateTime { get; set; }

    /// <summary>
    /// 需要座位
    /// </summary>
    public int Seat { get; set; }

    /// <summary>
    /// 目的 可Null
    /// </summary>
    public string Purpose { get; set; }

    /// <summary>
    /// 特殊要求 可Null
    /// </summary>
    public string SpecialRequire { get; set; }

    /// <summary>
    /// 訂金金額 可Null
    /// </summary>
    public decimal? Deposit { get; set; }

    public string Name { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    /// <summary>
    /// 訂位用餐時間
    /// </summary>
    public DateTime DiningDatetime { get; set; }

    /// <summary>
    /// 訂單狀態
    /// </summary>
    public int Status { get; set; }

    public string EcPayCheckValue { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Participate> Participates { get; set; } = new List<Participate>();
}
