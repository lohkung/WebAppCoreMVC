using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCoreMVC.Models
{
    public class PracticesContext : DbContext
    {
        public PracticesContext(DbContextOptions<PracticesContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=practice;Trusted_Connection=True;");
        }

        public virtual DbSet<Order> Orders {get; set;}

        public virtual DbSet<Person> Persons { get; set; }
    }
}
