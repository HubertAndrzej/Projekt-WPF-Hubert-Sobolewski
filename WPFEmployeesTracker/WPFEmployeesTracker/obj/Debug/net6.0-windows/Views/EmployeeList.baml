   M S B A M L   `   `   `  ����N  JWPFEmployeesTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:WPFEmployeesTracker.ViewsWPFEmployeesTracker.Views  5      ,    &WPFEmployeesTracker.Views.EmployeeList   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:WPFEmployeesTracker.Views     5      -   5        $��18(�5   7   $
��Bold"�6E   .��5	      �   � RowDefinitions  5
   
   �� 5      $��3* �6   �� 5      $��6* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ gridEmployee��5      $��1��6)   $��5��66      AutoGenerateColumns$ False��6J      
IsReadOnly$
 True��6f      SelectionMode$ Single=�6x      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 61   	   
Visibility$	 Hidden=�6R   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6;   �� *Id+6R     5      $ 
EmployeeNo��6%   $ * 69   
 6C   �� *
EmployeeNo+  5      $
 Name��6%   $ * 63   
 6=   �� *Name+  5      $ Surname��6%   $ * 66   
 6@   �� *	Surname+  5      $ Position��6%   $ * 67   
 6A   �� *PositionName+  5      $ 
Department��6%   $ * 69   
 6C   �� *DepartmentName+  5      $ Salary��6%   $ * 65   
 6?   �� *Salary+  5      $ 
PositionId��6%   $ * 69   $	 Hidden=�6b   
 6C   �� *
PositionId+6b     5       $ DepartmentId��6%   $ * 6;   $	 Hidden=�6f   
 6E   �� *DepartmentId+6f     5!      $ isAdmin��6%   $ * 66   $	 Hidden=�6\   
 6@   �� *	isAdmin+6\     5"      $ BirthDay��6%   $ * 67   $	 Hidden=�6^   
 6A   �� *
BirthDay+6^     5#      $ Address��6%   $ * 66   $	 Hidden=�6\   
 6@   �� *	Address+6\     5$      $ Password��6%   $ * 67   $	 Hidden=�6^   
 6A   �� *
Password+6^     5%      $ 	ImagePath��6%   $ * 68   $	 Hidden=�6`   
 6B   �� *	ImagePath+6`   5'      � 5(   
   $��5��6     5)      �� 5*      �� 5+      �� 5,       5.      �� 5/      $	��60* �6#   �� 50      $
��100* �6#   �� 51      $	��60* �6#   �� 52      $
��100* �6#   �� 53      $	��80* �6#   .+�55      �� $��
EmployeeNo��6   $��34��6)   $	��120��65   $��Center=�6A   $��Center=�6^   �� 56      -   5         ��Name$ txtEmployeeNo��56      $��1��6-    �� TextWrapping$
 Wrap=�6=   $��0,0,0,0q�6Q   $��26��6b   �� 57      $
��Name��6   $��1��6#   $��34��60   $	��120��6<   $��Center=�6H   $��Center=�6e   �� 58      -   5        $ txtName��58      $��1��6'   $��1��64   $
 Wrap=�6D   $��0,0,0,0q�6X   $��26��6i   �� 59      $��Surname��6   $��2��6&   $��34��63   $	��120��6?   $��Center=�6K   $��Center=�6h   �� 5:      -   5        $ 
txtSurname��5:      $��2��6*   $��1��67   $
 Wrap=�6G   $��0,0,0,0q�6[   $��26��6l   �� 5;      $��
Department��6   $��2��6)   $	��120��69   $��Center=�6E   $��Center=�6b   $��34��6}   �� 5<      -   5        $��cmbDepartment��5<      $��3��6,   $��Center=�6<   $��30��6W   $��0,0,0,0q�6c   6t   �� 5=      $��Position��6   $��1��6'   $��2��64   $	��120��6D   $��Center=�6P   $��Center=�6m   $��34��6�   �� 5>      -   5        $��cmbPosition��5>      $��1��6*   $��3��67   $��Center=�6G   $��30��6b   $��0,0,0,0q�6n   �� 5?      -   5        $��	btnSearch��5?   6   $��4��6   $��Search��6%   $��	20,5,10,5q�6G   6Z   �� 5@      -	   5        $��btnClear��5@   B   $��1��6   $��4��6"   $��Clear��62   $��	20,5,10,5q�6R   6e   5A      �� 5B   
   -
   5         ��Name$ btnAdd��5B      $	��Add��6!   $��18(�6/   $
��Bold"�6=   $��2��6O   $��1��6\   $��	40,5,40,5q�6l   6   �� 5C   
   -   5        $ 	btnUpdate��5C      $��Update��6$   $��18(�65   $
��Bold"�6C   $��2��6U   $��2��6b   $��	40,5,40,5q�6r   6�   �� 5D   
   -   5        $ 	btnDelete��5D      $��Delete��6$   $��18(�65   $
��Bold"�6C   $��2��6U   $��3��6b   $��	40,5,40,5q�6r   6�   5E      5F      