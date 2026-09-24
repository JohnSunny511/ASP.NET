using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC2Adv.Models
{


    public class stclass
    {
        public int sId { get; set; }
        public string sName { get; set; }

    }

    public class CheckBoxListHelper
    {
        public string Value { get; set; }
        public string Text { get; set; }
        public bool IsChecked { get; set; }

    }
    public class InsertClss
    {

        //Drop Down List
        public int sId { get; set; }
        public string sName { get; set; }

        //CheckBoxList
        public List<CheckBoxListHelper> MyFavQual { get; set; }  //data save and bind CBL        to give data from controller to view
        public string[] selectedQual { get; set; }   //selected qualification save using an array



        [Required(ErrorMessage = "Enter the Name")]
        public string Name { get; set; }
        [Range(18, 50, ErrorMessage = "Age must be between 18 and 50")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Enter the Address")]
        public string Address { get; set; }
        [EmailAddress(ErrorMessage ="Enter valid mail id")]

        [Required(ErrorMessage = "Enter a mail id")]
        public string Email { get; set; }

        public string Photo { get; set; }

        public string Gender { get; set; }

        public string Quali { get; set; }

        public string Username { get; set; }

        public string pwd { get; set; }

        [Compare("pwd", ErrorMessage = "Password Mismatch")]

        public string cpwd { get; set; }
        public string msg { get; set; }

    }
}