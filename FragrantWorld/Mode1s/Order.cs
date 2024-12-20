using System;
using System.Collections.Generic;

namespace FragrantWorld.Mode1s;

public partial class Order
{
    public int OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime DeliveryDate { get; set; }

    public int PickupPoint { get; set; }

    public int PickupCode { get; set; }

    public int OrderStatus { get; set; }

    public virtual Client? Client { get; set; }

    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    public virtual OrderStatus OrderStatusNavigation { get; set; } = null!;

    public virtual PickupPoint PickupPointNavigation { get; set; } = null!;
}
