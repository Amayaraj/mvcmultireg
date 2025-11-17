using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcmultireg.Models
{
    public class Logincls
    {
        [Required(ErrorMessage = "Enter the user name")]
        public string username { set; get; }

        [Required(ErrorMessage = "Enter the password")]
        public string password { set; get; }

        public string msg { set; get; }


    }
}