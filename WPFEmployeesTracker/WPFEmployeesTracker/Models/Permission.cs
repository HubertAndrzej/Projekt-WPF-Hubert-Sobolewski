using System;
using System.Collections.Generic;

namespace WPFEmployeesTracker.Models
{
    public partial class Permission
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int EmployeeNo { get; set; }
        public DateTime? PermissionStartDate { get; set; }
        public DateTime? PermissionEndDate { get; set; }
        public int PermissionState { get; set; }
        public string PermissionExplanation { get; set; }
        public int PermissionAmount { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual PermissionState PermissionStateNavigation { get; set; } = null!;
    }
}
