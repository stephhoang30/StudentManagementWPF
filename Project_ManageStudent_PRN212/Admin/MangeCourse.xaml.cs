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
	/// Interaction logic for MangeCourse.xaml
	/// </summary>
	public partial class MangeCourse : Window
	{
		public MangeCourse()
		{
			InitializeComponent();
		}

		private void Window_Load(object sender, RoutedEventArgs e)
		{
			Load();
		}

		private void Load()
		{
			var course = ProjectPrn212Context.INSTANCE.Courses.Select(x => new
			{
				courseID = x.CourseId,
				courseName = x.CourseName
			}).ToList();
			lvCourses.ItemsSource = course;
		}

		private void btnInsertClick(object sender, RoutedEventArgs e)
		{
			Course c = ProjectPrn212Context.INSTANCE.Courses.FirstOrDefault(x => x.CourseId == txtCourseId.Text);
			if (c != null)
			{
				MessageBox.Show("Course is existing");
			}
			else
			{
				Course course = new Course
				{
					CourseId = txtCourseId.Text,
					CourseName = txtCourseNamee.Text
				};
				ProjectPrn212Context.INSTANCE.Courses.Add(course);
				ProjectPrn212Context.INSTANCE.SaveChanges();
				Load();
				MessageBox.Show("add course successfully");
			}
		}

		private void btnUpdateClick(object sender, RoutedEventArgs e)
		{
			Course c = ProjectPrn212Context.INSTANCE.Courses.FirstOrDefault(x => x.CourseId == txtCourseId.Text);
			if (c != null)
			{
				var result = MessageBox.Show("Do you want delete this course?", "Confirmation", MessageBoxButton.YesNo);
				if(result == MessageBoxResult.Yes)
				{
					c.CourseId = txtCourseId.Text;
					c.CourseName = txtCourseNamee.Text;
					ProjectPrn212Context.INSTANCE.SaveChanges();
					Load();
					MessageBox.Show("Update course successfully");
				}
			}
			else
			{
				MessageBox.Show("Course is not exist");
			}
		}

		private void btnDeleteClick(object sender, RoutedEventArgs e)
		{
			Course c = ProjectPrn212Context.INSTANCE.Courses.FirstOrDefault(x => x.CourseId == txtCourseId.Text);
			if (c != null)
			{
				ProjectPrn212Context.INSTANCE.Courses.Remove(c);
				ProjectPrn212Context.INSTANCE.SaveChanges();
				Load();
				MessageBox.Show("Delete course successfully");
			}
			else
			{
				MessageBox.Show("Course is not exist");
			}
		}

		private void SearchCourse(object sender, TextChangedEventArgs e)
		{
			var courses = ProjectPrn212Context.INSTANCE.Courses.Where(c => c.CourseId.Contains(txtSearch.Text))
																.Select(c => new
																{
																	courseID = c.CourseId,
																	courseName = c.CourseName
																}).ToList();
			lvCourses.ItemsSource = courses;
		}

		private void btnBackClick(object sender, RoutedEventArgs e)
		{
			var back = new HomeScreenAdmin();
			back.Show();
			this.Close();
		}
	}
}
