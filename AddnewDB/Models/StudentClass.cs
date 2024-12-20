using System;
using System.Collections.Generic;

namespace AddnewDB.Models;

public partial class StudentClass
{
    public int Id { get; set; }

    public string? StudentId { get; set; }

    public int? ClassId { get; set; }

    public string? CourseId { get; set; }

    public virtual Class? Class { get; set; }

    public virtual Course? Course { get; set; }

    public virtual Student? Student { get; set; }
}
