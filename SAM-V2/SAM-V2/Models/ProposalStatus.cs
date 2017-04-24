using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SAM_V2.Models
{
    public class ProposalStatus
    {
        [Key]
        [Column(Order = 0)]
        public string DocNo { get; set; }
        [Key]
        [Column(Order = 1)]
        public string StatusID { get; set; }
        public string PropStatus { get; set; }
    }
}