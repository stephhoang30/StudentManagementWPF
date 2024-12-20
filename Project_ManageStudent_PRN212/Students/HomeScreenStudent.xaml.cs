using Project_ManageStudent_PRN212.Login;
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

namespace Project_ManageStudent_PRN212.Student
{
    /// <summary>
    /// Interaction logic for HomeScreenStudent.xaml
    /// </summary>
    public partial class HomeScreenStudent : Window
    {
        private string StudentID;
        public HomeScreenStudent(string studentID)
        {
            this.StudentID = studentID;
            InitializeComponent();
        }

		private void btnBackClick(object sender, RoutedEventArgs e)
		{
			var logOut = new LoginScreen();
			logOut.Show();
			this.Close();
        }

		private void window_load(object sender, RoutedEventArgs e)
		{
            LoadData();
		}

		private void LoadData()
		{
			var listClass = ProjectPrn212Context.INSTANCE.StudentClasses.Where(s => s.StudentId == StudentID)
																		.OrderBy(s => s.StudentId == StudentID)
																		.Select(s => new {
																			ClassID = s.Class.ClassId,
																			ClassName = s.Class.ClassName
																		});
			cbbClassId.ItemsSource = listClass.ToList();

			using (var context = new ProjectPrn212Context())
			{
			var	allStudentClasses = context.StudentClasses
					.Where(s => s.StudentId == StudentID)
					.OrderBy(s => s.Class.ClassName)
					.Select(s => new
					{
						ClassID = s.Class.ClassId,
						ClassName = s.Class.ClassName,
						CourseID = s.Class.CourseId,
						CourseName = s.Class.Course.CourseName,
						RoomID = s.Class.Room.RoomId,
						RoomName = s.Class.Room.RoomName
					})
					.ToList();

				lvStudents.ItemsSource = allStudentClasses;
			}
		}

		private void txtSearchClass(object sender, TextChangedEventArgs e)
		{
			var search = ProjectPrn212Context.INSTANCE.StudentClasses.Where(s => s.Class.ClassName.Contains(txtSearch.Text) && s.Student.Id == StudentID)
																	.OrderBy(s => s.Class.ClassName)
					.Select(s => new
					{
						ClassID = s.Class.ClassId,
						ClassName = s.Class.ClassName,
						CourseID = s.Class.CourseId,
						CourseName = s.Class.Course.CourseName,
						RoomID = s.Class.Room.RoomId,
						RoomName = s.Class.Room.RoomName
					})
					.ToList();
			lvStudents.ItemsSource = search;
		}

		private void searchClass(object sender, SelectionChangedEventArgs e)
		{
			var seacrhCBB = ProjectPrn212Context.INSTANCE.StudentClasses.Where(s => s.ClassId == int.Parse(cbbClassId.SelectedValue.ToString()) && s.StudentId == StudentID)
																		.Select(s => new
																		{
																			ClassID = s.Class.ClassId,
																			ClassName = s.Class.ClassName,
																			CourseID = s.Class.CourseId,
																			CourseName = s.Class.Course.CourseName,
																			RoomID = s.Class.Room.RoomId,
																			RoomName = s.Class.Room.RoomName
																		})
					.ToList();

			lvStudents.ItemsSource = seacrhCBB;
		}

		private void btnReset_click(object sender, RoutedEventArgs e)
		{
			using (var context = new ProjectPrn212Context())
			{
				var allStudentClasses = context.StudentClasses
						.Where(s => s.StudentId == StudentID)
						.OrderBy(s => s.Class.ClassName)
						.Select(s => new
						{
							ClassID = s.Class.ClassId,
							ClassName = s.Class.ClassName,
							CourseID = s.Class.CourseId,
							CourseName = s.Class.Course.CourseName,
							RoomID = s.Class.Room.RoomId,
							RoomName = s.Class.Room.RoomName
						})
						.ToList();

				lvStudents.ItemsSource = allStudentClasses;
			}
		}
    }
}
