using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTOs
{
    public class ChildDTO
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
