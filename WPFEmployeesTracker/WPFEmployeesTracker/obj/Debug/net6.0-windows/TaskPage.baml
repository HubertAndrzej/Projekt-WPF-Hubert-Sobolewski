   M S B A M L   `   `   `  ����N  JWPFEmployeesTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WPFEmployeesTrackerWPFEmployeesTracker  5   	   "    WPFEmployeesTracker.TaskPage   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WPFEmployeesTracker     5   	   -   5          � Title$  	Task Page��5   	   $	��540��6    � Icon$ 	/Logo.png��6(   ���	#FF6690B5 � 
ResizeMode$ NoResize=�6P    � WindowStartupLocation$ CenterScreen=�6f   $��18(�6�   $
��Bold"�6�   $	��800��6�   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      .+�5   
   �  5      �� 5      $��2* �6#   �� 5      $��3* �6#    � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5      �� $��
EmployeeNo��6   $��34��6)   $	��160��65   $��Center=�6A   $��Center=�6^   �� 5      -   5         ��Name$ txtEmployeeNo��5      ${�False��6-   $��1��6?   $��26��6O   $��0,0,0,0q�6[   �� 5       $
��Name��6   $��34��6#   $	��160��6/   $��1��6;   $��Center=�6H   $��Center=�6e   �� 5!      -   5        $ txtName��5!      ${�False��6'   $��1��69   $��1��6F   $��26��6V   $��0,0,0,0q�6b   �� 5"      $��Surname��6   $��34��6&   $	��160��62   $��2��6>   $��Center=�6K   $��Center=�6h   �� 5#      -   5        $ 
txtSurname��5#      ${�False��6*   $��2��6<   $��1��6I   $��26��6Y   $��0,0,0,0q�6e   �� 5$      $��Title��6   $��34��6$   $	��160��60   $��3��6<   $��Center=�6I   $��Center=�6f   �� 5%      -   5        $ txtTitle��5%      $��3��6(    �� TextWrapping$
 Wrap=�65   $��1��6I   $��26��6Y   $��0,0,0,0q�6e   �� 5&      $��Content��6   $��34��6&   $	��160��62   $��4��6>   $��Center=�6K   $��Center=�6h   �� 5'      -   5        $ 
txtContent��5'      $��4��6*   $��3��67   $��1��6H   $
 Wrap=�6X   $��	0,10,0,10q�6l   �� 5(      -   5         ��Name$ btnSave��5(      $
��Save��6&   $��8��65   $��Right=�6B   $��	0,10,0,15q�6^   $	��140��6q   6}   �� 5)      -   5        $ btnClose��5)      $��Close��6'   $��8��67   $��1��6D   $��Center=�6T   $��	0,10,0,15q�6q   $	��140��6�   6�   5*      � 5+   
   $��1��6    5,      �� 5-      $��2* �6#   �� 5.      $��3* �6#    50      �� 51      $��* �6    �� 52      $��* �6    �� 53      $��7* �6    .+�55      �� $��
Department��6   $
��auto��6)   $
��Left=�66   $��Center=�6Q   $��34��6l   �� 56      -	   5        $��cmbDepartment��56      $��1��6,   $��Center=�6<   $��30��6W   $��0,0,0,0q�6c   6t   �� 57      $��Position��6   $��1��6'   $
��auto��64   $
��Left=�6A   $��Center=�6\   $��34��6w   �� 58      -
   5        $��cmbPosition��58      $��1��6*   $��1��67   $��Center=�6G   $��30��6b   $��0,0,0,0q�6n   &   System.Windows.Controls.DataGrid  59      -   5        $��gridEmployee��59      $��2��6+   	   AutoGenerateColumns$	 False��68   $��2��6T   $��0,0,0,0q�6h   
   Columns
 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 65      
Visibility$ Hidden=�6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Id+6V     5<      $ 
EmployeeNo��6)   $ * 6=    6G   �� *
EmployeeNo+  5=      $
 Name��6)   $ * 67    6A   �� *Name+  5>      $ Surname��6)   $ * 6:    6D   �� *	Surname+5@      5A      5B      5C      