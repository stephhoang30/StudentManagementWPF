using System;
using System.Collections.Generic;

namespace Project_ManageStudent_PRN212.Models;

public partial class Account
{
    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Role { get; set; }

	public virtual Student? Student { get; set; }

	public virtual Teacher? Teacher { get; set; }
}
