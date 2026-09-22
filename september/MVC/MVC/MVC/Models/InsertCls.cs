using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class InsertCls
    {

        [Required(ErrorMessage ="Enter the name")]
        public string Name { set; get; }

        [Range(20,60,ErrorMessage ="Enter valid mail id")]
        public int Age { set; get; }
        [EmailAddress(ErrorMessage ="Enter valid mail id")]

        public string Email { set; get; }

        public string msg { set; get; }
    }
}