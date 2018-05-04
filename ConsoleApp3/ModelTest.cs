using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp3
{
    public class CADBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySQL("server=localhost;database=sakila;port=3306;user=root;password=Password1;SslMode=none");
            optionsBuilder.UseMySQL("server=172.24.12.4;database=cware_cms;port=3306;user=cware_mtc;password=xespat6A;SslMode=none");
        }
        //public DbSet<actor> actor { get; set; }
        public DbSet<CaseTypeList> CaseTypes { get; set; }
        //public DbSet<ChargeTypeList> ChargeTypes { get; set; }
        public DbSet<CaseList> Cases { get; set; }
        public DbSet<CaseSequenceList> Sequences { get; set; }
    }
    public class SakilaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=sakila;port=3306;user=root;password=Password1;SslMode=none");
        }
        public DbSet<actor> actor { get; set; }
    }
    public class actor
    {
        [Key]
        public int actor_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime last_update { get; set; }
    }

}
