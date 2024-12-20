using System;
using System.Collections.Generic;

namespace FragrantWorld.Mode1s;

public partial class User
{
    public int UserId { get; set; }

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? Patronymic { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public int? UserRole { get; set; }

    public virtual Role? UserRoleNavigation { get; set; }
}
