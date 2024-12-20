using System;
using System.Collections.Generic;

namespace FragrantWorld.Mode1s;

public partial class PickupPoint
{
    public int PickupPointId { get; set; }

    public int PostalCode { get; set; }

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public int? HouseNumber { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
