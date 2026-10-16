using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_DropDown.Models
{
    public class UserInsertClss
    {
        public int sId { get; set; }
        public string sName { get; set; }
        public int dId { get; set; }
        public int dname { get; set; }
        public string sname { get; set; }
        public int sage { get; set; }
        public string sphoto { get; set;  }
        public string msg { get; set; }
    }

    public class stclass
    {
        public int sId { get; set; }
        public string sName { get; set; }

    }

    public class Dclass
    {
        public int dId { get; set; }
        public string dName { get; set; }
    }

    public class UserInsert
    {
        public int sId { get; set; }
        public string sName { get; set; }
        public int dId { get; set; }
    }
}