using System;
using System.Collections.Generic;

namespace AddnewDB.Models;

public partial class Teacher
{
    public string Id { get; set; } = null!;

    public string TeacherName { get; set; } = null!;

    public bool Gender { get; set; }

    public string Email { get; set; } = null!;

    public string AccountId { get; set; } = null!;

    public DateOnly BrithDate { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
}
