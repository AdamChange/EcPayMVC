using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class RestaurantHashtag
{
    /// <summary>
    /// PK
    /// </summary>
    public int RestaurantHashtagId { get; set; }

    /// <summary>
    /// FK TagID
    /// </summary>
    public int HashtagId { get; set; }

    /// <summary>
    /// FK 餐廳ID
    /// </summary>
    public int RestaurantId { get; set; }

    public virtual Hashtag Hashtag { get; set; }

    public virtual Restaurant Restaurant { get; set; }
}
