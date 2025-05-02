using Microsoft.EntityFrameworkCore;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Context
{
    public class DataBaseUserContext:DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=ALPEREN;Database=DataBaseUser;Trusted_Connection=True;");
            }
        }
        public DbSet<Ability> Abilities { get; set; }



    }
}
