   M S B A M L   `   `   `  ���� W  SProject_ManageStudent_PRN212, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Project_ManageStudent_PRN212.Admin"Project_ManageStudent_PRN212.Admin  =    7Project_ManageStudent_PRN212.Admin.ManageAccountStudent   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Blocal0clr-namespace:Project_ManageStudent_PRN212.Admin     -     � Title$  ManageAccountStudent��$	��700��$
��1700�� � 	Resources 6  0Project_ManageStudent_PRN212.Admin.ConvertGender   ConverGender6  0Project_ManageStudent_PRN212.Admin.ReserveGender  ReserveGender �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius ��Name��%c  &	        &	      '�� 
     '�� �    '�� �    '��     '�� �        �� " ��.���  � ��$ 10q���  � ��$
 10,5q���  � �� �#0078D7��  � ��
 �������  � ��$ 16(���  � ��$
 Bold"���  � ��$ 0q���  � ��$ 30����  � ��$	 100����  � ��$ Center=���  � ��$ Center=���  �@�Cursor$
 Hand����  � �� �� " ��.R��� #��z��$ 5��
�������$��1q�._��� $��Center=�$��Center=��� " ��.���  � ��$ 5q���  � ��$ 14(���  � ��$
 Bold"��� " ��.���  � ��$ 5q���  � ��$ 5q���  � ��$ 14(���  � �� �#0078D7��  � ��$ 2q���  � ��$	 200����  � ��$ 30����  � ��
 �������  � �� �� " ��.R��� #��z��#��z��#��z��$ 5��._��� $ PART_ContentHost��$��0q��� " ��.���  � ��$ 10q���  � ��$ 10q���  � ��$ 14(���  � ��
 �������  � ��$ 1q��� " ��.���  � ��$ 16(���  � ��$
 Bold"���  � �� �#0078D7��  � ��
 �������  � ��$ 5q�.��]� .+��� ���#0078D7$	��Top=�$��50��._�]� .+��� -   $
��Back��$
��Left=�$��Center=��� $��Manage Student��
�������$��20(�$
��Bold"�$��Center=�$��Center=��  � ColumnDefinitions �� $	��900 ��� $��* �.+��� -   	 ��Name$	 
lvStudents��$��0��
 �� View
 �� .P��� $��
Student ID�� �� Width$	 100�� �� DisplayMemberBinding ��  �� Path$ 	StudentID��� $��Student Name��$	 150�� �� $ StudentName��� $��Gender��$ 70�� �� $ Gender� �� 	Converter# [  �� $��Email��$	 180�� �� $ Email��� $��	BrithDate��$	 100�� �� $ 	BirthDate��� $��	User Name��$	 100�� �� $ account.username��� $��Password��$	 100�� �� $ account.password��� $
��Role��$ 50�� �� $ account.Role��� $��1��.+��  � RowDefinitions �� $��* ��� $
��Auto ��� $��* ��� $
��Auto � �� $��* ��� $��* �.+��� $��10 0 0 0q�$��1��$��0��.+��� $��
Student ID���� -   $��txtStudentID������  �� ElementName$ 
lvStudents��$ SelectedItem.StudentID� �� Mode$ OneWay=��� $��Student Name���� -   $��txtStudentName������ $ 
lvStudents��$ SelectedItem.StudentName�$ OneWay=��� $��15 20q�$��30�� �� Orientation$ 
Horizontal=�.+�	� -   $��rbMale�� 	� 	GroupName$ gender��$
��Male�� d� 	IsChecked �� $ Gender�$ OneWay=� � DataContext �� $ 
lvStudents��$ SelectedItem�	� -   $��rbFemale��$ gender��$��Female��$��10 0 0 0q� �� $ Gender�$ OneWay=�# [  �� $ 
lvStudents��$ SelectedItem��� $��Email���� -   $��txtEmail������ $ 
lvStudents��$ SelectedItem.Email�$ OneWay=��� $��10 0 0 0q�$��1��$��1��.+��� $��	BirthDate��(  "System.Windows.Controls.DatePicker  -	   $��txtBirthDate��$	��200��$��30��   Text �� $ 
lvStudents��$ SelectedItem.BirthDate�$ OneWay=��� $��	User Name���� -
   $��txtUserName������ $ 
lvStudents��$# SelectedItem.account.username�$ OneWay=��� $��Password���� -   $��txtPassword������ $ 
lvStudents��$# SelectedItem.account.password�$ OneWay=��� $��	10 10 0 0q�$��2��$��2��$ 
Horizontal=�$��Center=�.+��� -   $	��Add���� -   $
��Edit���� -   $��Delete���� $��	10 10 0 0q�$��3��$��2��$ 
Horizontal=�$��Center=�.+��� -   $��Import Student XML��$	��160���� -   $��Save Student XML��$	��160���� -   $��Import Student Json��$	��160���� -   $��Save Student Json��$	��160���� $��0��$��2��$ 
Horizontal=�$��	100 0 0 0q�.+��� -    ��Name$ 	txtSearch��$	��200��$��30��$
��Left=��� $��Search��$��20 0 0 0q�