using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class BusinessHour
{
    /// <summary>
    /// PK ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// FK 餐廳
    /// </summary>
    public int RestaurantId { get; set; }

    /// <summary>
    /// 禮拜幾
    /// </summary>
    public int DayOfWeek { get; set; }

    /// <summary>
    /// 開始時間
    /// </summary>
    public TimeSpan StarTime { get; set; }

    /// <summary>
    /// 結束時間
    /// </summary>
    public TimeSpan EndTime { get; set; }

    public int Status { get; set; }

    public virtual Restaurant Restaurant { get; set; }
}
