   M S B A M L   `   `   `  ���� W  SProject_ManageStudent_PRN212, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Project_ManageStudent_PRN212.Admin"Project_ManageStudent_PRN212.Admin  =    7Project_ManageStudent_PRN212.Admin.ManageStudentInClass   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Blocal0clr-namespace:Project_ManageStudent_PRN212.Admin     -     � Title$  ManageStudent��$	��450��$
��1150�� � 	Resources  �� 
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
��Left=�$��Center=��� $��Manage Student In Class��
�������$��20(�$
��Bold"�$��Center=�$��Center=��  � ColumnDefinitions �� $	��630 ��� $��* �.+��� -   	 ��Name$	 LvStudentInClass��$��0��$��10,10,10,10q�
 �� View
 �� .P��� $��SC-ID�� �� Width$ 60�� �� DisplayMemberBinding �� *ID+�� $��Class ID��$ 80�� �� *Class.ClassID+�� $��
Class Name��$	 100�� �� *Class.ClassName+�� $��	Course ID��$ 90�� �� *Class.CourseID+�� $��
Student ID��$	 120�� �� *Student.StudentID+�� $��Student Name��$	 150�� �� *Student.StudentName+�� $��1��.+��  � RowDefinitions �� $��* ��� $
��Auto ��� $��* ��� $
��Auto �.+��� $��10 0 0 0q�$��0��.+��� $	��150��$
��Left=�$��30��$��Student In Class���� -    ��Name$ txtStudentClass��$��	73 0 0 10q�$	��150��$��30��$
��Left=�����  �� ElementName$ LvStudentInClass�� �� Path$ SelectedItem.ID� �� Mode$ OneWay=��� $��10 0 0 0q�$��1�� �� Orientation$ 
Horizontal=�.+��� $��Class ID���� -   $��
cbbClassId��$	��150��$��30��$
��Left=� �� DisplayMemberPath$ ClassNameCourseID�� �� SelectedValuePath$ ClassID�� �� SelectedValue �� $ LvStudentInClass��$  SelectedItem.Class.ClassID�$ OneWay=��� $��
Student ID���� -   $��cbbStudentId��$	��150��$��30��$ 	StudentID��$ 	StudentID�� �� $ LvStudentInClass��$$ SelectedItem.Student.StudentID�$ OneWay=��� $��	10 10 0 0q�$��2��$ 
Horizontal=�$��Center=�.+��� -   $��Insert���� -   $��Update���� -	   $��Delete���� $��3��$ 
Horizontal=�$��10 0 0 0q�.+��� -
   $ 	txtSearch��$	��150��$��30��$
��Left=��� $��Search��$��20 0 0 0q�