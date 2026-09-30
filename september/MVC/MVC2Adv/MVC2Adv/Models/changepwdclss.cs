using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC2Adv.Models
{
    public class changepwdclss
    {
        public string oldpassword { get; set; }
        [Required(ErrorMessage ="Enter the password")]
        public string newpassword { get; set; }
        [Compare("newpassword",ErrorMessage ="Password Mismatch")]
        public string confirmpassword { get; set; }
        public string msg { set; get; }
    }
}