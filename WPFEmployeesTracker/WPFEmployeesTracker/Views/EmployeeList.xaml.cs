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
    /// Interaction logic for EmployeeList.xaml
    /// </summary>
    public partial class EmployeeList : UserControl
    {
        public EmployeeList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            EmployeePage page = new EmployeePage();
            page.ShowDialog();
        }

        EmployeesTrackerContext db = new EmployeesTrackerContext();
        List<Position> positions = new List<Position>();
        List<EmployeeModel> list = new List<EmployeeModel>();

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            cmbDepartment.ItemsSource = db.Departments.ToList();
            cmbDepartment.DisplayMemberPath = "DepartmentName";
            cmbDepartment.SelectedValuePath = "Id";
            cmbDepartment.SelectedIndex = -1;
            positions = db.Positions.ToList();
            cmbPosition.ItemsSource = positions;
            cmbPosition.DisplayMemberPath = "PositionName";
            cmbPosition.SelectedValuePath = "Id";
            cmbPosition.SelectedIndex = -1;
            list = db.Employees.Include(x => x.Position).Include(x => x.Department).Select(x => new EmployeeModel(){
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                Address = x.Address,
                BirthDay = (DateTime)x.BirthDay,
                DepartmentId = x.DepartmentId,
                DepartmentName = x.Department.DepartmentName,
                PositionId = x.PositionId,
                PositionName = x.Position.PositionName,
                isAdmin = (bool)x.IsAdmin,
                Password = x.Password,
                Salary = x.Salary,
                EmployeeNo = x.EmployeeNo
            }).ToList();
            gridEmployee.ItemsSource = list;
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

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            List<EmployeeModel> searchList = list;
            if (txtEmployeeNo.Text.Trim() != "")
            {
                searchList = searchList.Where(x => x.EmployeeNo == Convert.ToInt32(txtEmployeeNo.Text)).ToList();
            }
            if (txtName.Text.Trim() != "")
            {
                searchList = searchList.Where(x => x.Name.Contains(txtName.Text)).ToList();
            }
            if (txtSurname.Text.Trim() != "")
            {
                searchList = searchList.Where(x => x.Surname.Contains(txtSurname.Text)).ToList();
            }
            if (cmbPosition.SelectedIndex != -1)
            {
                searchList = searchList.Where(x => x.PositionId == Convert.ToInt32(cmbPosition.SelectedValue)).ToList();
            }
            if (cmbDepartment.SelectedIndex != -1)
            {
                searchList = searchList.Where(x => x.DepartmentId == Convert.ToInt32(cmbDepartment.SelectedValue)).ToList();
            }
            gridEmployee.ItemsSource = searchList;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtEmployeeNo.Clear();
            txtName.Clear();
            txtSurname.Clear();
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.ItemsSource = positions;
            cmbPosition.SelectedIndex = -1;
            gridEmployee.ItemsSource = list;
        }
    }
}
