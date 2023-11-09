using System;
using System.Collections.Generic;

namespace EcPayMVC.Entities;

public partial class BookingSeatStatistic
{
    public int BookingSeatStatisticsId { get; set; }

    public int RestaurantId { get; set; }

    public DateTime BookingDateTime { get; set; }

    public int AllBookingSeat { get; set; }

    public virtual Restaurant Restaurant { get; set; }
}
