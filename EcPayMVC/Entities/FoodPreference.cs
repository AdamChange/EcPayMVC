using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class FoodPreference
{
    /// <summary>
    /// PK 飲食偏好ID
    /// </summary>
    public int FoodPreferenceId { get; set; }

    /// <summary>
    /// 飲食偏好名稱
    /// </summary>
    public string FoodPreferName { get; set; }

    /// <summary>
    /// 說明
    /// </summary>
    public string Description { get; set; }

    public virtual ICollection<DietaryPreference> DietaryPreferences { get; set; } = new List<DietaryPreference>();

    public virtual ICollection<Foodtag> Foodtags { get; set; } = new List<Foodtag>();
}
