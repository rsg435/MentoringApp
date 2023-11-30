using MentoringApp.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MentoringApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<University> Universities { get; set; }
        //public DbSet<Student> Students { get; set; }
        //public DbSet<Mentor> Mentors { get; set; }
        public DbSet<ConnectionRequest> ConnectionRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<University>().HasData(
                new University
                {
                    Id = 1,
                    Name = "Sheffield Hallam University",
                    City = "Sheffield"
                },
                new University
                {
                    Id = 2,
                    Name = "The University of Sheffield",
                    City = "Sheffield"
                },
                new University
                {
                    Id = 3,
                    Name = "Leeds Beckett University",
                    City = "Leeds"
                },
                new University
                {
                    Id = 4,
                    Name = "Oxford University",
                    City = "Oxford"
                }
                );

            //modelBuilder.Entity<Student>().HasData(
            //    new Student
            //    {
            //        //Id = 1,
            //        FirstName = "Harry",
            //        LastName = "Smith",
            //        AreaOfStudy = AreaOfStudy.Technology,
            //        CourseName = "MSc Computing",
            //        UniversityId = 1
            //    },
            //    new Student
            //    {
            //        //Id = 2,
            //        FirstName = "Shuying",
            //        LastName = "Jiang",
            //        AreaOfStudy = AreaOfStudy.Technology,
            //        CourseName = "BSc Computer Science",
            //        UniversityId = 1
            //    },
            //    new Student
            //    {
            //        //Id = 3,
            //        FirstName = "Hakeem",
            //        LastName = "Kae-Kazim",
            //        AreaOfStudy = AreaOfStudy.Technology,
            //        CourseName = "MSc Big Data Analytics",
            //        UniversityId = 1
            //    },
            //    new Student
            //    {
            //        //Id = 4,
            //        FirstName = "Priyanka",
            //        LastName = "Chopra",
            //        AreaOfStudy = AreaOfStudy.ArtsAndHumanities,
            //        CourseName = "BA History",
            //        UniversityId = 3
            //    },
            //    new Student
            //    {
            //        //Id = 5,
            //        FirstName = "Robin",
            //        LastName = "Hawthorn",
            //        AreaOfStudy = AreaOfStudy.ArtsAndHumanities,
            //        CourseName = "BA Politics",
            //        UniversityId = 3
            //    },
            //    new Student
            //    {
            //        //Id = 6,
            //        FirstName = "Jun",
            //        LastName = "Matsumoto",
            //        AreaOfStudy = AreaOfStudy.Business,
            //        CourseName = "BSc Management Studies",
            //        UniversityId = 2
            //    },
            //    new Student
            //    {
            //        //Id = 7,
            //        FirstName = "Maria",
            //        LastName = "Spiridakos",
            //        AreaOfStudy = AreaOfStudy.Science,
            //        CourseName = "BSc Zoology",
            //        UniversityId = 2
            //    }
            //);

            //modelBuilder.Entity<Mentor>().HasData(
            //    new Mentor
            //    {
            //        //Id = 8,
            //        FirstName = "Bruno",
            //        LastName = "Silva",
            //        AreaOfStudy = AreaOfStudy.Technology,
            //        CourseName = "MSc Computing",
            //        UniversityId = 1
            //    },
            //    new Mentor
            //    {
            //        //Id = 9,
            //        FirstName = "Claire",
            //        LastName = "Martin",
            //        AreaOfStudy = AreaOfStudy.Technology,
            //        CourseName = "BSc Computer Science for Games",
            //        UniversityId = 1
            //    },
            //    new Mentor
            //    {
            //        //Id = 10,
            //        FirstName = "Min-ho",
            //        LastName = "Lee",
            //        AreaOfStudy = AreaOfStudy.Technology,
            //        CourseName = "BSc Artificial Intelligence",
            //        UniversityId = 2
            //    },
            //    new Mentor
            //    {
            //        //Id = 11,
            //        FirstName = "Olga",
            //        LastName = "Nowak",
            //        AreaOfStudy = AreaOfStudy.CreativeArts,
            //        CourseName = "BA Printmaking",
            //        UniversityId = 3
            //    },
            //    new Mentor
            //    {
            //        //Id = 12,
            //        FirstName = "Qasim",
            //        LastName = "Khan",
            //        AreaOfStudy = AreaOfStudy.Business,
            //        CourseName = "MSc Human Resources",
            //        UniversityId = 2
            //    }
            //);
        }
    }
}
