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
	/// Interaction logic for ManageClass.xaml
	/// </summary>
	public partial class ManageClass : Window
	{
		public ManageClass()
		{
			InitializeComponent();
		}

		private void Window_Load(object sender, RoutedEventArgs e)
		{
			LoadData();
		}

		private void LoadData()
		{

			var rooms = ProjectPrn212Context.INSTANCE.Rooms.Select(c => new
			{
				RoomID = c.RoomId,
				RoomnName = c.RoomName
			}).ToList();
			cbbRoom.ItemsSource = rooms;
			var course = ProjectPrn212Context.INSTANCE.Courses.Select(c => new
			{
				CourseID = c.CourseId
			}).ToList();
			cbbCourse.ItemsSource = course;
			var Teacher = ProjectPrn212Context.INSTANCE.Teachers.Select(t => new
			{
				TeacherID = t.Id,
				TeacherName = t.TeacherName
			}).ToList();
			cbbTeacherID.ItemsSource = Teacher;
			var Classs = ProjectPrn212Context.INSTANCE.Classes.Select(c => new
			{
				ClassId = c.ClassId,
				ClassName = c.ClassName
			}).ToList();
			cbbClass.ItemsSource = Classs;
			var Clases = ProjectPrn212Context.INSTANCE.Classes.Select(c => new
			{
				ClassId = c.ClassId,
				ClassName = c.ClassName,
				Course = new
				{
					CourseID = c.Course.CourseId,
					CourseName = c.Course.CourseName
				},
				Teacher = new
				{
					TeacherID = c.Teacher.Id,
					TeacherName = c.Teacher.TeacherName
				},
				Room = new
				{
					RoomID = c.Room.RoomId,
					RoomName = c.Room.RoomName,
				}
			}).ToList();
			lvClass.ItemsSource = Clases;
		}

		private void load()
		{
			var classs = ProjectPrn212Context.INSTANCE.Classes.Select(c => new
			{
				Room = new
				{
					RoomID = c.Room.RoomId,
					Department = new
					{
						departmentID = c.Room.Department.DepartmenId,
						departmentName = c.Room.Department.DepartmentName
					}
				}
			}).ToList();
		}


		private void btnBackClick(object sender, RoutedEventArgs e)
		{
			var back = new HomeScreenAdmin();
			back.Show();
			this.Close();
		}

		private void btnInsertClick(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtClassname.Text))
			{
				MessageBox.Show("Class name cannot be empty");
				return;
			}

			if (cbbCourse.SelectedValue == null)
			{
				MessageBox.Show("Please choose a subject");
				return;
			}

			if (cbbTeacherID.SelectedValue == null)
			{
				MessageBox.Show("Please choose a teacher");
				return;
			}

			if (cbbRoom.SelectedValue == null)
			{
				MessageBox.Show("Please choose a Room");
				return;
			}

			string courseId = cbbCourse.SelectedValue.ToString();
			string teacherId = cbbTeacherID.SelectedValue.ToString();
			int roomId = int.Parse(cbbRoom.SelectedValue.ToString());

			bool classExists = ProjectPrn212Context.INSTANCE.Classes.Any(c =>
				c.CourseId == courseId &&
				c.TeacherId == teacherId &&
				c.RoomId == roomId);

			if (classExists)
			{
				MessageBox.Show("A class with the same course, room, and teacher already exists.");
				return;
			}

			Class cl = new Class
			{
				ClassName = txtClassname.Text,
				CourseId = courseId,
				TeacherId = teacherId,
				RoomId = roomId
			};

			ProjectPrn212Context.INSTANCE.Classes.Add(cl);
			ProjectPrn212Context.INSTANCE.SaveChanges();
			LoadData();
			MessageBox.Show("Insert class successfully");
		}


		private void btnDeleteClick(object sender, RoutedEventArgs e)
		{
			if (cbbClass.SelectedValue == null)
			{
				MessageBox.Show("Please select a class to delete");
				return;
			}

			int classId = int.Parse(cbbClass.SelectedValue.ToString());
			Class cla = ProjectPrn212Context.INSTANCE.Classes.FirstOrDefault(c => c.ClassId == classId);

			if (cla != null)
			{
				var result = MessageBox.Show("Are you sure you want to delete this class?", "Confirmation", MessageBoxButton.YesNo);
				if (result == MessageBoxResult.Yes)
				{
					ProjectPrn212Context.INSTANCE.Classes.Remove(cla);
					ProjectPrn212Context.INSTANCE.SaveChanges();
					LoadData();
					MessageBox.Show("Class deleted successfully");
				}
			}
			else
			{
				MessageBox.Show("Class not found");
			}
		}



		private void txtSearchInfoClass(object sender, TextChangedEventArgs e)
		{
			var Class = ProjectPrn212Context.INSTANCE.Classes.Where(cl => cl.ClassName.Contains(txtSearch.Text))
															 .Select(c => new
															 {
																 ClassId = c.ClassId,
																 ClassName = c.ClassName,
																 Course = new
																 {
																	 CourseID = c.Course.CourseId,
																	 CourseName = c.Course.CourseName
																 },
																 Teacher = new
																 {
																	 TeacherID = c.Teacher.Id,
																	 TeacherName = c.Teacher.TeacherName
																 },
																 Room = new
																 {
																	 RoomID = c.Room.RoomId,
																	 RoomName = c.Room.RoomName
																 }
															 }).ToList();
			lvClass.ItemsSource = Class;
		}

		private void btnUpdateClick(object sender, RoutedEventArgs e)
		{
			if (cbbClass.SelectedValue == null)
			{
				MessageBox.Show("Please select a class to update");
				return;
			}

			int classId = int.Parse(cbbClass.SelectedValue.ToString());
			Class cla = ProjectPrn212Context.INSTANCE.Classes.FirstOrDefault(c => c.ClassId == classId);

			if (cla != null)
			{
				string newClassName = !string.IsNullOrWhiteSpace(txtClassname.Text) ? txtClassname.Text : cla.ClassName;
				string newCourseId = cbbCourse.SelectedValue != null ? cbbCourse.SelectedValue.ToString() : cla.CourseId;
				string newTeacherId = cbbTeacherID.SelectedValue != null ? cbbTeacherID.SelectedValue.ToString() : cla.TeacherId;
				int newRoomId = cbbRoom.SelectedValue != null ? int.Parse(cbbRoom.SelectedValue.ToString()) : cla.RoomId;

				// Check if a class with the same course, room, and teacher already exists
				bool classExists = ProjectPrn212Context.INSTANCE.Classes.Any(c =>
					c.CourseId == newCourseId &&
					c.TeacherId == newTeacherId &&
					c.RoomId == newRoomId &&
					c.ClassId != classId);

				if (classExists)
				{
					MessageBox.Show("A class with the same course, room, and teacher already exists.");
					return;
				}

				cla.ClassName = newClassName;
				cla.CourseId = newCourseId;
				cla.TeacherId = newTeacherId;
				cla.RoomId = newRoomId;

				ProjectPrn212Context.INSTANCE.SaveChanges();
				LoadData();
				MessageBox.Show("Update Class successfully");
			}
			else
			{
				MessageBox.Show("Class not found");
			}
		}

	}
}
