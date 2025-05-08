using Microsoft.EntityFrameworkCore;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{

    
        //public class DataBaseUserContext : DbContext

        //{
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Server=ALPEREN;Database=DataBaseUser;Trusted_Connection=True;TrustServerCertificate=True;");
        //    }
        //}
        public class DataBaseUserContext : DbContext
        {
            public DataBaseUserContext(DbContextOptions<DataBaseUserContext> options)
                : base(options)
            {
            }
            public DbSet<AboutDb> AboutDb { get; set; }
            public DbSet<AbilityDb> Abilities { get; set; }
            public DbSet<EducationDb> EducationDb { get; set; }
            public DbSet<ExperienceDb> ExperienceDb { get; set; } 
            public DbSet<HobbyDb> Hobbies { get; set; }
            public DbSet<ContactDb> Contacts { get; set; }
            public DbSet<CertificateDb> Certificates { get; set; }
            public DbSet<AdminDb> AdminDb { get; set; }

        }

}
