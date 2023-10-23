using LocalDBWebApiUsingEF.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalDBWebApiUsingEF.Data
{
    public class DBManager : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Students.db;");
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Student> students = new List<Student>();
            Student student = new Student();
            student.Id = 1;
            student.Name = "Sajib";
            student.Age = 20;
            students.Add(student);

            student = new Student();
            student.Id = 2;
            student.Name = "Mistry";
            student.Age = 30;
            students.Add(student);

            student = new Student();
            student.Id = 3;
            student.Name = "Mike";
            student.Age = 40;
            students.Add(student);
            modelBuilder.Entity<Student>().HasData(students);
        }
    }
}
