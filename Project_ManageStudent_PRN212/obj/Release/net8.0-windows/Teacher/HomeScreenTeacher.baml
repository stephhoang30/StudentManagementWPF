   M S B A M L   `   `   `  ���� W  SProject_ManageStudent_PRN212, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:Project_ManageStudent_PRN212.Teacher$Project_ManageStudent_PRN212.Teacher  <    6Project_ManageStudent_PRN212.Teacher.HomeScreenTeacher   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Dlocal2clr-namespace:Project_ManageStudent_PRN212.Teacher     -     � Title$  HomeScreenTeacher��$	��450��$
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
��Left=�$��Center=��� $��Home Screen Teacher��
�������$��20(�$
��Bold"�$��Center=�$��Center=��  � ColumnDefinitions �� $��* ��� $��* �.+��� -   $��lvTeacherClass��	 �� View	 �� .P��� $��Class ID��
 �� Width$
 80�� �� DisplayMemberBinding �� *	ClassID+�� $��
Class Name��$	
 100�� �� *	ClassName+�� $��	Course ID��$	
 100�� �� *Course.CourseID+�� $��Course Name��$	
 150�� �� *Course.CourseName+�� $��Room ID��$
 80�� �� *Room.RoomID+�� $��	Room Name��$	
 140�� �� *Room.RoomName+�� $��1��.+��  � RowDefinitions �� $��* ��� $��* ��� $��* �.+��� $��0�� �� Orientation$ 
Horizontal=�$��10 0 0 0q�.+��� $��Class ID��$	��150��$��30��$
��Left=��� $��Search Class��$	��150��$��30��$
��Left=�$��	100 0 0 0q��� $��1��$ 
Horizontal=�$��10 0 0 0q�.+��� -   $��
cbbClassId��$	��150��$��30��$
��Left=� �� DisplayMemberPath$ 	ClassName�� �� SelectedValuePath$ ClassID�� �� SelectedValue ��  �� ElementName$ lvTeacherClass�� �� Path$ SelectedItem.ClassID� �� Mode$ OneWay=��� -   $��	txtSearch��$��	100 0 0 0q�$	��150��$��30���� $��2��$��0 30 0 0q�.+��� -    ��Name$ 	lvStudent��	 �� .P��� $��
Student ID��$	
 100�� �� *Student.StudentID+�� $��Student Name��$	
 170�� �� *Student.StudentName+�� $��Gender��$
 80�� �� *Student.Gender+�� $��Email��$	
 200�� �� *Student.Email+�� $��
Birth Date��$	
 100�� �� *Student.BirhthDate+