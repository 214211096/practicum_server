using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public enum eHMO { macabi, klalit, leumit, meuchedet }
    public enum eGender { male, female }
    public class User
    {
        [Key]
        public  int UserId { get; set; }
        public string FirstName { get; set; }
        public string TZ { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public eHMO HMO { get; set; }
        public eGender Gender { get; set; }
    }
}
