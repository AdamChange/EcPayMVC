using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class District
{
    /// <summary>
    /// PK 鄉鎮市區ID
    /// </summary>
    public int DistrictId { get; set; }

    /// <summary>
    /// FK 縣市ID
    /// </summary>
    public int CountyId { get; set; }

    /// <summary>
    /// 英文名稱
    /// </summary>
    public string EnglishOfName { get; set; }

    /// <summary>
    /// 中文名稱
    /// </summary>
    public string ChineseOfName { get; set; }

    public virtual County County { get; set; }

    public virtual ICollection<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
}
