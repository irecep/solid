using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
namespace solid.Models
{
    public class ShoppingContext:DbContext
    {

        public ShoppingContext()
        {
        }

        public ShoppingContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
