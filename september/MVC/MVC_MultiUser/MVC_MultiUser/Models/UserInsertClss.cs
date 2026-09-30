using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_MultiUser.Models
{
    public class UserInsertClss
    {
        public int uid { set; get; }
        [Required(ErrorMessage = "Enter the Name")]
        public string name { set; get; }
        [Range(18, 50, ErrorMessage = "Enter the Age")]
        public int age { set; get; }

        [Required(ErrorMessage = "Enter the Address")]
        public string address { set; get; }
        [Required(ErrorMessage = "Enter the Phone")]
        [EmailAddress(ErrorMessage = "Enter valid email id")]
        public string email { get; set; }
        public string photo { get; set; }

        public string username { get; set; }
        public string pass { get; set; }
        [Compare("pass", ErrorMessage = "Password Mismatch")]
        public string cpassword { get; set; }
        public string usermsg { get; set; }
    }
}