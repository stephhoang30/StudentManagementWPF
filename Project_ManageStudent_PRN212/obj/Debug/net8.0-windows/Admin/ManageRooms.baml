   M S B A M L   `   `   `  ����W  SProject_ManageStudent_PRN212, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Project_ManageStudent_PRN212.Admin"Project_ManageStudent_PRN212.Admin  5   	   4    .Project_ManageStudent_PRN212.Admin.ManageRooms   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:Project_ManageStudent_PRN212.Admin     5   	   -   5          � Title$  ManageRooms��5   	   $	��450��6   $
��1000��6*    � 	Resources 5
       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius ��Name��%�  '��       '�� �    '�� �    '�� �    '�� �    '�� �    �� 5   
   " ��6   .�5      ��  � ��$ 10q�6'   �� 5       � ��$
 10,5q�6(   �� 5       � �� �#0078D76+   �� 5       � ��
 �����6+   �� 5       � ��$ 16(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ 0q�60   �� 5       � ��$ 30��6'   �� 5       � ��$	 100��6&   �� 5       � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   $ 5��5   !   
�������$��1q�5   !   ._�5       �� $��Center=�6/   $��Center=�5!   /   5"      5#      5%      5&      �� 5'   
   " ��6   .�5(      ��  � ��$ 5q�6'   �� 5)       � ��$ 14(�6)   �� 5*       � ��$
 Bold"�6+   �� 5+       � ��$
 Left=�64   5,      �� 5-   
   " ��6   .�5.      ��  � ��$ 5q�6'   �� 5/       � ��$ 5q�6(   �� 50       � ��$ 14(�6)   �� 51       � �� �#0078D76,   �� 52       � ��$ 2q�60   �� 53       � ��$	 200��6&   �� 54       � ��$ 30��6'   �� 55       � ��
 �����6+   �� 56       � �� 57      �� 58      " ��6&   .R�59      �� #��z��6!   #��z��5:      #��z��5;      $ 5��5<      ._�5=      �� $ PART_ContentHost��6+   $��0q�5>   $   5?      5@      5B      5C      �� 5D   
   " ��6   .�5E      ��  � ��$ 5q�6'   �� 5F       � ��$ 5q�6(   �� 5G       � ��$ 14(�6)   �� 5H       � ��
 �����6,   �� 5I       � ��$ 1q�60   �� 5J       � ��$	 200��6&   �� 5K       � ��$ 30��6'   �� 5L       � ��$
 Left=�64   5M      �� 5N   
   " ��6   .�5O      ��  � ��$ 10q�6'   �� 5P       � ��$ 10q�6(   �� 5Q       � ��$ 14(�6)   �� 5R       � ��
 �����6,   �� 5S       � ��$ 1q�60   5T      �� 5U   
   " ��6   .�5V      ��  � ��$ 16(�6)   �� 5W       � ��$
 Bold"�6+   �� 5X       � �� �#0078D76+   �� 5Y       � ��
 �����6+   �� 5Z       � ��$ 5q�6(   5[      5\      .��5]      ]� .+�5^   
   �� ���#0078D7$	��Top=�6&   $��50��6;   ._�5_      ]� .+�5`      �� -   5        $
��Back��5`      $
��Left=�6=   $��Center=�6Y   �� 5a      $��Manage Room��6   
�������$��20(�6B   $
��Bold"�6P   $��Center=�6b   $��Center=�6}   5b      5c      � 5d   
    � ColumnDefinitions 5e      �� 5f      $	��650 �6#   �� 5g      $��* �6#   .+�5i      �� -   5        	 ��Name$	 lvRooms��5i      $��0��6(   
 �� View
 5j      �� 5k      .P�5l      �� $��Department Id��6)    �� Width$	 150��6@    �� DisplayMemberBinding 6L   �� *Department.DepartmentId+�� 5m      $��Department Name��6)   $	 150��6B    6N   �� *Department.DepartmentName+�� 5n      $��Room Id��6)   $	 130��6:    6F   �� *RoomId+�� 5o      $��	Room Name��6)   $	 170��6<    6H   �� *
RoomName+5p      5r      �� 5s      $��1��6   .+�5t      �  � RowDefinitions 5u      �� 5v      $��* �6(   �� 5w      $��* �6(   �� 5x      $��* �6(   .+�5z      �� $��10 0 0 0q�6!   $��0��63   .+�5{      �� $	��150��6    $��30��6,   $��Department Name��68   �� 5|      -   5        $��cbbdepartment��5|   #   $	��150��68   $��30��6D   $
��Left=�6P    �� DisplayMemberPath$ DepartmentName��5}       �� SelectedValuePath$ DepartmentId��6B    �� SelectedValue 5~      ��  �� ElementName$ lvRooms�� �� Path$* $SelectedItem.Department.DepartmentId� �� Mode$ OneWay=��� 5      $	��150��6    $��30��6,   $��Room ID��68   �� 5�      -   5        $��	txtRoomId��5�   "   $	��200��63   $��30��6?   $
��Left=�6K    �� 
IsReadOnly$
 True��5�   _   ��6   �� $ lvRooms��$ SelectedItem.RoomId�$ OneWay=�6_   �� 5�      $	��150��6    $��30��6,   $��	Room Name��68   �� 5�      -   5        $��txtRoomName��5�   "   $	��200��65   $��30��6A   $
��Left=�6M   ��5�      �� $ lvRooms��$ SelectedItem.RoomName�$ OneWay=�5�      �� 5�      $��	10 10 0 0q�6!   $��1��64    �� Orientation$ 
Horizontal=�6A   $��Center=�6Z   .+�5�      �� -   5        $��70��5�   !   $��30��6,   $��Insert��68   $��20q�6`   �� 5�      -   5        $��70��5�   !   $��30��6,   $��Update��68   $��20q�6`   �� 5�      -	   5        $��70��5�   !   $��30��6,   $��Delete��68   $��20q�6`   5�      �� 5�      $��2��6!   $ 
Horizontal=�6.   $��10 0 0 0q�6G   .+�5�      �� -
   5         ��Name$ 	txtSearch��5�   "   $	��150��65   $��30��6A   $
��Left=�6f   �� 5�      $	��100��6    $��30��6,   $��Search��68   $��20 0 0 0q�6I   5�      5�      5�      5�      5�      5�      