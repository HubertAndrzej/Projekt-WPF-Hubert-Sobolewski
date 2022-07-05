using System;
using System.Collections.Generic;

namespace WPFEmployeesTracker.Models
{
    public partial class SalaryMonth
    {
        public SalaryMonth()
        {
            Salaries = new HashSet<Salary>();
        }

        public int Id { get; set; }
        public string MonthName { get; set; } = null!;

        public virtual ICollection<Salary> Salaries { get; set; }
    }
}
