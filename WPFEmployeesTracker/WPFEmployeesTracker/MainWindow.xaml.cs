using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFEmployeesTracker.Models;
using WPFEmployeesTracker.ViewModels;

namespace WPFEmployeesTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lblWindowName.Content = "Task List";
            DataContext = new TaskViewModel();
        }

        private void btnDepartment_Click(object sender, RoutedEventArgs e)
        {
            lblWindowName.Content = "Department List";
            DataContext = new DepartmentViewModel();
        }

        private void btnPosition_Click(object sender, RoutedEventArgs e)
        {
            lblWindowName.Content = "Position List";
            DataContext = new PositionViewModel();
        }

        private void btnEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (!UserStatic.isAdmin)
            {
                EmployeesTrackerContext db = new EmployeesTrackerContext();
                Employee employee = db.Employees.Find(UserStatic.EmployeeId);
                EmployeeModel model = new EmployeeModel();
                model.Address = employee.Address;
                model.BirthDay = (DateTime)employee.BirthDay;
                model.DepartmentId = employee.DepartmentId;
                model.Id = employee.Id;
                model.ImagePath = employee.ImagePath;
                model.isAdmin = (bool)employee.IsAdmin;
                model.Name = employee.Name;
                model.Password = employee.Password;
                model.PositionId = employee.PositionId;
                model.Salary = employee.Salary;
                model.Surname = employee.Surname;
                model.EmployeeNo = employee.EmployeeNo;
                EmployeePage page = new EmployeePage();
                page.model = model;
                page.ShowDialog();
            }
            else
            {
                lblWindowName.Content = "Employee List";
                DataContext = new EmployeeViewModel();
            }
        }

        private void btnTask_Click(object sender, RoutedEventArgs e)
        {
            lblWindowName.Content = "Task List";
            DataContext = new TaskViewModel();
        }

        private void btnSalary_Click(object sender, RoutedEventArgs e)
        {
            lblWindowName.Content = "Salary List";
            DataContext = new SalaryViewModel();
        }

        private void btnPermission_Click(object sender, RoutedEventArgs e)
        {
            lblWindowName.Content = "Permission List";
            DataContext = new PermissionViewModel();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EmployeeMainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if(!UserStatic.isAdmin)
            {
                stackDepartment.Visibility = Visibility.Hidden;
                stackPosition.Visibility = Visibility.Hidden;
                stackLogout.SetValue(Grid.RowProperty, 5);
                stackExit.SetValue(Grid.RowProperty, 6);
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            Application.Current.Shutdown();
        }
    }
}
