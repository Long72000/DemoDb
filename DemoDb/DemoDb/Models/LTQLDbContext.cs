using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoDb.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext() : base("name=LTQLDbContext")
        {
        }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
          .Property(e => e.Username)
          .IsUnicode(false);
        }
    }
}