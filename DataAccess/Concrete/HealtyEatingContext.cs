using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class HealtyEatingContext : DbContext
    { 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;database=HealtyEating;Trusted_Connection=true");
        }

        public DbSet<Account> TblAccounts { get; set; }
        public DbSet<Diet> tblDiets { get; set; }
        public DbSet<Patient> tblPatients { get; set; }

        public DbSet<illness> tblillness { get; set; }
        public DbSet<User> tblUsers { get; set; }
        public DbSet<UserType> tblUserTypes { get; set; }
        public DbSet<DietCalendar> tblDietCalendar { get; set; }





    }
}
