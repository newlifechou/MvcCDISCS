using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcCDISCS.Models
{
    /// <summary>
    /// CompanyContext
    /// </summary>
    public class CompanyContext : DbContext
    {
        public CompanyContext()
            : base("name=DefaultConnection")
        {

        }
        //set all the dbset
        public DbSet<admin> admins { get; set; }
        public DbSet<basicinfo> basicinfos { get; set; }
        public DbSet<morebasicinfo> morebasicinfos { get; set; }
        public DbSet<flash> flashs { get; set; }
        public DbSet<product> products { get; set; }
        public DbSet<productcategory> productcategorys { get; set; }
        public DbSet<service> services { get; set; }
        public DbSet<news> newss { get; set; }
        public DbSet<feedback> feedbacks { get; set; }
        public DbSet<friendlink> friendlink { get; set; }
        public DbSet<log> logs { get; set; }
        public DbSet<career> careers { get; set; }
        public DbSet<notice> notices { get; set; }

    }
}