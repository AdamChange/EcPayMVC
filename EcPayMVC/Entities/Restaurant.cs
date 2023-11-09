using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class Restaurant
{
    /// <summary>
    /// PK 餐廳ID
    /// </summary>
    public int RestaurantId { get; set; }

    /// <summary>
    /// 餐廳註冊日期
    /// </summary>
    public DateTime RegistrationDate { get; set; }

    /// <summary>
    /// 餐廳名稱
    /// </summary>
    public string RestaurantName { get; set; }

    /// <summary>
    /// FK 餐廳價錢級距
    /// </summary>
    public int PriceRangeId { get; set; }

    /// <summary>
    /// FK 餐廳風格種類
    /// </summary>
    public int RestaurantStyleId { get; set; }

    /// <summary>
    /// 餐廳自介
    /// </summary>
    public string Introduction { get; set; }

    /// <summary>
    /// 訂金金額，可同時判斷是否需要預付訂金
    /// </summary>
    public decimal? DepositPrice { get; set; }

    /// <summary>
    /// 餐廳評論均分
    /// </summary>
    public decimal? CommentPoints { get; set; }

    /// <summary>
    /// 菜單Url
    /// </summary>
    public string MenuUrl { get; set; }

    /// <summary>
    /// 經度
    /// </summary>
    public decimal? Longitude { get; set; }

    /// <summary>
    /// 緯度
    /// </summary>
    public decimal? Latitude { get; set; }

    /// <summary>
    /// FK 鄉鎮市區種類
    /// </summary>
    public int DistrictId { get; set; }

    /// <summary>
    /// 詳細地址
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// 餐廳電話
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// 餐廳可容納人數
    /// </summary>
    public int NumberOfSeat { get; set; }

    /// <summary>
    /// 用餐時間
    /// </summary>
    public int DiningTime { get; set; }

    /// <summary>
    /// 狀態欄位
    /// </summary>
    public int Status { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    public int? Sponsor { get; set; }

    /// <summary>
    /// 外帶未來可預訂天數
    /// </summary>
    public int TakeOutAvaliableDays { get; set; }

    /// <summary>
    /// 訂位未來可預訂天數
    /// </summary>
    public int BookAvaliableDays { get; set; }

    /// <summary>
    /// FK
    /// </summary>
    public int DiningTypeId { get; set; }

    /// <summary>
    /// 餐廳主圖
    /// </summary>
    public string MainPhoto { get; set; }

    public DateTime? UpdateDatetime { get; set; }

    public string OrderNote { get; set; }

    public virtual ICollection<BookingSeatStatistic> BookingSeatStatistics { get; set; } = new List<BookingSeatStatistic>();

    public virtual ICollection<BusinessHour> BusinessHours { get; set; } = new List<BusinessHour>();

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual DiningType DiningType { get; set; }

    public virtual District District { get; set; }

    public virtual ICollection<FavoriteRestaurant> FavoriteRestaurants { get; set; } = new List<FavoriteRestaurant>();

    public virtual PriceRange PriceRange { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<RestaurantHashtag> RestaurantHashtags { get; set; } = new List<RestaurantHashtag>();

    public virtual ICollection<RestaurantMealType> RestaurantMealTypes { get; set; } = new List<RestaurantMealType>();

    public virtual RestaurantStyle RestaurantStyle { get; set; }

    public virtual ICollection<RestaurantsMultimedia> RestaurantsMultimedia { get; set; } = new List<RestaurantsMultimedia>();

    public virtual ICollection<ShopCart> ShopCarts { get; set; } = new List<ShopCart>();

    public virtual ICollection<TakeOutOrder> TakeOutOrders { get; set; } = new List<TakeOutOrder>();
}
