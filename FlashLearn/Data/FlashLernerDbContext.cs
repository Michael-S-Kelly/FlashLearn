using FlashLearn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FlashLearn.Data
{
    public class FlashLernerDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<UserCourse> UserCourse { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Course> Course { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserCourse>().HasKey(uc => new { uc.UserID, uc.CourseID });
            modelBuilder.Entity<Question>().HasKey(ui => new { ui.UserID, ui.CourseID, ui.ID });

            
            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    ID = 1,
                    Name = "Anatomy and Physiology"
                }
                );
        }

        public FlashLernerDbContext(DbContextOptions<FlashLernerDbContext> options) : base(options)
        {

        }
    }
}
