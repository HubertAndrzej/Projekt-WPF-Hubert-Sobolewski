   M S B A M L   `   `   `  ����N  JWPFEmployeesTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WPFEmployeesTrackerWPFEmployeesTracker  5   	   &     WPFEmployeesTracker.PositionPage   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WPFEmployeesTracker     5   	   -   5          � Title$  Position Page��5   	   $	��200��6   $	��350��6,    � WindowStartupLocation$ CenterScreen=�68   $��18(�6]   $
��Bold"�6k   ���	#FF6690B5 � Icon$ 	/Logo.png��6�    � 
ResizeMode$ NoResize=�6�   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Department Name��6   $��Center=�6*   $��Center=�6G   �� 5   
   $��Position Name��6   $��1��6(   $��Center=�65   $��Center=�6R   �� 5   
   -   5        $��cmbDepartment��5      $��1��6(   $	��150��68   $
��Left=�6D   $��Center=�6_   �� 5   
   -   5         ��Name$ txtPositionName��5      $��1��6+   $��1��6;   $	��150��6H   $
��Left=�6T   $��Center=�6o    �� TextWrapping$
 Wrap=�6�   �� 5   
   -   5         ��Name$ btnSave��5      $
��Save��6"   $��2��61   $	��100��6>   $��50,0,0,0q�6J   $��Center=�6\   $��Center=�6y   6�   �� 5   
   -   5        $ btnClose��5      $��Close��6#   $��1��63   $��2��6C   $	��100��6P   $��0,0,50,0q�6\   $��Center=�6n   $��Center=�6�   6�   5      5      