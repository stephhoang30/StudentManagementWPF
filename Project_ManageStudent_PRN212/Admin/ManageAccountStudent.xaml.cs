using Microsoft.Win32;
using Project_ManageStudent_PRN212.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_ManageStudent_PRN212.Admin
{
	/// <summary>
	/// Interaction logic for ManageAccountStudent.xaml
	/// </summary>
	public partial class ManageAccountStudent : Window
	{
		public ManageAccountStudent()
		{
			InitializeComponent();
		}

		private void Window_Load(object sender, RoutedEventArgs e)
		{
			load();
		}

		private void load()
		{
			
			var students = ProjectPrn212Context.INSTANCE.Students.Select(s => new
			{
				StudentID = s.Id,
				StudentName = s.StudentName,
				Gender = s.Gender,
				Email = s.Email,
				BirthDate = s.BirthDate,
				account = new
				{
					username = s.Account.UserName,
					password = s.Account.Password,
					Role = s.Account.Role
				}
			}).ToList();
			lvStudents.ItemsSource = students;
		}

		private void btnInsertClick(object sender, RoutedEventArgs e)
		{
			bool gender = rbMale.IsChecked == true;
			if (rbMale.IsChecked == true)
			{
				gender = true;
			}
			Project_ManageStudent_PRN212.Models.Student existingStudent = ProjectPrn212Context.INSTANCE.Students.FirstOrDefault(s => s.Id == txtStudentID.Text);
			if (existingStudent != null)
			{
				MessageBox.Show("Student is already existing");
			}
			else
			{
				Project_ManageStudent_PRN212.Models.Student newStudent = new Project_ManageStudent_PRN212.Models.Student
				{
					Id = txtStudentID.Text,
					StudentName = txtStudentName.Text,
					Gender = gender,
					Email = txtEmail.Text,
					BirthDate = DateOnly.Parse(txtBirthDate.Text),
				};
				Project_ManageStudent_PRN212.Models.Account account = ProjectPrn212Context.INSTANCE.Accounts.FirstOrDefault(a => a.UserName == txtUserName.Text);
				if (account != null)
				{
					MessageBox.Show("Username already exists. Please choose a different username.");
					return;
				}
				Project_ManageStudent_PRN212.Models.Account newAccount = new Project_ManageStudent_PRN212.Models.Account
				{
					UserName = txtUserName.Text,
					Password = txtPassword.Text,
					Role = 2
				};

				newStudent.Account = newAccount;
				ProjectPrn212Context.INSTANCE.Students.Add(newStudent);
				ProjectPrn212Context.INSTANCE.Accounts.Add(newAccount);
				ProjectPrn212Context.INSTANCE.SaveChanges();
				load();

				MessageBox.Show("Student and Account added successfully");
			}
		}



		private void btnUpdateClick(object sender, RoutedEventArgs e)
		{
			bool gender = rbMale.IsChecked == true;
			Project_ManageStudent_PRN212.Models.Student student = ProjectPrn212Context.INSTANCE.Students.FirstOrDefault(s => s.Id == txtStudentID.Text);
			if (student != null)
			{

				if (student.Account != null && student.Account.UserName != txtUserName.Text)
				{
					MessageBox.Show("The username entered does not match the current account of the student.");
					return;
				}

				student.StudentName = txtStudentName.Text;
				student.Email = txtEmail.Text;
				student.Gender = gender;
				student.BirthDate = DateOnly.Parse(txtBirthDate.Text);

				Account account = ProjectPrn212Context.INSTANCE.Accounts.FirstOrDefault(a => a.UserName == txtUserName.Text);
				if (account != null)
				{
					if (student.Account != account)
					{
						MessageBox.Show("The username entered does not match the current account of the student. Please enter the correct username.");
						return;
					}
					account.Password = txtPassword.Text;
					student.Account = account;

					ProjectPrn212Context.INSTANCE.SaveChanges();
					load();
					MessageBox.Show("Update information of student successfully");
				}
				else
				{
					MessageBox.Show("Account is not existing");
				}
			}
			else
			{
				MessageBox.Show("Student ID is not existing");
			}
		}


		private void btnDeleteClick(object sender, RoutedEventArgs e)
		{
			Project_ManageStudent_PRN212.Models.Student student = ProjectPrn212Context.INSTANCE.Students.FirstOrDefault(s => s.Id == txtStudentID.Text);
			if (student != null)
			{
				Account a = ProjectPrn212Context.INSTANCE.Accounts.FirstOrDefault(a => a.UserName == txtUserName.Text);
				if (a != null)
				{
					var result = MessageBox.Show("Do you want delete this student?", "Confirmation", MessageBoxButton.YesNo);
					if(result == MessageBoxResult.Yes)
					{
						student.Account = a;
						ProjectPrn212Context.INSTANCE.Students.Remove(student);
						ProjectPrn212Context.INSTANCE.SaveChanges();
						load();
						MessageBox.Show("Delete informationm of student successfully");
					}
				}
				else
				{
					MessageBox.Show("Delete fail!! Account is not exist");
				}
			}
			else
			{
				MessageBox.Show("Delete fail!! Student is not exist");
			}

		}


		private void btnBackClick(object sender, RoutedEventArgs e)
		{
			var back = new HomeScreenAdmin();
			back.Show();
			this.Close();
		}

		private void txtSearchInfoStudent(object sender, TextChangedEventArgs e)
		{
			var students = ProjectPrn212Context.INSTANCE.Students.Where(s => s.Id.Contains(txtSearch.Text) || s.StudentName.Contains(txtSearch.Text))
																.Select(s => new
																{
																	StudentID = s.Id,
																	StudentName = s.StudentName,
																	Gender = s.Gender,
																	Email = s.Email,
																	BirthDate = s.BirthDate,
																	account = new
																	{
																		username = s.Account.UserName,
																		password = s.Account.Password,
																		Role = 2
																	}
																}).ToList();
			lvStudents.ItemsSource = students;
		}

		private void btnImportStudent(object sender, RoutedEventArgs e)
		{
			string fileName = "FileJson/Students.json";
			string data = File.ReadAllText(fileName);
			List<Models.Student> students;
			using (FileStream fs = new FileStream(fileName, FileMode.Open))
			{
				students = JsonSerializer.Deserialize<List<Models.Student>>(data);
			}
			foreach (var item in students)
			{
				if(item != null)
				{
					var checkStExist = ProjectPrn212Context.INSTANCE.Students.FirstOrDefault(s => s.Id == item.Id);
					if(checkStExist == null)
					{
						ProjectPrn212Context.INSTANCE.Students.Add(item);
						ProjectPrn212Context.INSTANCE.SaveChanges();
						load();
						MessageBox.Show("Add student successfully");
					}
					else
					{
						MessageBox.Show("Student is existed");
					}
					
				}
			}
		}

		private void btnSaveJson_Click(object sender, RoutedEventArgs e)
		{
			var dialog = new Microsoft.Win32.SaveFileDialog();
			dialog.FileName = "Students";
			dialog.DefaultExt = ".json";
			dialog.Filter = "JSON documents (.json)|*.json";

			bool? result = dialog.ShowDialog();

			if (result == true)
			{
				string filename = dialog.FileName;
				var students = ProjectPrn212Context.INSTANCE.Students.Select(s => new
				{
					StudentID = s.Id,
					StudentName = s.StudentName,
					Gender = s.Gender,
					Email = s.Email,
					BirthDate = s.BirthDate,
					account = new
					{
						username = s.Account.UserName,
						password = s.Account.Password,
						Role = s.Account.Role
					}
				}).ToList();
				lvStudents.ItemsSource = students;

				var option = new JsonSerializerOptions()
				{
					WriteIndented = true,
					//ReferenceHandler = ReferenceHandler.Preserve,
				};
				string jsonData = JsonSerializer.Serialize(students, option);

				File.WriteAllText(filename, jsonData);
			}
		}

		private void btnSaveXml_Click(object sender, RoutedEventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				FileName = "Students",
				DefaultExt = ".xml",
				Filter = "XML Files|*.xml"
			};

			var result = saveFileDialog.ShowDialog();

			if (result == true)
			{
				string filename = saveFileDialog.FileName;
				var students = ProjectPrn212Context.INSTANCE.Students.ToList();

				var xmlSerializer = new XmlSerializer(typeof(List<Models.Student>));

				using FileStream stream = File.Create(filename);
				xmlSerializer.Serialize(stream, students);
				stream.Close();
				MessageBox.Show("Students saved to XML successfully!");
			}
		}

		private void btnImportXML_Click(object sender, RoutedEventArgs e)
		{
			string fileName = "FileXML/Students.xml";
			List<Models.Student> students;
			using(FileStream fs = new FileStream(fileName, FileMode.Open))
			{
				XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Models.Student>), new XmlRootAttribute("Students"));
				students = (List<Models.Student>)xmlSerializer.Deserialize(fs);
			}
			foreach(var item in students)
			{
				var checkExit = ProjectPrn212Context.INSTANCE.Students.FirstOrDefault(s => s.Id == item.Id);
				if(checkExit == null)
				{
					ProjectPrn212Context.INSTANCE.Students.Add(item);
					ProjectPrn212Context.INSTANCE.SaveChanges();
					load();
					MessageBox.Show("Import student successfully");
				}
				else
				{
					MessageBox.Show("Student is existing");
				}
			}
		}
	}
}
