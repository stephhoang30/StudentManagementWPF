   M S B A M L   `   `   `  ���� W  SProject_ManageStudent_PRN212, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Project_ManageStudent_PRN212.Admin"Project_ManageStudent_PRN212.Admin  4    .Project_ManageStudent_PRN212.Admin.MangeCourse   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Blocal0clr-namespace:Project_ManageStudent_PRN212.Admin     -     � Title$  Manage Course��$	��450��$	��800�� � 	Resources  �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius ��Name��%E  '��       '�� *    '�� �    '��     '�� �    �� " ��.���  � ��$ 5q���  � ��$ 5q���  � ��$ 14(���  � �� �#0078D7��  � ��$ 2q���  � ��$	 200����  � ��$ 30����  � ��
 �������  � �� �� " ��.R��� #��z��#��z��#��z��$ 5��._��� $ PART_ContentHost��$��0q��� " ��.���  � ��$ 10q���  � ��$
 10,5q���  � �� �#0078D7��  � ��
 �������  � ��$ 16(���  � ��$
 Bold"���  � ��$ 0q���  � ��$ 30����  � ��$	 100����  � ��$ Center=���  � ��$ Center=���  �@�Cursor$
 Hand����  � �� �� " ��.R��� #��z��$ 5��
�������$��1q�._��� $��Center=�$��Center=��� " ��.���  � ��$ 5q���  � ��$ 14(���  � ��$
 Bold"��� " ��.���  � ��$ 10q���  � ��$ 10q���  � ��$ 14(���  � ��
 �������  � ��$ 1q��� " ��.���  � ��$ 16(���  � ��$
 Bold"���  � �� �#0078D7��  � ��
 �������  � ��$ 5q�.��]� .+��� ���#0078D7$	��Top=�$��50��._�]� .+��� -   $
��Back��$
��Left=�$��Center=��� $��Manage Subject��
�������$��20(�$
��Bold"�$��Center=�$��Center=��  � ColumnDefinitions �� $��35 ��� $��30 ��� $��15 ��� $��35 ��� $	��170 ��� $��15 ��� $	��29* ��� $	��63* ��� $��8* �.+��� -   	 ��Name$	 	lvCourses��$��0��$��6��$��10,10,10,10q�
 �� View
 �� .P��� $��	Course ID�� �� Width$ 90�� �� DisplayMemberBinding �� *
courseID+�� $��Course Name��$	 170�� �� *
courseName+�� $��6��$��3��.+��  � RowDefinitions �� $��* ��� $
��Auto ��� $��* ��� $
��Auto �.+��� $��10 0 0 0q�$��0��.+��� $��	Course ID���� -   $��txtCourseId������  �� ElementName$ 	lvCourses�� �� Path$ SelectedItem.courseID� �� Mode$ OneWay=��� $��Course Name���� -   $��txtCourseNamee������ $ 	lvCourses��$ SelectedItem.courseName�$ OneWay=��� $��	10 10 0 0q�$��1�� �� Orientation$ 
Horizontal=�$��Center=�.+��� -   $��Insert���� -   $��Update���� -   $��Delete���� $��2��$ 
Horizontal=�$��10 0 0 0q�.+��� -	    ��Name$ 	txtSearch��$	��150��$��30��$
��Left=��� $��Search��$��20 0 0 0q�