using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Common.DTOs
{
    public enum Policy { Allow, Deny }

    public class ClaimDTO
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
        public Policy PolicyType { get; set; }
    }
}
