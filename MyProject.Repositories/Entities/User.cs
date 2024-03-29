﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public class User
    {
        

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string IdNumber { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string HMO { get; set; }

        public List<Child> Children { get; set; }
    }
}
