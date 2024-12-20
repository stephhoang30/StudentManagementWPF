using Microsoft.Win32;
using Project_ManageStudent_PRN212.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_ManageStudent_PRN212.Admin
{
	/// <summary>
	/// Interaction logic for ManageAccountTeacher.xaml
	/// </summary>
	public partial class ManageAccountTeacher : Window
	{
		public ManageAccountTeacher()
		{
			InitializeComponent();
		}

		private void window_load(object sender, RoutedEventArgs e)
		{
			load();
		}

		private void load()
		{
			var teacher = ProjectPrn212Context.INSTANCE.Teachers.Select(t => new
			{
				TeacherID = t.Id,
				TeacherName = t.TeacherName,
				Gender = t.Gender,
				Email = t.Email,
				BirthDate = t.BrithDate,
				account = new
				{
					username = t.Account.UserName,
					password = t.Account.Password,
					Role = t.Account.Role,
				}
			}).ToList();
			lvTeachers.ItemsSource = teacher;
		}

		private void btnInsertClick(object sender, RoutedEventArgs e)
		{
			bool gender = rbMale.IsChecked == true;
			Project_ManageStudent_PRN212.Models.Teacher teacher = ProjectPrn212Context.INSTANCE.Teachers.FirstOrDefault(t => t.Id == txtTeacherID.Text);
			if (teacher != null)
			{
				MessageBox.Show("Teacher is already existing");
			}
			else
			{
				Project_ManageStudent_PRN212.Models.Teacher tea = new Models.Teacher
				{
					Id = txtTeacherID.Text,
					TeacherName = txtTeacherName.Text,
					Gender = gender,
					Email = txtEmail.Text,
					BrithDate = DateOnly.Parse(txtBirthDate.Text)
				};

				var accountExit = ProjectPrn212Context.INSTANCE.Accounts.FirstOrDefault(a => a.UserName == txtUserName.Text);
				if (accountExit != null)
				{
					MessageBox.Show("account is existing. Please choose a different username.");
				}
				else
				{
					Account a = new Account
					{
						UserName = txtUserName.Text,
						Password = txtPassword.Text,
						Role = 3
					};
					tea.Account = a;
					ProjectPrn212Context.INSTANCE.Teachers.Add(tea);
					ProjectPrn212Context.INSTANCE.SaveChanges();
					load();
					MessageBox.Show("Insert account successfully");
				}
			}

		}

		private void btnUpdateClick(object sender, RoutedEventArgs e)
		{
			bool gender = rbMale.IsChecked == true;
			Project_ManageStudent_PRN212.Models.Teacher teacher = ProjectPrn212Context.INSTANCE.Teachers.FirstOrDefault(s => s.Id == txtTeacherID.Text);

			if (teacher != null)
			{
				if (teacher.Account != null && teacher.Account.UserName != txtUserName.Text)
				{
					MessageBox.Show("The username or MSSV entered does not match your current username or MSSV. Please enter the correct username OR MSSV.");
					return;
				}

				teacher.TeacherName = txtTeacherName.Text;
				teacher.Email = txtEmail.Text;
				teacher.Gender = gender;
				teacher.BrithDate = DateOnly.Parse(txtBirthDate.Text);
			}
			else
			{
				MessageBox.Show("Teacher does not exist.");
				return;
			}

			Account a = ProjectPrn212Context.INSTANCE.Accounts.FirstOrDefault(a => a.UserName == txtUserName.Text);
			if (a != null)
			{
				if (teacher.Account != a)
				{
					MessageBox.Show("The username or MSSV entered does not match your current username or MSSV. Please enter the correct username OR MSSV.");
					return;
				}

				a.Password = txtPassword.Text;
				teacher.Account = a;

				ProjectPrn212Context.INSTANCE.SaveChanges();
				load();
				MessageBox.Show("Update information of teacher successfully.");
			}
			else
			{
				MessageBox.Show("Account does not exist.");
			}
		}


		private void btnBackClick(object sender, RoutedEventArgs e)
		{
			var back = new HomeScreenAdmin();
			back.Show();
			this.Close();
		}

		private void txtSearchInfoTeacher(object sender, TextChangedEventArgs e)
		{
			var searchTea = ProjectPrn212Context.INSTANCE.Teachers.Where(t => t.Id.Contains(txtSearch.Text) || t.TeacherName.Contains(txtSearch.Text))
																	.Select(t => new
																	{

																		TeacherID = t.Id,
																		TeacherName = t.TeacherName,
																		Gender = t.Gender,
																		Email = t.Email,
																		BirthDate = t.BrithDate,
																		account = new
																		{
																			username = t.Account.UserName,
																			password = t.Account.Password,
																			Role = t.Account.Role,
																		}
																	}).ToList();
			lvTeachers.ItemsSource = searchTea;
		}

		private void btnDeleteClick(object sender, RoutedEventArgs e)
		{
			Project_ManageStudent_PRN212.Models.Teacher teacher = ProjectPrn212Context.INSTANCE.Teachers.FirstOrDefault(t => t.Id == txtTeacherID.Text);
			if(teacher != null)
			{
				Project_ManageStudent_PRN212.Models.Account account = ProjectPrn212Context.INSTANCE.Accounts.FirstOrDefault(a => a.UserName == txtUserName.Text);
				if(account != null)
				{
					var result = MessageBox.Show("Do you want delete this teacher?", "Confirmation", MessageBoxButton.YesNo);
					if(result == MessageBoxResult.Yes)
					{
						teacher.Account = account;
						ProjectPrn212Context.INSTANCE.Teachers.Remove(teacher);
						ProjectPrn212Context.INSTANCE.SaveChanges();
						load();
						MessageBox.Show("Delete Sucessfully");
					}
				}
				else
				{
					MessageBox.Show("Delete fail!! Because account is not exist");
				}
			}
			else
			{
				MessageBox.Show("Delete fail!! Because Teacher not exist");
			}
		}

		private void SaveJson_Click(object sender, RoutedEventArgs e)
		{
			var dialog = new Microsoft.Win32.SaveFileDialog();
			dialog.FileName = "Teachers";
			dialog.DefaultExt = ".json";
			dialog.Filter = "JSON documents (.json)|*.json";

			bool? result = dialog.ShowDialog();

			if (result == true)
			{
				string filename = dialog.FileName;
				var teacher = ProjectPrn212Context.INSTANCE.Teachers.Select(t => new
				{
					TeacherID = t.Id,
					TeacherName = t.TeacherName,
					Gender = t.Gender,
					Email = t.Email,
					BirthDate = t.BrithDate,
					account = new
					{
						username = t.Account.UserName,
						password = t.Account.Password,
						Role = t.Account.Role,
					}
				}).ToList();
				lvTeachers.ItemsSource = teacher;

				var option = new JsonSerializerOptions()
				{
					WriteIndented = true,
					//ReferenceHandler = ReferenceHandler.Preserve,
				};
				string jsonData = JsonSerializer.Serialize(teacher, option);

				File.WriteAllText(filename, jsonData);
			}
		}

		private void SaveXML_Click(object sender, RoutedEventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				FileName = "Teachers",
				DefaultExt = ".xml",
				Filter = "XML Files|*.xml"
			};

			var result = saveFileDialog.ShowDialog();

			if (result == true)
			{
				string filename = saveFileDialog.FileName;
				var teachers = ProjectPrn212Context.INSTANCE.Teachers.ToList();

				var xmlSerializer = new XmlSerializer(typeof(List<Models.Teacher>));

				using FileStream stream = File.Create(filename);
				xmlSerializer.Serialize(stream, teachers);
				stream.Close();
				MessageBox.Show("Teachers saved to XML successfully!");
			}
		}
	}

}
