   M S B A M L   `   `   `  ����W  SProject_ManageStudent_PRN212, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Project_ManageStudent_PRN212.Admin"Project_ManageStudent_PRN212.Admin  5   	   =    7Project_ManageStudent_PRN212.Admin.ManageStudentInClass   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:Project_ManageStudent_PRN212.Admin     5   	   -   5          � Title$  ManageStudent��5   	   $	��450��6   $
��1150��6,    � 	Resources 5
       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius ��Name��%s  '��       '�� �    '�� [    '�� �    '�� `    �� 5   
   " ��6   .�5      ��  � ��$ 10q�6'   �� 5       � ��$
 10,5q�6(   �� 5       � �� �#0078D76+   �� 5       � ��
 �����6+   �� 5       � ��$ 16(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ 0q�60   �� 5       � ��$ 30��6'   �� 5       � ��$	 100��6&   �� 5       � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   $ 5��5      
�������$��1q�5      ._�5      �� $��Center=�6/   $��Center=�5    +   5!      5"      5$      5%      �� 5&   
   " ��6   .�5'      ��  � ��$ 5q�6'   �� 5(       � ��$ 14(�6)   �� 5)       � ��$
 Bold"�6+   5*      �� 5+   
   " ��6   .�5,      ��  � ��$ 5q�6'   �� 5-       � ��$ 5q�6(   �� 5.       � ��$ 14(�6)   �� 5/       � �� �#0078D76,   �� 50       � ��$ 2q�60   �� 51       � ��$	 200��6&   �� 52       � ��$ 30��6'   �� 53       � ��
 �����6+   �� 54       � �� 55      �� 56      " ��6&   .R�57      �� #��z��6!   #��z��58      #��z��59      $ 5��5:      ._�5;      �� $ PART_ContentHost��6+   $��0q�5<   $   5=      5>      5@      5A      �� 5B   
   " ��6   .�5C      ��  � ��$ 10q�6'   �� 5D       � ��$ 10q�6(   �� 5E       � ��$ 14(�6)   �� 5F       � ��
 �����6,   �� 5G       � ��$ 1q�60   5H      �� 5I   
   " ��6   .�5J      ��  � ��$ 16(�6)   �� 5K       � ��$
 Bold"�6+   �� 5L       � �� �#0078D76+   �� 5M       � ��
 �����6+   �� 5N       � ��$ 5q�6(   5O      5P      .��5R      ]� .+�5S   
   �� ���#0078D7$	��Top=�6&   $��50��6;   ._�5T      ]� .+�5U      �� -   5        $
��Back��5U      $
��Left=�6=   $��Center=�6Y   �� 5V      $��Manage Student In Class��6   
�������$��20(�6N   $
��Bold"�6\   $��Center=�6n   $��Center=�6�   5W      5X      � 5[   
    � ColumnDefinitions 5\      �� 5]      $	��630 �6#   �� 5^      $��* �6#   .+�5a      �� -   5        	 ��Name$	 LvStudentInClass��5a      $��0��61   $��10,10,10,10q�6>   
 �� View
 5b      �� 5c      .P�5d      �� $��SC-ID��6)    �� Width$ 60��68    �� DisplayMemberBinding 6C   �� *ID+�� 5e      $��Class ID��6)   $ 80��6;    6F   �� *Class.ClassID+�� 5f      $��
Class Name��6)   $	 100��6>    6J   �� *Class.ClassName+�� 5g      $��	Course ID��6)   $ 90��6=    6H   �� *
CourseID+�� 5h      $��
Student ID��6)   $	 120��6>    6J   �� *Student.StudentID+�� 5i      $��Student Name��6)   $	 150��6@    6L   �� *Student.StudentName+5j      5l      �� 5m      $��1��6   .+�5n      �  � RowDefinitions 5o      �� 5p      $��* �6(   �� 5q      $
��Auto �6(   �� 5r      $��* �6(   �� 5s      $
��Auto �6(   .+�5u      �� $��10 0 0 0q�6!   $��0��63    �� Orientation$ 
Horizontal=�6@   .+�5v      �� $	��100��6    $
��Left=�6,   $��30��6G   $��Search Class��6S   �� 5w      -   5         ��Name$ txtStudentClass��5w   5   $��	10 0 0 10q�6"   $	��150��6N   $��30��6Z   $
��Left=�6f   ��5x   "   ��  �� ElementName$ LvStudentInClass�� �� Path$ SelectedItem.ID� �� Mode$ OneWay=��� 5y      $��	Course ID��6    �� 5z      -   5        $��cbbCourseId��5z   #   $	��150��66   $��30��6B   $
��Left=�6N    �� DisplayMemberPath$ CourseID��5{       �� SelectedValuePath$ CourseID��66    �� SelectedValue 5|      �� $ LvStudentInClass��$ SelectedItem.CourseID�$ OneWay=�5}      �� 5~      $��10 0 0 0q�6!   $��1��63   $ 
Horizontal=�6@   .+�5      �� $��Class ID��6    �� 5�      -   5        $��
cbbClassId��5�   #   $	��150��65   $��30��6A   $
��Left=�6M   $ ClassNameCourseID��5�      $ ClassID��6?    5�      �� $ LvStudentInClass��$  SelectedItem.Class.ClassID�$ OneWay=��� 5�      $��
Student ID��6    �� 5�      -   5        $��cbbStudentId��5�   #   $	��150��67   $��30��6C   $ 	StudentID��5�   #   $ 	StudentID��6A    5�   #   �� $ LvStudentInClass��$$ SelectedItem.Student.StudentID�$ OneWay=�5�      �� 5�      $��	10 10 0 0q�6!   $��2��64   $ 
Horizontal=�6A   $��Center=�6Z   .+�5�      �� -   5        $��Insert��5�   !   62   �� 5�      -	   5        $��Update��5�   !   62   �� 5�      -
   5        $��Delete��5�   !   62   5�      �� 5�      $��3��6!   $ 
Horizontal=�6.   $��10 0 0 0q�6G   .+�5�      �� -   5        $ 	txtSearch��5�   "   $	��150��65   $��30��6A   $
��Left=�6h   �� 5�      $��Search��6    $��20 0 0 0q�61   5�      5�      5�      5�      5�      5�      