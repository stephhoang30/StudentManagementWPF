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
	/// Interaction logic for ManageRooms.xaml
	/// </summary>
	public partial class ManageRooms : Window
	{
		public ManageRooms()
		{
			InitializeComponent();
		}

		private void btnBackClick(object sender, RoutedEventArgs e)
		{
			var back = new HomeScreenAdmin();
			back.Show();
			this.Close();
		}

		private void btnInsertClick(object sender, RoutedEventArgs e)
		{
			if (cbbdepartment.SelectedValue == null)
			{
				MessageBox.Show("Please choose a department", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
				return;
			}
			Room room = new Room
				{
					DepartmentId = cbbdepartment.SelectedValue.ToString(),
					RoomName = txtRoomName.Text
				};
				ProjectPrn212Context.INSTANCE.Rooms.Add(room);
				ProjectPrn212Context.INSTANCE.SaveChanges();
				loaded();
				MessageBox.Show("Add room successfully");
		}

		private void btnUpdateClick(object sender, RoutedEventArgs e)
		{
			Room r = ProjectPrn212Context.INSTANCE.Rooms.FirstOrDefault(x => x.RoomId == int.Parse(txtRoomId.Text));
			if (r != null)
			{
				r.DepartmentId = cbbdepartment.SelectedValue.ToString();
				r.RoomName = txtRoomName.Text;
				ProjectPrn212Context.INSTANCE.SaveChanges();
				loaded();
				MessageBox.Show("Update room successfully");
			}
			else
			{
				MessageBox.Show("Room isn't exist");
			}
		}

		private void btnDeleteClick(object sender, RoutedEventArgs e)
		{
			Room r = ProjectPrn212Context.INSTANCE.Rooms.FirstOrDefault(x => x.RoomId == int.Parse(txtRoomId.Text));
			if (r != null)
			{
				var result = MessageBox.Show("Do you want delete this room?", "Confirmation", MessageBoxButton.YesNo);
				if(result == MessageBoxResult.Yes)
				{
					ProjectPrn212Context.INSTANCE.Rooms.Remove(r);
					ProjectPrn212Context.INSTANCE.SaveChanges();
					loaded();
					MessageBox.Show("Delete room successfully ");
				}
			}
			else
			{
				MessageBox.Show("account is not exist. Delete fail");
			}
		}

		private void SearchRoom(object sender, TextChangedEventArgs e)
		{
			var rooms = ProjectPrn212Context.INSTANCE.Rooms.Where(r => r.RoomName.Contains(txtSearch.Text) || r.Department.DepartmentName.Contains(txtSearch.Text))
															.Select(r => new
															{
																Department = new
																{
																	DepartmentId = r.Department.DepartmenId,
																	DepartmentName = r.Department.DepartmentName
																},
																RoomId = r.RoomId,
																RoomName = r.RoomName
															}).ToList();
			lvRooms.ItemsSource = rooms;
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			loaded();
		}

		private void loaded()
		{
			var rooms = ProjectPrn212Context.INSTANCE.Rooms.Select(a => new
			{
				Department = new
				{
					DepartmentId = a.Department.DepartmenId,
					DepartmentName = a.Department.DepartmentName
				},
				RoomId = a.RoomId,
				RoomName = a.RoomName
			}).ToList();
			lvRooms.ItemsSource = rooms;

			var department = ProjectPrn212Context.INSTANCE.Departments.Select(x => new
			{
				DepartmentId = x.DepartmenId,
				DepartmentName = x.DepartmentName
			});
			cbbdepartment.ItemsSource = department.ToList();
		}
	}
}
