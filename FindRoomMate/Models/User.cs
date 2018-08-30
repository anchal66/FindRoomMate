using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FindRoomMate.Models
{
    public class User
    {
        [Display(Name = "Enter username")]
        [Required(ErrorMessage = "Enter UserName")]
        [StringLength(15, ErrorMessage = "Max 15 characters")]
        public int UserId { get; set; }

        [Display(Name = "Enter your Email Id")]
        [Required(ErrorMessage = "Enter Email")]
        [RegularExpression(".+@.+\\..+", ErrorMessage = "Email format Invalid")]
        [StringLength(30)]
        public string UserEmail { get; set; }

        [Display(Name = "Enter Password")]
        [Required(ErrorMessage = "Enter Password")]
        public string UserPass { get; set; }

        [Display(Name = "Re-enter Password")]
        [Required(ErrorMessage = "Re-type Password")]
        [Compare("UserPass", ErrorMessage = "Password didn't match")]
        public string UserRePass { get; set; }

        [Display(Name = "Enter Your/Organisation Name")]
        [Required(ErrorMessage = "Enter Name")]
        [StringLength(30, ErrorMessage = "Max 30 characters")]
        public string UserName { get; set; }

        [Display(Name = "Place")]
        public string UserAddress { get; set; }

        [Display(Name = "Area")]
        [Required(ErrorMessage = "Enter Area")]
        [StringLength(30, ErrorMessage = "Max 30 characters")]
        public string UserPermanentAddress { get; set; }

        [Display(Name = "Enter Conatact No.")]
        [Required(ErrorMessage = "Enter Mobile No.")]
        [StringLength(11, ErrorMessage = "Max 10 characters")]
        public long UserNumer1 { get; set; }

        [Display(Name = "Enter Alternative Contact No.")]
        public long UserNumber2 { get; set; }

        public int BrokerRating { get; set; }

        public DateTime BrokerdateTime { get; set; }
    }
}