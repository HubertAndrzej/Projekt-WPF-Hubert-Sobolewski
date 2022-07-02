using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WPFEmployeesTracker
{
    /// <summary>
    /// Interaction logic for EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Window
    {
        public EmployeePage()
        {
            InitializeComponent();
        }

        EmployeesTrackerContext db = new EmployeesTrackerContext();
        List<Position> positions = new List<Position>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
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

        OpenFileDialog dialog = new OpenFileDialog();

        private void btnChoose_Click(object sender, RoutedEventArgs e)
        {
            if (dialog.ShowDialog() == true)
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(dialog.FileName);
                image.EndInit();
                EmployeeImage.Source = image;
                txtImage.Text = dialog.FileName;
            }
        }

        private void txtEmployeeNo_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtEmployeeNo.Text.Trim() == "" || txtPassword.Text.Trim() == "" || txtName.Text.Trim() == "" || txtSurname.Text.Trim() == "" || txtSalary.Text.Trim() == "" || cmbDepartment.SelectedIndex == -1 || cmbPosition.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill the mandatory areas");
            }
            else
            {
                var UniqueList = db.Employees.Where(x => x.EmployeeNo == Convert.ToInt32(txtEmployeeNo.Text)).ToList();
                if (UniqueList.Count > 0)
                {
                    MessageBox.Show("This EmployeeNo is already used");
                }
                else
                {
                    Employee employee = new Employee();
                    employee.EmployeeNo = Convert.ToInt32(txtEmployeeNo.Text);
                    employee.Password = txtPassword.Text;
                    employee.Name = txtName.Text;
                    employee.Surname = txtSurname.Text;
                    employee.Salary = Convert.ToInt32(txtSalary.Text);
                    employee.DepartmentId = Convert.ToInt32(cmbDepartment.SelectedValue);
                    employee.PositionId = Convert.ToInt32(cmbPosition.SelectedValue);
                    TextRange text = new TextRange(txtAddress.Document.ContentStart, txtAddress.Document.ContentEnd);
                    employee.Address = text.Text;
                    employee.BirthDay = picker1.SelectedDate;
                    employee.IsAdmin = (bool)chisAdmin.IsChecked;
                    string filename = "";
                    string Unique = Guid.NewGuid().ToString();
                    filename += Unique + dialog.SafeFileName;
                    employee.ImagePath = filename;
                    db.Employees.Add(employee);
                    db.SaveChanges();
                    File.Copy(txtImage.Text, @"images" + filename);
                    MessageBox.Show("The employee has been added");
                    txtEmployeeNo.Clear();
                    txtPassword.Clear();
                    txtName.Clear();
                    txtSurname.Clear();
                    txtSalary.Clear();
                    picker1.SelectedDate = DateTime.Today;
                    cmbDepartment.SelectedIndex = -1;
                    cmbPosition.ItemsSource = positions;
                    cmbPosition.SelectedIndex = -1;
                    txtAddress.Document.Blocks.Clear();
                    chisAdmin.IsChecked = false;
                    EmployeeImage.Source = new BitmapImage();
                    txtImage.Clear();
                }
            }
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            bool isUnique = false;
            var UniqueList = db.Employees.Where(x => x.EmployeeNo == Convert.ToInt32(txtEmployeeNo.Text)).ToList();
            if (UniqueList.Count > 0)
            {
                MessageBox.Show("This EmployeeNo is already used");
            }
            else
            {
                MessageBox.Show("This EmployeeNo is available");
            }
        }
    }
}
