using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class User
{
    /// <summary>
    /// PK 會員ID
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// 註冊日期
    /// </summary>
    public DateTime RegistrationDatetime { get; set; }

    /// <summary>
    /// 姓
    /// </summary>
    public string FristName { get; set; }

    /// <summary>
    /// 名
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// 電子郵件
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// 電話
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// 地址
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// 特殊要求
    /// </summary>
    public string SpecialRequire { get; set; }

    /// <summary>
    /// 大頭貼URL
    /// </summary>
    public string ProfileImageUrl { get; set; }

    /// <summary>
    /// 評論代名
    /// </summary>
    public string CommentName { get; set; }

    /// <summary>
    /// 喜愛用餐地區
    /// </summary>
    public int? CountyId { get; set; }

    public DateTime? UpdateDatetime { get; set; }

    /// <summary>
    /// 生日
    /// </summary>
    public string Birthday { get; set; }

    public int? Authorized { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<DietaryPreference> DietaryPreferences { get; set; } = new List<DietaryPreference>();

    public virtual ICollection<FavoriteRestaurant> FavoriteRestaurants { get; set; } = new List<FavoriteRestaurant>();

    public virtual ICollection<LineLogin> LineLogins { get; set; } = new List<LineLogin>();

    public virtual ICollection<Participate> Participates { get; set; } = new List<Participate>();

    public virtual ICollection<ShopCart> ShopCarts { get; set; } = new List<ShopCart>();

    public virtual ICollection<TakeOutOrder> TakeOutOrders { get; set; } = new List<TakeOutOrder>();

    public virtual ICollection<UserLoginVeriCode> UserLoginVeriCodes { get; set; } = new List<UserLoginVeriCode>();
}
