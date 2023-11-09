using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class County
{
    /// <summary>
    /// PK 縣市ID
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

    public virtual ICollection<District> Districts { get; set; } = new List<District>();

    public virtual ICollection<FilterCounty> FilterCounties { get; set; } = new List<FilterCounty>();
}
