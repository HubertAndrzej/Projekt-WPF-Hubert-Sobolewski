using System;
using System.Collections.Generic;
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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        EmployeesTrackerContext db = new EmployeesTrackerContext();

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtEmployeeNo.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the mandatory areas");
            }
            else
            {
                Employee employee = db.Employees.FirstOrDefault(x => x.EmployeeNo == Convert.ToInt32(txtEmployeeNo.Text) && x.Password.Equals(txtPassword.Text));
                if (employee != null && employee.Id != 0)
                {
                    this.Visibility = Visibility.Collapsed;
                    MainWindow main = new MainWindow();
                    UserStatic.EmployeeId = employee.Id;
                    UserStatic.isAdmin = (bool)employee.IsAdmin;
                    UserStatic.EmployeeNo = employee.EmployeeNo;
                    UserStatic.Name = employee.Name;
                    UserStatic.Surname = employee.Surname;
                    main.ShowDialog();
                    txtEmployeeNo.Clear();
                    txtPassword.Clear();
                    this.Visibility = Visibility.Visible;
                }
                else
                {
                    MessageBox.Show("Please make sure that your EmployeeNo and Password are both correct");
                }
            }
        }

        private void txtEmployeeNo_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}
