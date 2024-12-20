using System;
using System.Collections.Generic;

namespace Project_ManageStudent_PRN212.Models;

public partial class Course
{
    public string CourseId { get; set; } = null!;

    public string CourseName { get; set; } = null!;

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
	public virtual ICollection<StudentClass> StudentClasses { get; set; } = new List<StudentClass>();
}
