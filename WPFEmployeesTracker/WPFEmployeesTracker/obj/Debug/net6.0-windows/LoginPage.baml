   M S B A M L   `   `   `  ����N  JWPFEmployeesTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WPFEmployeesTrackerWPFEmployeesTracker  5   	   #    WPFEmployeesTracker.LoginPage   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WPFEmployeesTracker     5   	     � Title$  Employees Tracker Login��5   	   $	��200��6)   $	��350��66    � WindowStartupLocation$ CenterScreen=�6B   ���	#FF6690B5 � Icon$ 	/Logo.png��6~   $��24(�6�   $
��Bold"�6�   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��
EmployeeNo��6   $��Center=�6%   $��Center=�6B   �� 5   
   -   5         ��Name$ txtEmployeeNo��5      $��1��6)   $	��150��69   $
��Left=�6E   $��Center=�6`   6{   �� 5   
   $��Password��6   $��1��6#   $��Center=�60   $��Center=�6M   �� 5   
   -   5        $ txtPassword��5      $��1��6'   $��1��64   $	��150��6D   $
��Left=�6P   $��Center=�6k   �� 5   
   -   5         ��Name$ btnLogin��5      $��Login��6#   $��2��63   $��50,0,0,0q�6@   $	��100��6R   $��Center=�6^   $��Center=�6{   6�   �� 5   
   -   5        $ btnExit��5      $
��Exit��6"   $��2��61   $��1��6>   $��50,0,0,0q�6N   $	��100��6`   $
��Left=�6l   $��Center=�6�   6�   5      5      