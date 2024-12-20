using System;
using System.Collections.Generic;

namespace FragrantWorld.Mode1s;

public partial class OrderStatus
{
    public int OrderStatusId { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
