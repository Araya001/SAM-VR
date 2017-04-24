using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SAM_V2.Models
{
    public class SAM_V2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SAM_V2Context() : base("name=SAM_V2Context")
        {
        }

        public System.Data.Entity.DbSet<SAM_V2.Models.Approvers> Approvers { get; set; }

        public System.Data.Entity.DbSet<SAM_V2.Models.Organizations> Organizations { get; set; }

        public System.Data.Entity.DbSet<SAM_V2.Models.Proposal> Proposals { get; set; }

        public System.Data.Entity.DbSet<SAM_V2.Models.ProposalStatus> ProposalStatus { get; set; }

        public System.Data.Entity.DbSet<SAM_V2.Models.Staff> Staffs { get; set; }

        public System.Data.Entity.DbSet<SAM_V2.Models.Status> Status { get; set; }

        public System.Data.Entity.DbSet<SAM_V2.Models.Users> Users { get; set; }
    }
}
