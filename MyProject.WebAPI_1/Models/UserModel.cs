using MyProject.Repositories.Entities;

namespace MyProject.WebAPI_1.Models
{
    public enum eHMOModel { macabi, klalit, leumit, meuchedet }
    public enum eGenderModel { male, female }
    public class UserModel
    {
       

        public string FirstName { get; set; }
      public  string TZ { get; set; }
      public  string LastName { get; set; }
       public DateTime DateOfBirth { get; set; }
      public  eHMOModel HMO { get; set; }
     public   eGenderModel Gender { get; set; }
    }
}
