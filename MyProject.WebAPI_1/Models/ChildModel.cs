using MyProject.Repositories.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.WebAPI_1.Models
{
    public class ChildModel
    {
        
        public string TZ { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ParentId { get; set; }
    }
}
