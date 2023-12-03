using MentoringApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MentoringApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<Student>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<University> Universities { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<ConnectionRequest> ConnectionRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>()
                .HasOne(u => u.Mentor)
                .WithMany(m => m.Mentees)
                .HasForeignKey(u => u.MentorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ConnectionRequest>()
                .HasOne(cr => cr.Student)
                .WithMany(u => u.SentConnectionRequests)
                .HasForeignKey(cr => cr.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ConnectionRequest>()
                .HasOne(cr => cr.Mentor)
                .WithMany(u => u.ReceivedConnectionRequests)
                .HasForeignKey(cr => cr.MentorId)
                .OnDelete(DeleteBehavior.Restrict);

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

            var hasher = new PasswordHasher<Student>();

            modelBuilder.Entity<Student>().HasData(

               new Student
               {
                    Id = "1",
                    UserName = "harry@example.com",
                    Email = "harry@example.com",
                    NormalizedUserName = "HARRY@EXAMPLE.COM",
				    NormalizedEmail = "HARRY@EXAMPLE.COM",
				    Name = "Harry Smith",
                    CourseName = "MSc Computing",
                    AreaOfStudy = AreaOfStudy.Technology,
                    UniversityId = 1,
                    Role = UserRole.Student,
                    PasswordHash = hasher.HashPassword(null, "X32G#ILcWi^d5^P!"),
                    PhoneNumber = "1234567890",
                    PhoneNumberConfirmed = true
               },
                new Student
                {
                    Id = "2",
                    UserName = "jiang@example.com",
                    Email = "jiang@example.com",
                    NormalizedEmail = "JIANG@EXAMPLE.COM",
                    NormalizedUserName = "JIANG@EXAMPLE.COM",
                    Name = "Shuying Jiang",
                    CourseName = "BSc Computer Science",
                    AreaOfStudy = AreaOfStudy.Technology,
                    UniversityId = 1,
                    Role = UserRole.Student,
                    PasswordHash = hasher.HashPassword(null, "X32G#ILcWi^d5^P!"),
                    PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true
				},
                new Student
                {
                    Id = "3",
                    UserName = "hakeem@example.com",
                    Email = "hakeem@example.com",
					NormalizedEmail = "HAKEEM@EXAMPLE.COM",
					NormalizedUserName = "HAKEEM@EXAMPLE.COM",
					Name = "Hakeem Kae-Kazim",
                    CourseName = "MSc Big Data Analytics",
                    AreaOfStudy = AreaOfStudy.Technology,
                    UniversityId = 1,
                    Role = UserRole.Student,
                    PasswordHash = hasher.HashPassword(null, "X32G#ILcWi^d5^P!"),
                    PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true
				},
                new Student
                {
                    Id = "4",
                    UserName = "priyanka@example.com",
                    Email = "priyanka@example.com",
					NormalizedEmail = "PRIYANKA@EXAMPLE.COM",
					NormalizedUserName = "PRIYANKA@EXAMPLE.COM",
					Name = "Priyanka Chopra",
                    CourseName = "BA History",
                    AreaOfStudy = AreaOfStudy.ArtsAndHumanities,
                    UniversityId = 3,
                    Role = UserRole.Student,
                    PasswordHash = hasher.HashPassword(null, "temporarypass"),
                    PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true
				},
                new Student
                {
                    Id = "5",
                    UserName = "robin@example.com",
                    Email = "robin@example.com",
					NormalizedEmail = "ROBIN@EXAMPLE.COM",
					NormalizedUserName = "ROBIN@EXAMPLE.COM",
					Name = "Robin Hawthorn",
                    CourseName = "BA Politics",
                    AreaOfStudy = AreaOfStudy.ArtsAndHumanities,
                    UniversityId = 3,
                    Role = UserRole.Student,
                    PasswordHash = hasher.HashPassword(null, "X32G#ILcWi^d5^P!"),
                    PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true
				},
                new Student
                {
                    Id = "6",
                    UserName = "jun@example.com",
                    Email = "jun@example.com",
					NormalizedEmail = "JUN@EXAMPLE.COM",
					NormalizedUserName = "JUN@EXAMPLE.COM",
					Name = "Jun Matsumoto",
                    CourseName = "BSc Management Studies",
                    AreaOfStudy = AreaOfStudy.Business,
                    UniversityId = 2,
                    Role = UserRole.Student,
                    PasswordHash = hasher.HashPassword(null, "X32G#ILcWi^d5^P!"),
                    PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true
				},
                new Student
                {
                    Id = "7",
                    UserName = "maria@example.com",
                    Email = "maria@example.com",
					NormalizedEmail = "MARIA@EXAMPLE.COM",
					NormalizedUserName = "MARIA@EXAMPLE.COM",
					Name = "Maria Spiridakos",
                    CourseName = "BSc Zoology",
                    AreaOfStudy = AreaOfStudy.Science,
                    UniversityId = 2,
                    Role = UserRole.Student,
                    PasswordHash = hasher.HashPassword(null, "X32G#ILcWi^d5^P!"),
                    PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true
				},
                new Student
                {
                    Id = "8",
                    UserName = "john@example.com",
                    Email = "john@example.com",
					NormalizedEmail = "JOHN@EXAMPLE.COM",
					NormalizedUserName = "JOHN@EXAMPLE.COM",
					Name = "John Doe",
                    CourseName = "MSc Business Analytics",
                    AreaOfStudy = AreaOfStudy.Business,
                    UniversityId = 1,
                    Role = UserRole.Student,
                    PasswordHash = hasher.HashPassword(null, "X32G#ILcWi^d5^P!"),
                    PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true
				},
                new Student
                {
                    Id = "9",
                    UserName = "emily@example.com",
                    Email = "emily@example.com",
					NormalizedEmail = "EMILY@EXAMPLE.COM",
					NormalizedUserName = "EMILY@EXAMPLE.COM",
					Name = "Emily White",
                    CourseName = "BSc Chemistry",
                    AreaOfStudy = AreaOfStudy.Science,
                    UniversityId = 2,
                    Role = UserRole.Student,
                    PasswordHash = hasher.HashPassword(null, "X32G#ILcWi^d5^P!"),
                    PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true
				},
                 new Student
                 {
                     Id = "10",
                     UserName = "bruno@example.com",
                     Email = "bruno@example.com",
					 NormalizedEmail = "BRUNO@EXAMPLE.COM",
					 NormalizedUserName = "BRUNO@EXAMPLE.COM",
					 Name = "Bruno Silva",
                     CourseName = "MSc IT Management",
                     AreaOfStudy = AreaOfStudy.Technology,
                     UniversityId = 1,
                     Role = UserRole.Mentor,
                     PasswordHash = hasher.HashPassword(null, "X32G#ILcWi^d5^P!"),
                     PhoneNumber = "1234567890",
					 PhoneNumberConfirmed = true
				 },
                 new Student
                 {
                     Id = "11",
                     UserName = "claire@example.com",
                     Email = "emily@example.com",
					 NormalizedEmail = "CLAIRE@EXAMPLE.COM",
					 NormalizedUserName = "CLAIRE@EXAMPLE.COM",
					 Name = "Claire Martin",
                     CourseName = "BSc Computer Science for Games",
                     AreaOfStudy = AreaOfStudy.Technology,
                     UniversityId = 1,
                     Role = UserRole.Mentor,
                     PasswordHash = hasher.HashPassword(null, "X32G#ILcWi^d5^P!"),
                     PhoneNumber = "1234567890",
					 PhoneNumberConfirmed = true
				 },
                 new Student
                 {
                     Id = "12",
                     UserName = "qasim@example.com",
                     Email = "qasim@example.com",
					 NormalizedEmail = "QASIM@EXAMPLE.COM",
					 NormalizedUserName = "QASIM@EXAMPLE.COM",
					 Name = "Qasim Khan",
                     CourseName = "BSc Artificial Intelligence",
                     AreaOfStudy = AreaOfStudy.Technology,
                     UniversityId = 2,
                     Role = UserRole.Mentor,
                     PasswordHash = hasher.HashPassword(null, "X32G#ILcWi^d5^P!"),
                     PhoneNumber = "1234567890",
					 PhoneNumberConfirmed = true
				 },
                 new Student
                 {
                     Id = "13",
                     UserName = "minho@example.com",
                     Email = "minho@example.com",
					 NormalizedEmail = "MINHO@EXAMPLE.COM",
					 NormalizedUserName = "MINHO@EXAMPLE.COM",
					 Name = "Min-ho Lee",
                     CourseName = "BSc Chemistry",
                     AreaOfStudy = AreaOfStudy.Business,
                     UniversityId = 2,
                     Role = UserRole.Mentor,
                     PasswordHash = hasher.HashPassword(null, "X32G#ILcWi^d5^P!"),
                     PhoneNumber = "1234567890",
					 PhoneNumberConfirmed = true
				 },
                 new Student
                 {
                     Id = "14",
                     UserName = "olga@example.com",
                     Email = "olga@example.com",
					 NormalizedEmail = "OLGA@EXAMPLE.COM",
					 NormalizedUserName = "OLGA@EXAMPLE.COM",
					 Name = "Olga Nowak",
                     CourseName = "BA Printmaking",
                     AreaOfStudy = AreaOfStudy.CreativeArts,
                     UniversityId = 3,
                     Role = UserRole.Mentor,
                     PasswordHash = hasher.HashPassword(null, "X32G#ILcWi^d5^P!"),
                     PhoneNumber = "1234567890",
					 PhoneNumberConfirmed = true
				 }
                );
        }
    }
}
