using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class DietaryPreference
{
    /// <summary>
    /// PK 偏好ID
    /// </summary>
    public int DietaryPreferenceId { get; set; }

    /// <summary>
    /// FK 會員ID
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// FK 飲食偏好ID
    /// </summary>
    public int FoodPreferenceId { get; set; }

    public virtual FoodPreference FoodPreference { get; set; }

    public virtual User User { get; set; }
}
