using System;
using System.Collections.Generic;

namespace Project_ManageStudent_PRN212.Models;

public partial class Class
{
    public int ClassId { get; set; }

    public string? ClassName { get; set; }

    public string CourseId { get; set; } = null!;

    public string TeacherId { get; set; } = null!;

    public int RoomId { get; set; }

    public virtual Course Course { get; set; } = null!;

    public virtual Room Room { get; set; } = null!;

    public virtual ICollection<StudentClass> StudentClasses { get; set; } = new List<StudentClass>();

    public virtual Teacher Teacher { get; set; } = null!;
}
