using System;
using System.Collections.Generic;

namespace AddnewDB.Models;

public partial class Room
{
    public int RoomId { get; set; }

    public string? DepartmentId { get; set; }

    public string? RoomName { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();

    public virtual Department? Department { get; set; }
}
