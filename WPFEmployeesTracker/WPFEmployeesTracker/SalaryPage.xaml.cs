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
using System.Windows.Shapes;
using WPFEmployeesTracker.Models;
using WPFEmployeesTracker.ViewModels;

namespace WPFEmployeesTracker
{
    /// <summary>
    /// Interaction logic for SalaryPage.xaml
    /// </summary>
    public partial class SalaryPage : Window
    {
        public SalaryPage()
        {
            InitializeComponent();
        }

        EmployeesTrackerContext db = new EmployeesTrackerContext();
        List<Position> positions = new List<Position>();
        List<Employee> employeeList = new List<Employee>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            employeeList = db.Employees.ToList();
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
            List<SalaryMonth> months = db.SalaryMonths.ToList();
            cmbMonth.ItemsSource = months;
            cmbMonth.DisplayMemberPath = "MonthName";
            cmbMonth.SelectedValuePath = "Id";
            cmbMonth.SelectedIndex = -1;
            if (model != null && model.Id != 0)
            {
                txtName.Text = model.Name;
                txtSalary.Text = model.Amount.ToString();
                txtSurname.Text = model.Surname;
                txtEmployeeNo.Text = model.EmployeeNo.ToString();
                txtYear.Text = model.Year.ToString();
                EmployeeId = model.EmployeeId;
                cmbMonth.SelectedValue = model.MonthId;
            }
        }

        int EmployeeId = 0;

        private void gridEmployee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Employee employee = (Employee)gridEmployee.SelectedItem;
            txtEmployeeNo.Text = employee.EmployeeNo.ToString();
            txtName.Text = employee.Name;
            txtSurname.Text = employee.Surname;
            txtSalary.Text = employee.Salary.ToString();
            txtYear.Text = DateTime.Now.Year.ToString();
            EmployeeId = employee.Id;
        }

        private void cmbDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            gridEmployee.ItemsSource = employeeList.Where(x => x.DepartmentId == Convert.ToInt32(cmbDepartment.SelectedItem)).ToList();
            int DepartmentId = Convert.ToInt32(cmbDepartment.SelectedValue);
            if (cmbDepartment.SelectedIndex != -1)
            {
                cmbPosition.ItemsSource = positions.Where(x => x.DepartmentId == DepartmentId).ToList();
                cmbPosition.DisplayMemberPath = "PositionName";
                cmbPosition.SelectedValuePath = "Id";
                cmbPosition.SelectedIndex = -1;
            }
        }

        private void cmbPosition_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            gridEmployee.ItemsSource = employeeList.Where(x => x.DepartmentId == Convert.ToInt32(cmbPosition.SelectedItem)).ToList();
        }

        public SalaryModel model;

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtSalary.Text.Trim() == "" || txtYear.Text.Trim() == "" || cmbMonth.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill the mandatory areas");
            }
            else
            {
                if (model != null && model.Id != 0)
                {
                    Salary salary = db.Salaries.Find(model.Id);
                    int oldSalary = salary.Amount;
                    salary.Amount = Convert.ToInt32(txtSalary.Text);
                    salary.EmployeeId = EmployeeId;
                    salary.Month = Convert.ToInt32(cmbMonth.SelectedValue);
                    salary.Year = Convert.ToInt32(txtYear.Text);
                    db.SaveChanges();
                    if (oldSalary < salary.Amount)
                    {
                        Employee employee = db.Employees.Find(EmployeeId);
                        employee.Salary = salary.Amount;
                        db.SaveChanges();
                    }
                    MessageBox.Show("The salary has been updated");
                }
                else
                {
                    if (EmployeeId == 0)
                    {
                        MessageBox.Show("Please select an employee from table");
                    }
                    else
                    {
                        Salary salary = new Salary();
                        salary.EmployeeId = EmployeeId;
                        salary.Amount = Convert.ToInt32(txtSalary.Text);
                        salary.Month = Convert.ToInt32(cmbMonth.SelectedValue);
                        salary.Year = Convert.ToInt32(txtYear.Text);
                        db.Salaries.Add(salary);
                        db.SaveChanges();
                        MessageBox.Show("The salary has been added");
                        EmployeeId = 0;
                        txtName.Clear();
                        txtSurname.Clear();
                        txtSalary.Clear();
                        txtYear.Text = DateTime.Now.Year.ToString();
                        cmbMonth.SelectedIndex = -1;
                        gridEmployee.ItemsSource = employeeList;
                        cmbDepartment.SelectedIndex = -1;
                        cmbPosition.ItemsSource = positions;
                        cmbPosition.SelectedIndex = -1;
                        txtEmployeeNo.Clear();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
