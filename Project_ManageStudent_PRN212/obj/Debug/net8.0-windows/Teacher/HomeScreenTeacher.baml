   M S B A M L   `   `   `  ����W  SProject_ManageStudent_PRN212, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:Project_ManageStudent_PRN212.Teacher$Project_ManageStudent_PRN212.Teacher  5   	   <    6Project_ManageStudent_PRN212.Teacher.HomeScreenTeacher   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:Project_ManageStudent_PRN212.Teacher     5   	   -   5          � Title$  HomeScreenTeacher��5   	   $	��450��6#   $
��1400��60    � 	Resources 5
       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius ��Name��%s  '��       '�� �    '�� [    '�� �    '�� `    �� 5   
   " ��6   .�5      ��  � ��$ 10q�6'   �� 5       � ��$
 10,5q�6(   �� 5       � �� �#0078D76+   �� 5       � ��
 �����6+   �� 5       � ��$ 16(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ 0q�60   �� 5       � ��$ 30��6'   �� 5       � ��$	 100��6&   �� 5       � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   $ 5��5   !   
�������$��1q�5   !   ._�5      �� $��Center=�6/   $��Center=�5    /   5!      5"      5$      5%      �� 5&   
   " ��6   .�5'      ��  � ��$ 5q�6'   �� 5(       � ��$ 14(�6)   �� 5)       � ��$
 Bold"�6+   5*      �� 5+   
   " ��6   .�5,      ��  � ��$ 5q�6'   �� 5-       � ��$ 5q�6(   �� 5.       � ��$ 14(�6)   �� 5/       � �� �#0078D76,   �� 50       � ��$ 2q�60   �� 51       � ��$	 200��6&   �� 52       � ��$ 30��6'   �� 53       � ��
 �����6+   �� 54       � �� 55      �� 56      " ��6&   .R�57      �� #��z��6!   #��z��58   !   #��z��59   !   $ 5��5:   !   ._�5;      �� $ PART_ContentHost��6+   $��0q�5<   +   5=      5>      5@      5A      �� 5B   
   " ��6   .�5C      ��  � ��$ 10q�6'   �� 5D       � ��$ 10q�6(   �� 5E       � ��$ 14(�6)   �� 5F       � ��
 �����6,   �� 5G       � ��$ 1q�60   5H      �� 5I   
   " ��6   .�5J      ��  � ��$ 16(�6)   �� 5K       � ��$
 Bold"�6+   �� 5L       � �� �#0078D76+   �� 5M       � ��
 �����6+   �� 5N       � ��$ 5q�6(   5O      5P      .��5R      ]� .+�5S   
   �� ���#0078D7$	��Top=�6&   $��50��6;   ._�5T      ]� .+�5U      �� -   5        $��Log out��5U      $
��Left=�6@   $��Center=�6[   �� 5V      $��Home Screen Teacher��6   
�������$��20(�6J   $
��Bold"�6X   $��Center=�6j   $��Center=�6�   5W      5X      � 5Z   
    � ColumnDefinitions 5[      �� 5\      $��* �6#   �� 5]      $��* �6#   .+�5_      �� -   5        $��lvTeacherClass��5_      	 �� View	 5`      �� 5a      .P�5b      �� $��Class ID��6)   
 �� Width$
 80��6;    �� DisplayMemberBinding 6F   �� *	ClassID+�� 5c      $��
Class Name��6)   $	
 100��6=    6I   �� *	ClassName+�� 5d      $��	Course ID��6)   $	
 100��6<    6H   �� *Course.CourseID+�� 5e      $��Course Name��6)   $	
 150��6>    6J   �� *Course.CourseName+�� 5f      $��Room ID��6)   $
 80��6:    6E   �� *Room.RoomID+�� 5g      $��	Room Name��6)   $	
 140��6<    6H   �� *Room.RoomName+5h      5j      �� 5k      $��1��6   .+�5l      �  � RowDefinitions 5m      �� 5n      $��* �6(   �� 5o      $��* �6(   �� 5p      $��* �6(   .+�5r      �� $��0��6!    �� Orientation$ 
Horizontal=�6.   $��10 0 0 0q�6G   .+�5s      �� $��Class ID��6    $	��150��63   $��30��6?   $
��Left=�6K   �� 5t      $��Search Class��6    $	��150��67   $��30��6C   $
��Left=�6O   $��	100 0 0 0q�6j   5u      �� 5v      $��1��6!   $ 
Horizontal=�6.   $��10 0 0 0q�6G   .+�5w      �� -   5        $��
cbbClassId��5w   #   $	��150��65   $��30��6A   $
��Left=�6M    �� DisplayMemberPath$ 	ClassName��5x   #    �� SelectedValuePath$ ClassID��6A    �� SelectedValue 5y   #   ��  �� ElementName$ lvTeacherClass�� �� Path$ SelectedItem.ClassID� �� Mode$ OneWay=�6�   �� 5z      -   5        $��	txtSearch��5z   M   $��	100 0 0 0q�6"   $	��150��65   $��30��6A   6^   5{      �� 5|      $��2��6!   $��0 30 0 0q�6.   .+�5}      �� -   5         ��Name$ 	lvStudent��5}   #   	 5~      �� 5   "   .P�5�   &   �� $��
Student ID��65   $	
 100��6I    6U   �� *Student.StudentID+�� 5�   &   $��Student Name��65   $	
 170��6K    6W   �� *Student.StudentName+�� 5�   &   $��Gender��65   $
 80��6E    6P   �� *Student.Gender+�� 5�   &   $��Email��65   $	
 200��6D    6P   �� *Student.Email+�� 5�   &   $��
Birth Date��65   $	
 100��6I    6U   �� *Student.BirhthDate+5�   #   5�      5�      5�      5�      5�      5�      5�      