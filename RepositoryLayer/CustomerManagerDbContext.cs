using CoreLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class CustomerManagerDbContext: DbContext
    {
        

        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-I0C7C15;Database=StarbucksAndPortalDB;integrated security=true;");

            base.OnConfiguring(optionsBuilder);
        }


    }
}
