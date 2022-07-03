using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFEmployeesTracker.Models;
using WPFEmployeesTracker.ViewModels;

namespace WPFEmployeesTracker
{
    /// <summary>
    /// Interaction logic for TaskPage.xaml
    /// </summary>
    public partial class TaskPage : Window
    {
        public TaskPage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        EmployeesTrackerContext db = new EmployeesTrackerContext();
        List<Employee> employeeList = new List<Employee>();
        List<Position> positions = new List<Position>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            employeeList = db.Employees.OrderBy(x => x.Name).ToList();
            gridEmployee.ItemsSource = employeeList;
            cmbDepartment.ItemsSource = db.Departments.ToList();
            cmbDepartment.DisplayMemberPath = "DepartmentName";
            cmbDepartment.SelectedValuePath = "Id";
            cmbDepartment.SelectedIndex = -1;
            positions = db.Positions.ToList();
            cmbPosition.ItemsSource = positions;
            cmbPosition.DisplayMemberPath = "PositionName";
            cmbPosition.SelectedValuePath = "Id";
            cmbPosition.SelectedIndex = -1;
            if (model != null && model.Id != 0)
            {
                txtEmployeeNo.Text = model.EmployeeNo.ToString();
                txtName.Text = model.Name;
                txtSurname.Text = model.Surname;
                txtTitle.Text = model.TaskTitle;
                txtContent.Text = model.TaskContent;
            }
        }

        int EmployeeId = 0;

        private void gridEmployee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Employee employee = (Employee)gridEmployee.SelectedItem;
            txtEmployeeNo.Text = employee.EmployeeNo.ToString();
            txtName.Text = employee.Name;
            txtSurname.Text = employee.Surname;
            EmployeeId = employee.Id;
        }

        public TaskModel model;

        private void cmbDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int DepartmentId = Convert.ToInt32(cmbDepartment.SelectedValue);
            if (cmbDepartment.SelectedIndex != -1)
            {
                cmbPosition.ItemsSource = positions.Where(x => x.DepartmentId == DepartmentId).ToList();
                cmbPosition.DisplayMemberPath = "PositionName";
                cmbPosition.SelectedValuePath = "Id";
                cmbPosition.SelectedIndex = -1;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtTitle.Text.Trim() == "" || txtContent.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the mandatory areas");
            }
            else
            {
                if (model != null && model.Id != 0)
                {
                    Task task = db.Tasks.Find(model.Id);
                    if (EmployeeId != 0)
                    {
                        task.EmployeeId = EmployeeId;
                    }
                    task.TaskTitle = txtTitle.Text;
                    task.TaskContent = txtContent.Text;
                    db.SaveChanges();
                    MessageBox.Show("The task has been updated");
                }
                else
                {
                    if (EmployeeId == 0)
                    {
                        MessageBox.Show("Please select an employee from table");
                    }
                    else
                    {
                        Task task = new Task();
                        task.EmployeeId = EmployeeId;
                        task.TaskStartDate = DateTime.Now;
                        task.TaskTitle = txtTitle.Text;
                        task.TaskContent = txtContent.Text;
                        task.TaskState = Definitions.TaskStates.OnEmployee;
                        db.Tasks.Add(task);
                        db.SaveChanges();
                        MessageBox.Show("The task has been added");
                        EmployeeId = 0;
                        txtContent.Clear();
                        txtTitle.Clear();
                        txtEmployeeNo.Clear();
                        txtName.Clear();
                        txtSurname.Clear();
                    }
                }
            }
        }
    }
}
