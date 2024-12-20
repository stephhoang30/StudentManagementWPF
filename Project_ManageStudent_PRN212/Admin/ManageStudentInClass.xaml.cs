using Project_ManageStudent_PRN212.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Project_ManageStudent_PRN212.Admin
{
	/// <summary>
	/// Interaction logic for ManageStudent.xaml
	/// </summary>
	public partial class ManageStudentInClass : Window
	{
		public ManageStudentInClass()
		{
			InitializeComponent();
		}

		private void btnInsertClick(object sender, RoutedEventArgs e)
		{
			string courseId = cbbCourseId.SelectedValue.ToString();
			if (string.IsNullOrEmpty(courseId))
			{
				MessageBox.Show("Invalid course Id");
			}
			
			int classId;
			if (!int.TryParse(cbbClassId.SelectedValue.ToString(), out classId))
			{
				MessageBox.Show("Invalid class ID.");
				return;
			}

			string studentId = cbbStudentId.SelectedValue?.ToString();
			if (string.IsNullOrEmpty(studentId))
			{
				MessageBox.Show("Invalid student ID.");
				return;
			}

			bool studentExitIncourse = ProjectPrn212Context.INSTANCE.StudentClasses.Any(s => s.StudentId == studentId && s.CourseId == courseId);
			if (studentExitIncourse)
			{
				MessageBox.Show($"Student is leanring cousre {courseId} please choose other course");
				return;
			}

			bool studentInClassExists = ProjectPrn212Context.INSTANCE.StudentClasses
				.Any(s => s.ClassId == classId && s.StudentId == studentId && s.CourseId == courseId);

			if (studentInClassExists)
			{
				MessageBox.Show("Student is already in the class! Add failed.");
				return;
			}

			StudentClass newStudentClass = new StudentClass
			{
				ClassId = classId,
				StudentId = studentId,
				CourseId =courseId
			};
			ProjectPrn212Context.INSTANCE.StudentClasses.Add(newStudentClass);
			ProjectPrn212Context.INSTANCE.SaveChanges();
			Load();
			MessageBox.Show("Student added to the class successfully.");
		}


		private void btnUpdateClick(object sender, RoutedEventArgs e)
		{
			StudentClass stuc = ProjectPrn212Context.INSTANCE.StudentClasses.FirstOrDefault(s => s.Id == int.Parse(txtStudentClass.Text));
			if (stuc != null)
			{
				stuc.StudentId = cbbStudentId.SelectedValue.ToString();
				stuc.ClassId = int.Parse(cbbClassId.SelectedValue.ToString());
				ProjectPrn212Context.INSTANCE.SaveChanges();
				Load();
				MessageBox.Show("Update successfully");
			}
			else
			{
				MessageBox.Show("Student is not existed in class");
			}
		}

		private void btnDeleteClick(object sender, RoutedEventArgs e)
		{
			StudentClass stuc = ProjectPrn212Context.INSTANCE.StudentClasses.FirstOrDefault(s => s.Id == int.Parse(txtStudentClass.Text));
			if (stuc != null)
			{
				var result = MessageBox.Show("Do you want delete this student in class?", "Confirmation", MessageBoxButton.YesNo);
				if(result == MessageBoxResult.Yes)
				{
					ProjectPrn212Context.INSTANCE.StudentClasses.Remove(stuc);
					ProjectPrn212Context.INSTANCE.SaveChanges();
					Load();
					MessageBox.Show("Delete successfully");
				}
					
			}
			else
			{
				MessageBox.Show("Student is not existed in class");
			}
		}

		private void SearchStuent(object sender, TextChangedEventArgs e)
		{
			var stucs = ProjectPrn212Context.INSTANCE.StudentClasses.Where(sc => sc.Class.ClassName.Contains(txtSearch.Text) || sc.StudentId.Contains(txtSearch.Text))
																			.Select(sc => new
																			{
																				ID = sc.Id,
																				Class = new
																				{
																					ClassID = sc.Class.ClassId,
																					ClassName = sc.Class.ClassName,
														
																				},
																				CourseID = sc.CourseId,
																				Student = new
																				{
																					StudentID = sc.Student.Id,
																					StudentName = sc.Student.StudentName
																				}
																			}).ToList();
			LvStudentInClass.ItemsSource = stucs;
		}

		private void btnBackClick(object sender, RoutedEventArgs e)
		{
			var back = new HomeScreenAdmin();
			back.Show();
			this.Close();
		}

		private void Window_Load(object sender, RoutedEventArgs e)
		{
			Load();
		}

		private void Load()
		{
			var course = ProjectPrn212Context.INSTANCE.Courses.Select(c => new
			{
				CourseID = c.CourseId
			}).ToList();
			cbbCourseId.ItemsSource = course;
			var studentInClass = ProjectPrn212Context.INSTANCE.StudentClasses
				.Select(sc => new
				{
					ID = sc.Id,
					Class = new
					{
						ClassID = sc.Class.ClassId,
						ClassName = sc.Class.ClassName,
					},
					CourseID = sc.CourseId,
					Student = new
					{
						StudentID = sc.Student.Id,
						StudentName = sc.Student.StudentName
					}
				}).ToList();
			LvStudentInClass.ItemsSource = studentInClass;

			var classesWithCourses = ProjectPrn212Context.INSTANCE.Classes
				.Select(c => new
				{
					ClassID = c.ClassId,
					ClassNameCourseID = c.ClassName + " - " + c.CourseId
				})
				.Distinct()
				.ToList();
			cbbClassId.ItemsSource = classesWithCourses;

			var students = ProjectPrn212Context.INSTANCE.Students
				.Select(s => new
				{
					StudentID = s.Id,
					StudentName = s.StudentName
				})
				.ToList();
			cbbStudentId.ItemsSource = students;
		}

	}
}
