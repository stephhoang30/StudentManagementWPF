using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Project_ManageStudent_PRN212.Models;

public partial class Teacher
{
    public string Id { get; set; } = null!;

    public string TeacherName { get; set; } = null!;

    public bool Gender { get; set; }

    public string Email { get; set; } = null!;

    public string AccountId { get; set; } = null!;

    public DateOnly BrithDate { get; set; }

    public virtual Account Account { get; set; } = null!;
    [XmlIgnore]
    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
}
