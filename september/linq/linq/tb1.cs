using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace linq
{
    [Table (Name = "tb1")]
    public class tb1
    {
        [Column (IsPrimaryKey = true)]

        public int Id { set; get; }

        [Column]
        public string Name { set; get; }

        [Column]
        public string job { set; get; }

        [Column]
        public decimal salary { set; get; }
    }
}