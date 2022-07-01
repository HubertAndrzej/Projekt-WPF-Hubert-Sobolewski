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
    /// Interaction logic for DepartmentPage.xaml
    /// </summary>
    public partial class DepartmentPage : Window
    {
        public DepartmentPage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtDepartmentName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the department name area");
            }
            else
            {
                using (EmployeesTrackerContext db = new EmployeesTrackerContext())
                {
                    Department dpt = new Department();
                    dpt.DepartmentName = txtDepartmentName.Text;
                    db.Departments.Add(dpt);
                    db.SaveChanges();
                    txtDepartmentName.Clear();
                    MessageBox.Show("The department has been added");
                }
            }
        }
    }
}
