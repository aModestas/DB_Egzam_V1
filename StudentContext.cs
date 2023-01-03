using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Egzam_V1
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=OMEN\\SQLEXPRESS;Database=DB_Egzam_V1;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True");
        }
    }
}
