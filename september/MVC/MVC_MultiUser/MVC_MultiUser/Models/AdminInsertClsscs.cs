using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_MultiUser.Models
{
    public class AdminInsertClsscs
    {
        [Required(ErrorMessage = "Enter the Name")]
        public string name { set; get; }
        [Required(ErrorMessage = "Enter the Address")]
        public string address { set; get; }
        [Required(ErrorMessage = "Enter the Phone")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Enter Valid Number")]
        public string phone { get; set; }
        [EmailAddress(ErrorMessage = "Enter valid email id")]
        public string email { get; set; }
        public string username { get; set; }
        public string pass { get; set; }
        [Compare("pass", ErrorMessage = "Password Mismatch")]
        public string cpassword { get; set; }
        public string adminmsg { get; set; }
    }
}