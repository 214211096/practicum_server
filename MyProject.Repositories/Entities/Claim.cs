using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Entities
{
    public enum Policy { Allow, Deny }
    public class Claim
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
        public Policy Policy { get; set; }
    }
}
