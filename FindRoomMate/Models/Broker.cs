using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FindRoomMate.Models
{
    public class Broker
    {
        [Display(Name ="Enter username")]
        [Required (ErrorMessage ="Enter UserName")]
        [StringLength(15, ErrorMessage ="Max 15 characters")]
        public int BrokerId { get; set; }

        [Display(Name = "Enter your Email Id")]
        [Required(ErrorMessage = "Enter Email")]
        [RegularExpression(".+@.+\\..+", ErrorMessage ="Email format Invalid")]
        [StringLength(30)]
        public string BrokerEmail { get; set; }

        [Display(Name = "Enter Password")]
        [Required(ErrorMessage = "Enter Password")]
        public string BrokerPass { get; set; }

        [Display(Name = "Re-enter Password")]
        [Required(ErrorMessage = "Re-type Password")]
        [Compare("BrokerPass", ErrorMessage ="Password didn't match")]
        public string BrokerRePass { get; set; }

        [Display(Name = "Enter Your/Organisation Name")]
        [Required(ErrorMessage = "Enter Name")]
        [StringLength(30, ErrorMessage = "Max 30 characters")]
        public string BrokerName { get; set; }

        [Display(Name = "Place")]
        public string BrokerPlace { get; set; }

        [Display(Name = "Area")]
        [Required(ErrorMessage = "Enter Area")]
        [StringLength(30, ErrorMessage = "Max 30 characters")]
        public string BrokerArea { get; set; }

        [Display(Name = "City/ District")]
        [Required(ErrorMessage = "Enter City")]
        [StringLength(30, ErrorMessage = "Max 30 characters")]
        public string BrokerCity { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "Enter State")]
        [StringLength(15, ErrorMessage = "Max 15 characters")]
        public string BrokerState { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Enter Country")]
        [StringLength(15, ErrorMessage = "Max 15 characters")]
        public string BrokerCountry { get; set; }

        [Display(Name = "Enter Conatact No.")]
        [Required(ErrorMessage = "Enter Mobile No.")]
        [StringLength(11, ErrorMessage = "Max 10 characters")]
        public long BrokerNumber1{ get; set; }

        [Display(Name = "Enter Alternative Contact No.")]
        public long BrokerNumber2 { get; set; }

        public int BrokerPoints { get; set; }

        public int BrokerRating { get; set; }

        public int BrokerVeiws { get; set; }

        public DateTime BrokerdateTime { get; set; }
    }
}