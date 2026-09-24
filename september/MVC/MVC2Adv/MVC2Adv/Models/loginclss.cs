using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC2Adv.Models
{
    public class loginclss
    {
        [Required(ErrorMessage ="Enter the username")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Enter the password")]
        public string pwd { get; set; }
        public string msg { get; set; }

    }
}