   M S B A M L   `   `   `  ���� W  SProject_ManageStudent_PRN212, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Project_ManageStudent_PRN212.Admin"Project_ManageStudent_PRN212.Admin  4    .Project_ManageStudent_PRN212.Admin.ManageRooms   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Blocal0clr-namespace:Project_ManageStudent_PRN212.Admin     -     � Title$  ManageRooms��$	��450��$
��1000�� � 	Resources  �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius ��Name��%&  '��       '�� �    '��     '�� +    '�� �    '�� f    �� " ��.���  � ��$ 10q���  � ��$
 10,5q���  � �� �#0078D7��  � ��
 �������  � ��$ 16(���  � ��$
 Bold"���  � ��$ 0q���  � ��$ 30����  � ��$	 100����  � ��$ Center=���  � ��$ Center=���  �@�Cursor$
 Hand����  � �� �� " ��.R��� #��z��$ 5��
�������$��1q�._��� $��Center=�$��Center=��� " ��.���  � ��$ 5q���  � ��$ 14(���  � ��$
 Bold"���  � ��$
 Left=��� " ��.���  � ��$ 5q���  � ��$ 5q���  � ��$ 14(���  � �� �#0078D7��  � ��$ 2q���  � ��$	 200����  � ��$ 30����  � ��
 �������  � �� �� " ��.R��� #��z��#��z��#��z��$ 5��._��� $ PART_ContentHost��$��0q��� " ��.���  � ��$ 5q���  � ��$ 5q���  � ��$ 14(���  � ��
 �������  � ��$ 1q���  � ��$	 200����  � ��$ 30����  � ��$
 Left=��� " ��.���  � ��$ 10q���  � ��$ 10q���  � ��$ 14(���  � ��
 �������  � ��$ 1q��� " ��.���  � ��$ 16(���  � ��$
 Bold"���  � �� �#0078D7��  � ��
 �������  � ��$ 5q�.��]� .+��� ���#0078D7$	��Top=�$��50��._�]� .+��� -   $
��Back��$
��Left=�$��Center=��� $��Manage Room��
�������$��20(�$
��Bold"�$��Center=�$��Center=��  � ColumnDefinitions �� $	��650 ��� $��* �.+��� -   	 ��Name$	 lvRooms��$��0��
 �� View
 �� .P��� $��Department Id�� �� Width$	 150�� �� DisplayMemberBinding �� *Department.DepartmentId+�� $��Department Name��$	 150�� �� *Department.DepartmentName+�� $��Room Id��$	 130�� �� *RoomId+�� $��	Room Name��$	 170�� �� *
RoomName+�� $��1��.+��  � RowDefinitions �� $��* ��� $��* ��� $��* �.+��� $��10 0 0 0q�$��0��.+��� $	��150��$��30��$��Department Name���� -   $��cbbdepartment��$	��150��$��30��$
��Left=� �� DisplayMemberPath$ DepartmentName�� �� SelectedValuePath$ DepartmentId�� �� SelectedValue ��  �� ElementName$ lvRooms�� �� Path$* $SelectedItem.Department.DepartmentId� �� Mode$ OneWay=��� $	��150��$��30��$��Room ID���� -   $��	txtRoomId��$	��200��$��30��$
��Left=����� $ lvRooms��$ SelectedItem.RoomId�$ OneWay=��� $	��150��$��30��$��	Room Name���� -   $��txtRoomName��$	��200��$��30��$
��Left=����� $ lvRooms��$ SelectedItem.RoomName�$ OneWay=��� $��	10 10 0 0q�$��1�� �� Orientation$ 
Horizontal=�$��Center=�.+��� -   $��70��$��30��$��Insert��$��20q��� -   $��70��$��30��$��Update��$��20q��� -	   $��70��$��30��$��Delete��$��20q��� $��2��$ 
Horizontal=�$��10 0 0 0q�.+��� -
    ��Name$ 	txtSearch��$	��150��$��30��$
��Left=��� $	��100��$��30��$��Search��$��20 0 0 0q�