using Microsoft.EntityFrameworkCore;
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

namespace WPFEmployeesTracker.Views
{
    /// <summary>
    /// Interaction logic for TaskList.xaml
    /// </summary>
    public partial class TaskList : UserControl
    {
        public TaskList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            TaskPage page = new TaskPage();
            page.ShowDialog();
            FillDataGrid();
        }

        EmployeesTrackerContext db = new EmployeesTrackerContext();
        List<TaskModel> taskList = new List<TaskModel>();
        List<TaskModel> searchList = new List<TaskModel>();
        List<Position> positions = new List<Position>();

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            FillDataGrid();
        }

        void FillDataGrid()
        {
            taskList = db.Tasks.Include(x => x.TaskStateNavigation).Include(x => x.Employee).ThenInclude(x => x.Department).ThenInclude(x => x.Positions).Select(x => new TaskModel()
            {
                Id = x.Id,
                EmployeeId = x.EmployeeId,
                Name = x.Employee.Name,
                StateName = x.TaskStateNavigation.StateName,
                Surname = x.Employee.Surname,
                TaskContent = x.TaskContent,
                TaskDeliveryDate = x.TaskDeliveryDate,
                TaskStartDate = (DateTime)x.TaskStartDate,
                TaskState = x.TaskState,
                TaskTitle = x.TaskTitle,
                EmployeeNo = x.Employee.EmployeeNo,
                DepartmentId = x.Employee.DepartmentId,
                PositionId = x.Employee.PositionId
            }).ToList();
            gridTask.ItemsSource = taskList;
            searchList = taskList;
            cmbDepartment.ItemsSource = db.Departments.ToList();
            cmbDepartment.DisplayMemberPath = "DepartmentName";
            cmbDepartment.SelectedValuePath = "Id";
            cmbDepartment.SelectedIndex = -1;
            positions = db.Positions.ToList();
            cmbPosition.ItemsSource = positions;
            cmbPosition.DisplayMemberPath = "PositionName";
            cmbPosition.SelectedValuePath = "Id";
            cmbPosition.SelectedIndex = -1;
            List<TaskState> taskStates = db.TaskStates.ToList();
            cmbState.ItemsSource = taskStates;
            cmbState.DisplayMemberPath = "NameState";
            cmbState.SelectedValuePath = "Id";
            cmbState.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            List<TaskModel> search = searchList;
            if (txtEmployeeNo.Text.Trim() != "")
            {
                search = search.Where(x => x.EmployeeNo == Convert.ToInt32(txtEmployeeNo.Text)).ToList();
            }
            if (txtName.Text.Trim() != "")
            {
                search = search.Where(x => x.Name.Contains(txtName.Text)).ToList();
            }
            if (txtSurname.Text.Trim() != "")
            {
                search = search.Where(x => x.Surname.Contains(txtSurname.Text)).ToList();
            }
            if (cmbDepartment.SelectedIndex != -1)
            {
                search = search.Where(x => x.DepartmentId == Convert.ToInt32(cmbDepartment.SelectedValue)).ToList();
            }
            if (cmbPosition.SelectedIndex != -1)
            {
                search = search.Where(x => x.PositionId == Convert.ToInt32(cmbPosition.SelectedValue)).ToList();
            }
            if (cmbState.SelectedIndex != -1)
            {
                search = search.Where(x => x.TaskState == Convert.ToInt32(cmbState.SelectedValue)).ToList();
            }
            if (rbStart.IsChecked == true)
            {
                search = search.Where(x => x.TaskStartDate > dpStart.SelectedDate && x.TaskStartDate < dpDelivery.SelectedDate).ToList();
            }
            if (rbDelivery.IsChecked == true)
            {
                search = search.Where(x => x.TaskDeliveryDate > dpStart.SelectedDate && x.TaskDeliveryDate < dpDelivery.SelectedDate).ToList();
            }
            gridTask.ItemsSource = search;
        }

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

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtEmployeeNo.Clear();
            txtName.Clear();
            txtSurname.Clear();
            dpDelivery.SelectedDate = DateTime.Today;
            dpStart.SelectedDate = DateTime.Today;
            cmbDepartment.SelectedIndex = -1;
            cmbState.SelectedIndex = -1;
            cmbPosition.ItemsSource = positions;
            cmbPosition.SelectedIndex = -1;
            rbDelivery.IsChecked = false;
            rbStart.IsChecked = false;
            gridTask.ItemsSource = taskList;
        }
    }
}
