using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CurveManagement.Models
{
    public class CurveManagementDbContext
    {
        public DbSet<Curve> Curves { get; set; }
    }
}