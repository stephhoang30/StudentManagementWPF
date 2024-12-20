using System;
using System.Collections.Generic;

namespace AddnewDB.Models;

public partial class Department
{
    public string DepartmenId { get; set; } = null!;

    public string DepartmentName { get; set; } = null!;

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
