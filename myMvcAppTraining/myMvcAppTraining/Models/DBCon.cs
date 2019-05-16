using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace myMvcAppTraining.Models
{
    public class DBCon : DbContext
    {
        public DbSet<Employer> employer { get; set; }
        public DbSet<Company> company { get; set; }
    }
}