using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class Hashtag
{
    /// <summary>
    /// PK HashtagID
    /// </summary>
    public int HashtagId { get; set; }

    /// <summary>
    /// Hashtag名稱
    /// </summary>
    public string HashtagName { get; set; }

    public virtual ICollection<RestaurantHashtag> RestaurantHashtags { get; set; } = new List<RestaurantHashtag>();
}
