using System;
using System.Collections.Generic;

namespace Project_ManageStudent_PRN212.Models;

public partial class Department
{
    public string DepartmenId { get; set; } = null!;

    public string DepartmentName { get; set; } = null!;

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
