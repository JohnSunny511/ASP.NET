using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_MultiUser.Models
{
    public class loginclss
    {
        [Required(ErrorMessage ="Enter the user name")]
        public string uname { set; get; }
        [Required(ErrorMessage = "Enter the Password")]
        public string password { set; get; }
        public string msg { set; get; }

    }
}