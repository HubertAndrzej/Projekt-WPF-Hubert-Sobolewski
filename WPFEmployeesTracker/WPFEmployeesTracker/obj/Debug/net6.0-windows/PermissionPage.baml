   M S B A M L   `   `   `  ����N  JWPFEmployeesTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WPFEmployeesTrackerWPFEmployeesTracker  5   	   (    "WPFEmployeesTracker.PermissionPage   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WPFEmployeesTracker     5   	   -   5          � Title$  Permission Page��5   	   $	��450��6!   $	��450��6.    � WindowStartupLocation$ CenterScreen=�6:   $��18(�6_   $
��Bold"�6m   ���	#FF6690B5 � Icon$ 	/Logo.png��6�    � 
ResizeMode$ NoResize=�6�   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��
EmployeeNo��6   $��34��6%   $	��150��61   $��Center=�6=   $��Center=�6Z   �� 5   
   -   5         ��Name$ txtEmployeeNo��5      ${�False��6)   $��1��6;   $��26��6K   $��0,0,30,0q�6W   �� 5   
   $��
Start Date��6   $��1��6%   $��34��62   $	��150��6>   $��Center=�6J   $��Center=�6g   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��dpStart��5      $��1��6$   $��1��61   6A   �� 5   
   $��End Date��6   $��2��6#   $��34��60   $	��150��6<   $��Center=�6H   $��Center=�6e     5   
   -   5        $��dpEnd��5      $��2��6"   $��1��6/   6?   �� 5   
   $��
Day Amount��6   $��3��6%   $��34��62   $	��150��6>   $��Center=�6J   $��Center=�6g   �� 5    
   -   5        $ txtDayAmount��5       ${�False��6(   $��3��6:   $��1��6G   $��26��6W   $��0,0,30,0q�6c   �� 5!   
   $��Explanation��6   $��4��6&   $��34��63   $	��150��6?   $��Center=�6K   $��Center=�6h   �� 5"   
   -   5        $ txtExplanation��5"      $��4��6*   $��2��67   $��1��6H   $��0,0,30,0q�6X   � 5#   
   $��7��6   $��2��6    5$      �� 5%      �� 5&      .+�5(      �� -   5         ��Name$ btnSave��5(      $
��Save��6&   $��7��65   $��Right=�6B   $��0,0,0,0q�6^   $	��140��6o   6{   �� 5)      -   5        $ btnClose��5)      $��Close��6'   $��7��67   $��1��6D   $��Center=�6T   $��0,0,0,0q�6q   $	��140��6�   6�   5*      5+      5,      