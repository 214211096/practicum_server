using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTOs
{
    public class ChildDTO
    {
        public int ChildId { get; set; }
        public string TZ { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [ForeignKey("Parent")]
        public int ParentId { get; set; }
        //public UserDTO Parent { get; set; }
    }
}
