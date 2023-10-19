using AutoMapperDemo.WebAPI.Configuration;
using AutoMapperDemo.WebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace AutoMapperDemo.WebAPI
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentModelConfiguration());
        }
    }
}
