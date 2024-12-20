using Project_ManageStudent_PRN212.Admin;
using Project_ManageStudent_PRN212.Models;
using Project_ManageStudent_PRN212.Student;
using Project_ManageStudent_PRN212.Teacher;
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

namespace Project_ManageStudent_PRN212.Login
{
	/// <summary>
	/// Interaction logic for LoginScreen.xaml
	/// </summary>
	public partial class LoginScreen : Window
	{
		public LoginScreen()
		{
			InitializeComponent();
		}

		private void BtnSubmit_Click(object sender, RoutedEventArgs e)
		{
			var username = txtUsername.Text;
			var password = txtPassword.Password;
			var account = ProjectPrn212Context.INSTANCE.Accounts.FirstOrDefault(a => a.UserName == username && a.Password == password);
			if (account != null)
			{
				switch (account.Role)
				{
					case 1:
						var admin = new HomeScreenAdmin();
						admin.Show();
						break;
					case 2:
						var student = ProjectPrn212Context.INSTANCE.Students.FirstOrDefault(s => s.AccountId == username);
						if(student != null)
						{
							var homeStudent = new HomeScreenStudent(student.Id);
							homeStudent.Show();
						}
						
						break;
					case 3:
						var teacher = ProjectPrn212Context.INSTANCE.Teachers.FirstOrDefault(t => t.AccountId == account.UserName);
						if(teacher != null)
						{
							var homeTeacher = new HomeScreenTeacher(teacher.Id);
							homeTeacher.Show();
						}
						
						break;
					default:
						break;
				}
				this.Close();
			}
			else
			{
				MessageBox.Show("Information username or password not valid please check again");
			}
		}
	}
}
