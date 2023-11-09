using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class Product
{
    /// <summary>
    /// PK 產品ID
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// FK 餐廳ID
    /// </summary>
    public int RestaurantId { get; set; }

    /// <summary>
    /// FK 產品標題
    /// </summary>
    public int CustomizedMenuId { get; set; }

    /// <summary>
    /// 產品名稱
    /// </summary>
    public string ProductName { get; set; }

    /// <summary>
    /// 產品說明
    /// </summary>
    public string ProductContent { get; set; }

    /// <summary>
    /// 產品價錢
    /// </summary>
    public decimal UnitsPrice { get; set; }

    /// <summary>
    /// 庫存
    /// </summary>
    public int UnitsInStock { get; set; }

    /// <summary>
    /// 販售狀態
    /// </summary>
    public int Status { get; set; }

    /// <summary>
    /// 註冊時間
    /// </summary>
    public DateTime CreateDatetime { get; set; }

    public DateTime? UpdateDatetime { get; set; }

    public bool IsDeleted { get; set; }

    public virtual CustomizedMenu CustomizedMenu { get; set; }

    public virtual ICollection<Foodtag> Foodtags { get; set; } = new List<Foodtag>();

    public virtual Restaurant Restaurant { get; set; }
}
