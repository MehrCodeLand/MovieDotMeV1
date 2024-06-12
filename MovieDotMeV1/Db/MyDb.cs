using Microsoft.EntityFrameworkCore;
using MovieDotMeV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDotMeV1.Db
{
    public class MyDb : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("server = . ; DataBase = MovieDotMeV1 ; Integrated Security = true ;Trusted_Connection=true;Encrypt=false;Integrated Security=True;TrustServerCertificate=True ;");
    }
}
