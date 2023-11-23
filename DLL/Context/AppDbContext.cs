using DLL.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DLL.Context
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=AppDbContext")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
