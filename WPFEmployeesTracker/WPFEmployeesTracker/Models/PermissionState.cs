using System;
using System.Collections.Generic;

namespace WPFEmployeesTracker.Models
{
    public partial class PermissionState
    {
        public PermissionState()
        {
            Permissions = new HashSet<Permission>();
        }

        public int Id { get; set; }
        public string StateName { get; set; } = null!;

        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
