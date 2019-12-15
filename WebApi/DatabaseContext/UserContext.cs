using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseContext
{
     public class UserContext:DbContext
    {
        public UserContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<User> users { get; set; }
    }
}
