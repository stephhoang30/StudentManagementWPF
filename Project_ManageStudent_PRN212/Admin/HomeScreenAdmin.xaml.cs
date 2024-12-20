using Project_ManageStudent_PRN212.Login;
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
    /// Interaction logic for HomeScreenAdmin.xaml
    /// </summary>
    public partial class HomeScreenAdmin : Window
    {
        public HomeScreenAdmin()
        {
            InitializeComponent();
        }

        private void btnManageAccountTeacher(object sender, RoutedEventArgs e)
        {
            var teacher = new ManageAccountTeacher();
            teacher.Show();
            this.Close();
        }

        private void btnManageAccountStudent(object sender, RoutedEventArgs e)
        {
            var student = new ManageAccountStudent();
            student.Show();
            this.Close();
        }

        private void btnManageCourses(object sender, RoutedEventArgs e)
        {
            var course = new MangeCourse();
            course.Show();
            this.Close();
        }

        private void btnMangeRoom(object sender, RoutedEventArgs e)
        {
            var room = new ManageRooms();
            room.Show();
            this.Close();
        }

        private void btnManageStudent(object sender, RoutedEventArgs e)
        {
            var student = new ManageStudentInClass();
            student.Show();
            this.Close();
        }

        private void btnManageClass(object sender, RoutedEventArgs e)
        {
            var Classs = new ManageClass();
            Classs.Show();
            this.Close();
        }

		private void btnLogOut_Click(object sender, RoutedEventArgs e)
		{
            var logOut = new LoginScreen();
            logOut.Show();
            this.Close();
		}
	}
}
