using System;
using System.Collections.Generic;

namespace AddnewDB.Models;

public partial class Student
{
    public string Id { get; set; } = null!;

    public string StudentName { get; set; } = null!;

    public bool Gender { get; set; }

    public string Email { get; set; } = null!;

    public string AccountId { get; set; } = null!;

    public DateOnly BirthDate { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual ICollection<StudentClass> StudentClasses { get; set; } = new List<StudentClass>();
}
