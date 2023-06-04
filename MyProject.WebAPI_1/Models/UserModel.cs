using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;

namespace MyProject.WebAPI_1.Models
{
    public enum eHMOModel { macabi, klalit, leumit, meuchedet }
    public enum eGenderModel { male, female }
    public class UserModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string IdNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public string Gender { get; set; }

        public string HMO { get; set; }

        public List<ChildDTO> Children { get; set; }
    }
}
