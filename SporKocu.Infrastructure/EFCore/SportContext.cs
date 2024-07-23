using Microsoft.EntityFrameworkCore;
using SporKocu.Domain.Entities;
using SporKocu.Infrastructure.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKocu.Infrastructure.EFCore
{
    public class SportContext : DbContext
    {
        public SportContext(DbContextOptions<SportContext>options):base(options) //ctor
        { 
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //conf. kurallarını burada yazacağız
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new RightConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Answer> Answer { get; set; }
        public DbSet<Blog> Blog { get; set; } 
        public DbSet<Category> Category { get; set; } 
        public DbSet<Exercise> Exercise { get; set; } 
        public DbSet<Food> Food { get; set; } 
        public DbSet<NutritionPlan> NutritionPlan { get; set; } 
        public DbSet<NutritionPlanDetail> NutritionPlanDetail { get; set; } 
        public DbSet<Question> Question { get; set; }
        public DbSet<Right> Right { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<ScheduleLesson> ScheduleLesson { get; set; }
        public DbSet<StudentCoach> StudentCoach { get; set; }
        public DbSet<Unit> Unit { get; set; }
        public DbSet<User> User { get; set; }

    }
}
