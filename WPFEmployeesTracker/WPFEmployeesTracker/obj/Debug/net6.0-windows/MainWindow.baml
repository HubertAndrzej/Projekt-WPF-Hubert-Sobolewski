   M S B A M L   `   `   `  ����N  JWPFEmployeesTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WPFEmployeesTrackerWPFEmployeesTracker  5   	   E'clr-namespace:WPFEmployeesTracker.ViewsWPFEmployeesTracker.Views  5   	   O,clr-namespace:WPFEmployeesTracker.ViewModelsWPFEmployeesTracker.ViewModels  5   	   $    WPFEmployeesTracker.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WPFEmployeesTracker     5   	   9views'clr-namespace:WPFEmployeesTracker.Views     5   	   C
viewmodels,clr-namespace:WPFEmployeesTracker.ViewModels     5   	   -   5        $��EmployeeMainWindow��5
   '     � Title$  WPF Employees Tracker��6	   $	��540��6A   $
��1200��6N    � WindowStartupLocation$ CenterScreen=�6[   $��24(�6�   $
��Bold"�6�   ���	#FF6690B5 � Icon$ 	/Logo.png��6�    � 
ResizeMode$ NoResize=�6�   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��4* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��	/Logo.png��6   �� 5   
   $��1��6   $��1��6=   $��8��6J   $
��Auto��6[   $
��Auto��6i   ��6)   �� 6i   �� 5   
   -   5         ��Name$ lblWindowName��5      $��1��6'   $!��Welcome to Employee Tracker��67   $��Center=�6]   $��Center=�6z   $��24(�6�   �� 5   
   $��1��6   $��0,2,0,0q�6"   .+�5      �� -   5        $��btnEmployee��5   "   $��1��6   $��60��65   $	��250��6A   $
��Left=�6M   .��5       � $	��230��6    5!      �� 5"      $
��auto �6+   �� 5#      $
��auto �6+   .+�5%      �� -   5         ��Name$ EmployeeImage��5%      $
��Left=�63   $
��auto��6N   $��73��6\   $��0,0,0,0q�6g   $��/Employee.png��6x   �� 5&      $��Employee��6    $��1��60   $
��Left=�6@   $��Center=�6[   5'      5(      5)      �� 5*   
   $��2��6   $��0,2,0,0q�6"   .+�5+      �� -   5        $��btnTask��5+   "   $��2��6   $��60��61   $	��250��6=   $
��Left=�6I   .��5,      � $	��230��6    5-      �� 5.      $
��auto �6+   �� 5/      $
��auto �6+   .+�51      �� -   5        $ 	TaskImage��51      $
��Left=�6/   $
��auto��6J   $��73��6X   $��0,0,0,0q�6c   $��
/Tasks.png��6t   �� 52      $
��Task��6    $��1��6,   $
��Left=�6<   $��Center=�6W   53      54      55      �� 56   
   $��3��6   $��0,2,0,0q�6"   .+�57      �� -   5        $��	btnSalary��57   "   $��3��6   $��60��63   $	��250��6?   $
��Left=�6K   .��58      � $	��230��6    59      �� 5:      $
��auto �6+   �� 5;      $
��auto �6+   .+�5=      �� -   5        $ SalaryImage��5=      $
��Left=�61   $
��auto��6L   $��73��6Z   $��0,0,0,0q�6e   $��/Salary.png��6v   �� 5>      $��Salary��6    $��1��6.   $
��Left=�6>   $��Center=�6Y   5?      5@      5A      �� 5B   
   $��4��6   $��0,2,0,0q�6"   .+�5C      �� -	   5        $��btnPermission��5C   "   $��4��6   $��60��67   $	��250��6C   $
��Left=�6O   .��5D      � $	��230��6    5E      �� 5F      $
��auto �6+   �� 5G      $
��auto �6+   .+�5I      �� -
   5        $ PermissionImage��5I      $
��Left=�65   $
��auto��6P   $��73��6^   $��0,0,0,0q�6i   $��/Permission.png��6z   �� 5J      $��
Permission��6    $��1��62   $
��Left=�6B   $��Center=�6]   5K      5L      5M      �� 5N   
   -   5         ��Name$ stackDepartment��5N      $��5��6.   $��0,2,0,0q�6;   .+�5O      �� -   5        $��btnDepartment��5O   "   $��5��6   $��60��67   $	��250��6C   $
��Left=�6O   .��5P      � $	��230��6    5Q      �� 5R      $
��auto �6+   �� 5S      $
��auto �6+   .+�5U      �� -   5        $ DepartmentImage��5U      $
��Left=�65   $
��auto��6P   $��73��6^   $��0,0,0,0q�6i   $��/Department.png��6z   �� 5V      $��
Department��6    $��1��62   $
��Left=�6B   $��Center=�6]   5W      5X      5Y      �� 5Z   
   -   5        $ stackPosition��5Z      $��6��6,   $��0,2,0,0q�69   .+�5[      �� -   5        $��btnPosition��5[   "   $��6��6   $��60��65   $	��250��6A   $
��Left=�6M   .��5\      � $	��230��6    5]      �� 5^      $
��auto �6+   �� 5_      $
��auto �6+   .+�5a      �� -   5        $ PositionImage��5a      $
��Left=�63   $
��auto��6N   $��73��6\   $��0,0,0,0q�6g   $��/Position.png��6x   �� 5b      $��Position��6    $��1��60   $
��Left=�6@   $��Center=�6[   5c      5d      5e      �� 5f   
   -   5        $ stackLogout��5f      $��7��6*   $��0,2,0,0q�67   .+�5g      �� -   5        $��	btnLogout��5g   "   $��7��6   $��60��63   $	��250��6?   $
��Left=�6K   .��5h      � $	��230��6    5i      �� 5j      $
��auto �6+   �� 5k      $
��auto �6+   .+�5m      �� -   5        $ LogoutImage��5m      $
��Left=�61   $
��auto��6L   $��73��6Z   $��0,0,0,0q�6e   $��/Logout.png��6v   �� 5n      $��Logout��6    $��1��6.   $
��Left=�6>   $��Center=�6Y   5o      5p      5q      �� 5r   
   -   5        $ 	stackExit��5r      $��8��6(   $��0,2,0,0q�65   .+�5s      �� -   5        $��btnExit��5s   "   $��8��6   $��60��61   $	��250��6=   $
��Left=�6I   .��5t      � $	��230��6    5u      �� 5v      $
��auto �6+   �� 5w      $
��auto �6+   .+�5y      �� -   5        $ 	ExitImage��5y      $
��Left=�6/   $
��auto��6J   $��73��6X   $��0,0,0,0q�6c   $��	/Exit.png��6t   �� 5z      $
��Exit��6    $��1��6,   $
��Left=�6<   $��Center=�6W   5{      5|      5}      5~      	 � 	Resources	 5      
 �� DataType8   2WPFEmployeesTracker.ViewModels.DepartmentViewModel.   (WPFEmployeesTracker.Views.DepartmentList6   0WPFEmployeesTracker.ViewModels.PositionViewModel,   &WPFEmployeesTracker.Views.PositionList6   0WPFEmployeesTracker.ViewModels.EmployeeViewModel,   &WPFEmployeesTracker.Views.EmployeeList2   ,WPFEmployeesTracker.ViewModels.TaskViewModel(   "WPFEmployeesTracker.Views.TaskList4	   .WPFEmployeesTracker.ViewModels.SalaryViewModel*
   $WPFEmployeesTracker.Views.SalaryList8   2WPFEmployeesTracker.ViewModels.PermissionViewModel.   (WPFEmployeesTracker.Views.PermissionList��%\  (��       5�   3   *, +)(�� N     5�   1   *, +)(�� �     5�   1   *, +)(�� �     5�   -   *, +)(�� .    5�   /   *,	 +)(�� x    5�   3   *, +)�� 5�   
   DepartmentTemplate��"
  63   .R�5�        6%   5�      �� 5�   
   PositionTemplate��"
  61   .R�5�        6#   5�      �� 5�   
   EmployeeTemplate��"
  61   .R�5�        6#   5�      �� 5�   
   TaskTemplate��"
  6-   .R�5�        6   5�      �� 5�   
   SalaryTemplate��"
 	 6/   .R�5�      
  6!   5�      �� 5�   
   PermissionTemplate��"
  63   .R�5�        6%   5�      5�      5�      