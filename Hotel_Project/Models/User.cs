using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hotel_Project.Models
{
    public class User
    {
        [Required]
        public String Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public String Password1 { get; set; }

    }
}