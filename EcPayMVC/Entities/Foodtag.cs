using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class Foodtag
{
    public int Id { get; set; }

    public int FoodtagsId { get; set; }

    public int ProductId { get; set; }

    public virtual FoodPreference Foodtags { get; set; }

    public virtual Product Product { get; set; }
}
