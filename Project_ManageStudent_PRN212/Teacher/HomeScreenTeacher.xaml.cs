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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_ManageStudent_PRN212.Teacher
{
    /// <summary>
    /// Interaction logic for HomeScreenTeacher.xaml
    /// </summary>
    public partial class HomeScreenTeacher : Window
    {
		private string teacherId;
		public HomeScreenTeacher(string teacherID)
        {
            this.teacherId = teacherID;
            InitializeComponent();
        }

		private void Window_Load(object sender, RoutedEventArgs e)
		{
            Load();
		}

		private void Load()
		{
			var classID = ProjectPrn212Context.INSTANCE.Classes.Where(t => t.TeacherId == teacherId).OrderBy(t => t.ClassName)
																.Select(t => new
																{
																	ClassID = t.ClassId,
																	ClassName = t.ClassName
																}).ToList();
			cbbClassId.ItemsSource = classID;
			var tcClass = ProjectPrn212Context.INSTANCE.Classes.Where(t => t.TeacherId == teacherId)
																.OrderBy(t => t.ClassName)
																.Select(t => new
																{
																	ClassID = t.ClassId,
																	ClassName = t.ClassName,
																	Course = new
																	{
																		CourseID = t.Course.CourseId,
																		CourseName = t.Course.CourseName
																	},
																	Room = new
																	{
																		RoomID = t.Room.RoomId,
																		RoomName = t.Room.RoomName
																	}
																}).ToList();
			lvTeacherClass.ItemsSource = tcClass;
		}

		private void txtSearchClass(object sender, TextChangedEventArgs e)
		{
			var search = ProjectPrn212Context.INSTANCE.Classes.Where(t => t.ClassName.Contains(txtSearch.Text) && t.TeacherId == teacherId).
															Select(t => new
			{
				ClassID = t.ClassId,
				ClassName = t.ClassName,
				Course = new
				{
					CourseID = t.Course.CourseId,
					CourseName = t.Course.CourseName
				},
				Room = new
				{
					RoomID = t.Room.RoomId,
					RoomName = t.Room.RoomName
				}
			}).ToList();
			lvTeacherClass.ItemsSource = search;
		}

		private void GetListStudent(object sender, SelectionChangedEventArgs e)
		{
			var getStudent = ProjectPrn212Context.INSTANCE.StudentClasses.Where(s => s.ClassId == int.Parse(cbbClassId.SelectedValue.ToString())).
				Select(s => new
			{
					Student = new
					{
						StudentID = s.Student.Id,
						StudentName = s.Student.StudentName,
						Gender = s.Student.Gender == true ? "Male": "Female",
						Email = s.Student.Email,
						BirhthDate = s.Student.BirthDate,

					}
			}).ToList();
			lvStudent.ItemsSource = getStudent;
		}

		private void btnBackClick(object sender, RoutedEventArgs e)
		{
			var login = new LoginScreen();
			login.Show();
			this.Close();
		}

		private void searchClass(object sender, SelectionChangedEventArgs e)
		{
			var search = ProjectPrn212Context.INSTANCE.StudentClasses.Where(s => s.ClassId == int.Parse(cbbClassId.SelectedValue.ToString())).
				Select(s => new
				{
					Student = new
					{
						StudentID = s.Student.Id,
						StudentName = s.Student.StudentName,
						Gender = s.Student.Gender == true ? "Male" : "Female",
						Email = s.Student.Email,
						BirhthDate = s.Student.BirthDate,

					}
				}).ToList();
			lvStudent.ItemsSource = search;
		}
	}
}
