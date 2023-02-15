using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTOs
{
    public enum eHMODTO { macabi, klalit, leumi, meuchedet }
    public enum eGenderDTO { male, female }
    public class UserDTO
    {
        
         
          public  int UserId { get; set; }
        public    string FirstName { get; set; }
        public    string TZ { get; set; }
         public    string LastName { get; set; }
         public   DateTime DateOfBirth { get; set; }
         public   eHMODTO HMO { get; set; }
         public   eGenderDTO Gender { get; set; }
        
    }
}
