using System;
using System.Collections.Generic;

namespace AddnewDB.Models;

public partial class Account
{
    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Role { get; set; }

    public virtual Student? Student { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
