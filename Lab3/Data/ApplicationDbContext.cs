using System;
using System.Collections.Generic;
using System.Text;
using Lab3.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<City> City { get; set; }
        public DbSet<Province> Province { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
