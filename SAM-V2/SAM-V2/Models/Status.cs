using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SAM_V2.Models
{
    public class Status
    {
        [Key]
        public string StatusID { get; set; }
        public string StatusName { get; set; }
    }
}