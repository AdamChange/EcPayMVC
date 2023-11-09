using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class Comment
{
    /// <summary>
    /// PK 評論ID
    /// </summary>
    public int CommentId { get; set; }

    /// <summary>
    /// FK 餐廳ID
    /// </summary>
    public int RestaurantId { get; set; }

    /// <summary>
    /// FK 會員ID
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// FK 訂單ID
    /// </summary>
    public int BookingOrderId { get; set; }

    /// <summary>
    /// 匿名代稱
    /// </summary>
    public string CommentName { get; set; }

    /// <summary>
    /// 評論日期
    /// </summary>
    public DateTime CommentDatetime { get; set; }

    /// <summary>
    /// 評論內容
    /// </summary>
    public string CommentContent { get; set; }

    /// <summary>
    /// 食物評分
    /// </summary>
    public decimal Food { get; set; }

    /// <summary>
    /// 服務評分
    /// </summary>
    public decimal Service { get; set; }

    /// <summary>
    /// 氣氛屏風
    /// </summary>
    public decimal Ambience { get; set; }

    /// <summary>
    /// 噪音評分
    /// </summary>
    public decimal Noise { get; set; }

    public virtual BookingOrder BookingOrder { get; set; }

    public virtual Restaurant Restaurant { get; set; }

    public virtual User User { get; set; }
}
