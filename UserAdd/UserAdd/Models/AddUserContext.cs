using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

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
    }
}