   M S B A M L   `   `   `  ����N  JWPFEmployeesTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WPFEmployeesTrackerWPFEmployeesTracker  5   	   (    "WPFEmployeesTracker.DepartmentPage   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WPFEmployeesTracker     5   	   -   5          � Title$  Department Page��5   	   $	��200��6!   $	��350��6.    � WindowStartupLocation$ CenterScreen=�6:   $��18(�6_   $
��Bold"�6m   ���	#FF6690B5 � Icon$ 	/Logo.png��6�    � 
ResizeMode$ NoResize=�6�   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Department Name��6   $��Center=�6*   $��Center=�6G   �� 5   
   -   5         ��Name$ txtDepartmentName��5      $��1��6-   $	��150��6=   $
��Left=�6I   $��Center=�6d    �� TextWrapping$
 Wrap=�6   �� 5   
   -   5         ��Name$ btnSave��5      $
��Save��6"   $��1��61   $	��100��6>   $��50,0,0,0q�6J   $��Center=�6\   $��Center=�6y   6�   �� 5   
   -   5        $ btnClose��5      $��Close��6#   $��1��63   $��1��6C   $	��100��6P   $��0,0,50,0q�6\   $��Center=�6n   $��Center=�6�   6�   5      5      