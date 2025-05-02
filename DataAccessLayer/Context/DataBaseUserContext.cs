using Microsoft.EntityFrameworkCore;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{

    
        public class DataBaseUserContext : DbContext

        {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Server=ALPEREN;Database=DataBaseUser;Trusted_Connection=True;");
                }
            }
            public DbSet<About> Abouts { get; set; }
            public DbSet<Ability> Abilities { get; set; }
            public DbSet<Education> Educations { get; set; }
            public DbSet<Experience> Experiences { get; set; }
            public DbSet<Hobby> Hobbies { get; set; }
            public DbSet<Contact> Contacts { get; set; }
            public DbSet<Certificate> Certificates { get; set; }
            public DbSet<Admin> Admins { get; set; }

        }
    }
