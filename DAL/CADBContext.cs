using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class CADBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=172.24.12.4;database=cware_cms;port=3306;user=cware_mtc;password=xespat6A;SslMode=none");
        }
        public DbSet<CaseType> CaseTypes { get; set; }
        //public DbSet<ChargeTypeList> ChargeTypes { get; set; }
        public DbSet<CaseList> Cases { get; set; }
        public DbSet<CaseSequence> Sequences { get; set; }
    }
}
