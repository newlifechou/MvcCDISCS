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
            : base("name=cdiscs")
        {

        }
        //set all the dbset
        public DbSet<admin> admin { get; set; }
        public DbSet<basicinfo> basicinfo { get; set; }
        public DbSet<morebasicinfo> morebasicinfo { get; set; }
        public DbSet<flash> flash { get; set; }
        public DbSet<product> product { get; set; }
        public DbSet<productcategory> productcategory { get; set; }
        public DbSet<service> service { get; set; }
        public DbSet<news> news { get; set; }
        public DbSet<feedback> feedback { get; set; }
        public DbSet<friendlink> friendlink { get; set; }
        public DbSet<log> log{ get; set; }
        public DbSet<career> career { get; set; }
        public DbSet<notice> notice { get; set; }

    }
}