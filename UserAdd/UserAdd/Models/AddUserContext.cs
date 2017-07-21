using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace UserAdd.Models
{
    public class AddUserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AddUserContext()
        {
            // Disable the database initializer in favor of using Code First Migrations.
            Database.SetInitializer<AddUserContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Removing the pluralizing table name convention 
            // so our table names will use our entity class singular names.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}