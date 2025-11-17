using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcmultireg.Models
{
    public class UserInsert
    {
        public int uid { set; get; }
        [Required(ErrorMessage = "Enter the name")]

        public string name { set; get; }
        [Range(18, 50, ErrorMessage = "Enter the age")]

        public int age { set; get; }
        [Required(ErrorMessage = "Enter the address")]

        public string address { get; set; }
        [EmailAddress(ErrorMessage = "Enter valid email id")]

        public string email { get; set; }

        public string photo { get; set; }

        public string username { get; set; }

        public string password { get; set; }
        [Compare("password", ErrorMessage = "Password mismatch")]

        public string cpassword { get; set; }

        public string usermsg { get; set; }
    }
}