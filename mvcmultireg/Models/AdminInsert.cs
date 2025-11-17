using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcmultireg.Models
{
    public class AdminInsert
    {
        [Required(ErrorMessage = "Enter the name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Enter the address")]
        public string address { get; set; }

        [Required(ErrorMessage = "Enter the Phone")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Enter valid phone number")]
        public string phone { get; set; }

        [EmailAddress(ErrorMessage = "Enter valid email id")]
        public string email { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        [Compare("password", ErrorMessage = "Password mismatch")]
        public string cpassword { get; set; }

        public string adminmsg { get; set; }
    }
}