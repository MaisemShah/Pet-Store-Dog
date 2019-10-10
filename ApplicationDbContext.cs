using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Dog_Pet.Data;

namespace Dog_Pet.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Dog_Pet.Data.Dogs> Dogs { get; set; }
        public DbSet<Dog_Pet.Data.PetStores> PetStores { get; set; }
    }
}
