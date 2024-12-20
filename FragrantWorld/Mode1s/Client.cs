using System;
using System.Collections.Generic;

namespace FragrantWorld.Mode1s;

public partial class Client
{
    public int ClientOrderId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? Patronymic { get; set; }

    public virtual Order ClientOrder { get; set; } = null!;
}
