using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace E_LearningDAL.Data.Context
{
    public class E_LearningAppContext : DbContext
    {
        public DbSet<Student> Students => Set<Student>();
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Module> Modules => Set<Module>();        
        public DbSet<Lesson> lessons => Set<Lesson>(); 
        //public DbSet<Progress> Progresses => Set<Progress>();   
        public DbSet<Quiz> Quizes => Set<Quiz>();
        public DbSet<Enrollment> Enrollments => Set<Enrollment>();
        public DbSet<Instractor> Instractors => Set<Instractor>();
        public DbSet<Certificate> Certificates => Set<Certificate>();
        public DbSet<StudentQuizes> StudentsQuizes => Set<StudentQuizes>();

        public E_LearningAppContext(DbContextOptions options) : base (options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);

           // modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

    }
}
