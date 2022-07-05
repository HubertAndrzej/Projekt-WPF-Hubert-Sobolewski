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
    /// Interaction logic for PermissionList.xaml
    /// </summary>
    public partial class PermissionList : UserControl
    {
        public PermissionList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            PermissionPage page = new PermissionPage();
            page.ShowDialog();
            FillDataGrid();
        }

        List<PermissionModel> permissions = new List<PermissionModel>();

        void FillDataGrid()
        {
            permissions = db.Permissions.Include(x => x.Employee).Include(x => x.PermissionStateNavigation).Select(x => new PermissionModel()
            {
                DayAmount = x.PermissionAmount,
                DepartmentId = x.Employee.DepartmentId,
                EmployeeId = x.EmployeeId,
                EndDate = x.PermissionEndDate,
                Explanation = x.PermissionExplanation,
                Id = x.Id,
                Name = x.Employee.Name,
                PermissionState = x.PermissionState,
                PositionId = x.Employee.PositionId,
                StartDate = (DateTime)x.PermissionStartDate,
                StateName = x.PermissionStateNavigation.StateName,
                Surname = x.Employee.Surname,
                EmployeeNo = x.Employee.EmployeeNo
            }).OrderByDescending(x => x.StartDate).ToList();
            gridPermission.ItemsSource = permissions;
        }

        EmployeesTrackerContext db = new EmployeesTrackerContext();
        List<Position> positions = new List<Position>();

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            FillDataGrid();
            cmbDepartment.ItemsSource = db.Departments.ToList();
            cmbDepartment.DisplayMemberPath = "DepartmentName";
            cmbDepartment.SelectedValuePath = "Id";
            cmbDepartment.SelectedIndex = -1;
            positions = db.Positions.ToList();
            cmbPosition.ItemsSource = positions;
            cmbPosition.DisplayMemberPath = "PositionName";
            cmbPosition.SelectedValuePath = "Id";
            cmbPosition.SelectedIndex = -1;
            List<PermissionState> states = db.PermissionStates.ToList();
            cmbState.ItemsSource = states;
            cmbState.DisplayMemberPath = "PermissionState";
            cmbState.SelectedValuePath = "Id";
            cmbState.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            List<PermissionModel> search = permissions;
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
            if (rbStart.IsChecked == true)
            {
                search = search.Where(x => x.StartDate > dpStart.SelectedDate && x.StartDate < dpEnd.SelectedDate).ToList();
            }
            if (rbEnd.IsChecked == true)
            {
                search = search.Where(x => x.EndDate > dpStart.SelectedDate && x.EndDate < dpEnd.SelectedDate).ToList();
            }
            if (cmbState.SelectedIndex != -1)
            {
                search = search.Where(x => x.PermissionState == Convert.ToInt32(cmbState.SelectedValue)).ToList();
            }
            if (txtDayAmount.Text.Trim() != "")
            {
                search = search.Where(x => x.DayAmount == Convert.ToInt32(txtDayAmount.Text)).ToList();
            }
            gridPermission.ItemsSource = search;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtDayAmount.Clear();
            txtName.Clear();
            txtSurname.Clear();
            txtEmployeeNo.Clear();
            cmbDepartment.SelectedIndex = -1;
            cmbState.SelectedIndex = -1;
            cmbPosition.ItemsSource = positions;
            cmbPosition.SelectedIndex = -1;
            dpEnd.SelectedDate = DateTime.Today;
            dpStart.SelectedDate = DateTime.Today;
            rbEnd.IsChecked = false;
            rbStart.IsChecked = false;
            gridPermission.ItemsSource = permissions;
        }
    }
}
