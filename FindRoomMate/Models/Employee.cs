using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FindRoomMate.Models
{
    public class Employee
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name {0} is required")]
        [StringLength(100, MinimumLength = 3,
        ErrorMessage = "Name Should be minimum 3 characters and a maximum of 100 characters")]
        [DataType(DataType.Text)]       
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name {0} is required")]
        [StringLength(100, MinimumLength = 3,
        ErrorMessage = "Last Name Should be minimum 3 characters and a maximum of 100 characters")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "DOB")]
        public string Dob { get; set; }
    }
}