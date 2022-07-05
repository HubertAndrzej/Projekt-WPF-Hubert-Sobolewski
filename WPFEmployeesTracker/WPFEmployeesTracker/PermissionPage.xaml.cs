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

namespace WPFEmployeesTracker
{
    /// <summary>
    /// Interaction logic for PermissionPage.xaml
    /// </summary>
    public partial class PermissionPage : Window
    {
        public PermissionPage()
        {
            InitializeComponent();
        }

        TimeSpan tsPermissionDay = new TimeSpan();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtEmployeeNo.Text = UserStatic.EmployeeNo.ToString();
        }

        private void dpStart_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dpEnd.SelectedDate != null)
            {
                tsPermissionDay = (TimeSpan)(dpEnd.SelectedDate - dpStart.SelectedDate);
                txtDayAmount.Text = tsPermissionDay.TotalDays.ToString();
            }
        }

        private void dpEnd_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dpStart.SelectedDate != null)
            {
                tsPermissionDay = (TimeSpan)(dpEnd.SelectedDate - dpStart.SelectedDate);
                txtDayAmount.Text = tsPermissionDay.TotalDays.ToString();
            }
        }

        EmployeesTrackerContext db = new EmployeesTrackerContext();

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtDayAmount.Text.Trim() == "")
            {
                MessageBox.Show("Please select start and end date");
            }
            else if (Convert.ToInt32(txtDayAmount.Text) <= 0)
            {
                MessageBox.Show("Permission day must be bigger than zero");
            }
            else if (txtExplanation.Text.Trim() == "")
            {
                MessageBox.Show("Please write your permission reason");
            }
            else
            {
                Permission permission = new Permission();
                permission.EmployeeId = UserStatic.EmployeeId;
                permission.EmployeeNo = UserStatic.EmployeeNo;
                permission.PermissionState = Definitions.PermissionStates.OnEmployee;
                permission.PermissionStartDate = dpStart.SelectedDate;
                permission.PermissionEndDate = dpEnd.SelectedDate;
                permission.PermissionAmount = Convert.ToInt32(txtDayAmount.Text);
                permission.PermissionExplanation = txtExplanation.Text;
                db.Permissions.Add(permission);
                db.SaveChanges();
                MessageBox.Show("The permission has been added");
                dpStart.SelectedDate = DateTime.Now;
                dpEnd.SelectedDate = DateTime.Now;
                txtExplanation.Clear();
                txtDayAmount.Clear();
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
