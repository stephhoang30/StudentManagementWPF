   M S B A M L   `   `   `  ���� W  SProject_ManageStudent_PRN212, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Project_ManageStudent_PRN212.Admin"Project_ManageStudent_PRN212.Admin  4    .Project_ManageStudent_PRN212.Admin.ManageClass   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Blocal0clr-namespace:Project_ManageStudent_PRN212.Admin     -     � Title$  Manage Class��$	��700��$
��1400�� � 	Resources  �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius ��Name��%E  '��       '�� �    '�� �    '��     '�� �    �� " ��.���  � ��$ 10q���  � ��$
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
��Left=�$��Center=��� $.��(Classroom management and class placement��
�������$��20(�$
��Bold"�$��Center=�$��Center=��  � ColumnDefinitions �� $	��900 ��� $��* �.+��� -   	 ��Name$	 lvClass��$��0��
 �� View
 �� .P��� $��Class ID�� �� Width$ 80�� �� DisplayMemberBinding �� *	ClassId+�� $��
Class Name��$	 100�� �� *	ClassName+�� $��	Course ID��$ 90�� �� *Course.CourseID+�� $��Course Name��$	 160�� �� *Course.CourseName+�� $��
Teacher ID��$ 90�� �� *Teacher.TeacherID+�� $��Teacher Name��$	 120�� �� *Teacher.TeacherName+�� $��Room ID��$ 80�� �� *Room.RoomID+�� $��	Room Name��$	 120�� �� *Room.RoomName+�� $��1��.+��  � RowDefinitions �� $��* ��� $
��Auto ��� $��* ��� $
��Auto � �� $��* ��� $��* �.+��� $��10 0 0 0q�$��1��$��0��.+��� $��
List Class���� -   $��cbbClass��$��0��$��0��$	��150��$��30��$
��Left=� �� DisplayMemberPath$ 	ClassName�� �� SelectedValuePath$ ClassId�� �� SelectedValue ��  �� ElementName$ lvClass�� �� Path$ SelectedItem.ClassId� �� Mode$ OneWay=��� $��Class ID���� -   $��
txtClassID��$	��150��$��30��$
��Left=����� $ lvClass��$ SelectedItem.ClassId�$ OneWay=��� $��
Class Name���� -   $��txtClassname��$	��150��$��30��$
��Left=����� $ lvClass��$ SelectedItem.ClassName�$ OneWay=��� $��10 0 0 0q�$��1��$��1��.+��� $��	Course ID���� -   $��	cbbCourse��$��0��$��0��$	��150��$��30��$
��Left=�$ CourseID��$ CourseID�� �� $ lvClass��$" SelectedItem.Course.CourseID�$ OneWay=��� $��Teacher Name���� -   $��cbbTeacherID��$��0��$��0��$	��150��$��30��$
��Left=�$ TeacherName��$ 	TeacherID�� �� $ lvClass��$$ SelectedItem.Teacher.TeacherID�$ OneWay=��� $��	Room Name���� -	   $��cbbRoom��$��0��$��0��$	��150��$��30��$
��Left=�$ 	RoomnName��$ RoomID�� �� $ lvClass��$ SelectedItem.Room.RoomID�$ OneWay=��� $��	10 10 0 0q�$��2��$��2�� �� Orientation$ 
Horizontal=�$��Center=�.+��� -
   $��Insert���� -   $��Update���� -   $��Delete���� $��0��$��2��$ 
Horizontal=�$��10 0 0 0q�.+��� -    ��Name$ 	txtSearch��$	��150��$��30��$
��Left=��� $��Search��$��20 0 0 0q�