   M S B A M L   `   `   `  ����N  JWPFEmployeesTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WPFEmployeesTrackerWPFEmployeesTracker  5   	   $    WPFEmployeesTracker.SalaryPage   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WPFEmployeesTracker     5   	   -   5          � Title$  Salary Page��5   	   $	��450��6    � Icon$ 	/Logo.png��6*   ���	#FF6690B5 � 
ResizeMode$ NoResize=�6R    � WindowStartupLocation$ CenterScreen=�6h   $��18(�6�   $
��Bold"�6�   $	��800��6�   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      .+�5   
   �  5      �� 5      $��2* �6#   �� 5      $��3* �6#    � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5      �� $��
EmployeeNo��6   $��34��6)   $	��160��65   $��Center=�6A   $��Center=�6^   �� 5      -   5         ��Name$ txtEmployeeNo��5      ${�False��6-   $��1��6?   $��26��6O   $��0,0,0,0q�6[   �� 5       $
��Name��6   $��34��6#   $	��160��6/   $��1��6;   $��Center=�6H   $��Center=�6e   �� 5!      -   5        $ txtName��5!      ${�False��6'   $��1��69   $��1��6F   $��26��6V   $��0,0,0,0q�6b   �� 5"      $��Surname��6   $��34��6&   $	��160��62   $��2��6>   $��Center=�6K   $��Center=�6h   �� 5#      -   5        $ 
txtSurname��5#      ${�False��6*   $��2��6<   $��1��6I   $��26��6Y   $��0,0,0,0q�6e   �� 5$      $��Salary��6   $��34��6%   $	��160��61   $��3��6=   $��Center=�6J   $��Center=�6g   �� 5%      -   5        $ 	txtSalary��5%      $��3��6)    �� TextWrapping$
 Wrap=�66   $��1��6J   $��26��6Z   $��0,0,0,0q�6f   �� 5&      $
��Year��6   $��34��6#   $	��160��6/   $��4��6;   $��Center=�6H   $��Center=�6e   �� 5'      -   5        $ txtYear��5'      $��4��6'   $��1��64   $��26��6D   $
 Wrap=�6P   $��	0,10,0,10q�6d   �� 5(      $��Month��6   $��34��6$   $	��160��60   $��5��6<   $��Center=�6I   $��Center=�6f   �� 5)      -   5        $��cmbMonth��5)      $��5��6'   $��1��64   $��30��6D   $��0,0,0,0q�6P   �� 5*      -   5         ��Name$ btnSave��5*      $
��Save��6&   $��7��65   $��Right=�6B   $��0,0,0,0q�6^   $	��140��6o   6{   �� 5+      -	   5        $ btnClose��5+      $��Close��6'   $��7��67   $��1��6D   $��Center=�6T   $��0,0,0,0q�6q   $	��140��6�   6�   5,      � 5-   
   $��1��6    5.      �� 5/      $��2* �6#   �� 50      $��3* �6#    52      �� 53      $��* �6    �� 54      $��* �6    �� 55      $��7* �6    .+�57      �� $��
Department��6   $
��auto��6)   $
��Left=�66   $��Center=�6Q   $��34��6l   �� 58      -
   5        $��cmbDepartment��58      $��1��6,   $��Center=�6<   $��30��6W   $��0,0,0,0q�6c   6t   �� 59      $��Position��6   $��1��6'   $
��auto��64   $
��Left=�6A   $��Center=�6\   $��34��6w   �� 5:      -   5        $��cmbPosition��5:      $��1��6*   $��1��67   $��Center=�6G   $��30��6b   $��0,0,0,0q�6n   6   &   System.Windows.Controls.DataGrid  5;      -   5        $��gridEmployee��5;      $��2��6+   	   AutoGenerateColumns$	 False��68   $��2��6T   $��0,0,0,0q�6h   
   Columns
 5<      0  *System.Windows.Controls.DataGridTextColumn  5=      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 65      
Visibility$ Hidden=�6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Id+6V     5>      $ 
EmployeeNo��6)   $ * 6=    6G   �� *
EmployeeNo+  5?      $
 Name��6)   $ * 67    6A   �� *Name+  5@      $ Surname��6)   $ * 6:    6D   �� *	Surname+  5A      $ Salary��6)   $ * 69   $ Hidden=�6^    6C   �� *Salary+6^   5C      5D      5E      5F      