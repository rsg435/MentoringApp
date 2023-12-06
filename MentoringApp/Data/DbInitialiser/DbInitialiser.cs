using MentoringApp.Data.Enums;
using MentoringApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MentoringApp.Data.DbInitialiser
{
	public class DbInitialiser : IDbInitialiser
	{
		private readonly UserManager<Student> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly ApplicationDbContext _context;

		public DbInitialiser(
			UserManager<Student> userManager,
			RoleManager<IdentityRole> roleManager,
			ApplicationDbContext context)
		{
			_roleManager = roleManager;
			_userManager = userManager;
			_context = context;
		}
		public void Initialise()
		{
			//push migrations if not applied
			try
			{
				if (_context.Database.GetPendingMigrations().Count() > 0)
				{
					_context.Database.Migrate();
				}
			}
			catch (Exception ex)
			{

			}

			//create universities
			if (!_context.Universities.Any(x => x.Name == "Sheffield Hallam University"))
			{
				var uni = new University
				{
					Name = "Sheffield Hallam University",
					City = "Sheffield"
				};
				_context.Universities.Add(uni);
				_context.SaveChanges();
			}

			//create roles if not created
			if (!_roleManager.RoleExistsAsync(Enums.Role.Student.ToString()).GetAwaiter().GetResult())
			{
				_roleManager.CreateAsync(new IdentityRole(Enums.Role.Student.ToString())).GetAwaiter().GetResult();
				_roleManager.CreateAsync(new IdentityRole(Enums.Role.Mentor.ToString())).GetAwaiter().GetResult();

				//create mentors

				_userManager.CreateAsync(new Student
				{
					UserName = "harry@example.com",
					Email = "harry@example.com",
					NormalizedUserName = "HARRY@EXAMPLE.COM",
					NormalizedEmail = "HARRY@EXAMPLE.COM",
					Name = "Harry Smith",
					CourseName = "MSc Computing",
					AreaOfStudy = AreaOfStudy.Technology,
					UniversityId = 1,
					PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true,
					ProfilePictureUrl = "\\images\\user\\male-1.png"
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
					UserName = "jiang@example.com",
					Email = "jiang@example.com",
					NormalizedEmail = "JIANG@EXAMPLE.COM",
					NormalizedUserName = "JIANG@EXAMPLE.COM",
					Name = "Shuying Jiang",
					CourseName = "BSc Computer Science",
					AreaOfStudy = AreaOfStudy.Technology,
					UniversityId = 1,
					PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true,
                    ProfilePictureUrl = "\\images\\user\\male-2.png"
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
					UserName = "hakeem@example.com",
					Email = "hakeem@example.com",
					NormalizedEmail = "HAKEEM@EXAMPLE.COM",
					NormalizedUserName = "HAKEEM@EXAMPLE.COM",
					Name = "Hakeem Kae-Kazim",
					CourseName = "MSc Big Data Analytics",
					AreaOfStudy = AreaOfStudy.Technology,
					UniversityId = 1,
					PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true,
                    ProfilePictureUrl = "\\images\\user\\male-3.png"
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
					UserName = "priyanka@example.com",
					Email = "priyanka@example.com",
					NormalizedEmail = "PRIYANKA@EXAMPLE.COM",
					NormalizedUserName = "PRIYANKA@EXAMPLE.COM",
					Name = "Priyanka Chopra",
					CourseName = "BSc Computer Science For Games",
					AreaOfStudy = AreaOfStudy.Technology,
					UniversityId = 1,
					PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true,
                    ProfilePictureUrl = "\\images\\user\\female-4.png"
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
					UserName = "robin@example.com",
					Email = "robin@example.com",
					NormalizedEmail = "ROBIN@EXAMPLE.COM",
					NormalizedUserName = "ROBIN@EXAMPLE.COM",
					Name = "Robin Hawthorn",
					CourseName = "BA Politics",
					AreaOfStudy = AreaOfStudy.ArtsAndHumanities,
					UniversityId = 1,
					PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true,
                    ProfilePictureUrl = "\\images\\user\\female-3.png"
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
					UserName = "jun@example.com",
					Email = "jun@example.com",
					NormalizedEmail = "JUN@EXAMPLE.COM",
					NormalizedUserName = "JUN@EXAMPLE.COM",
					Name = "Jun Matsumoto",
					CourseName = "BSc Management Studies",
					AreaOfStudy = AreaOfStudy.Business,
					UniversityId = 1,
					PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true,
                    ProfilePictureUrl = "\\images\\user\\male-2.png"
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
					UserName = "maria@example.com",
					Email = "maria@example.com",
					NormalizedEmail = "MARIA@EXAMPLE.COM",
					NormalizedUserName = "MARIA@EXAMPLE.COM",
					Name = "Maria Spiridakos",
					CourseName = "BSc Zoology",
					AreaOfStudy = AreaOfStudy.Science,
					UniversityId = 1,
					PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true,
                    ProfilePictureUrl = "\\images\\user\\female-1.png"
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
					UserName = "john@example.com",
					Email = "john@example.com",
					NormalizedEmail = "JOHN@EXAMPLE.COM",
					NormalizedUserName = "JOHN@EXAMPLE.COM",
					Name = "John Doe",
					CourseName = "MSc Business Analytics",
					AreaOfStudy = AreaOfStudy.Business,
					UniversityId = 1,
					PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true,
                    ProfilePictureUrl = "\\images\\user\\male-4.png"
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
					UserName = "emily@example.com",
					Email = "emily@example.com",
					NormalizedEmail = "EMILY@EXAMPLE.COM",
					NormalizedUserName = "EMILY@EXAMPLE.COM",
					Name = "Emily White",
					CourseName = "BSc Chemistry",
					AreaOfStudy = AreaOfStudy.Science,
					UniversityId = 1,
					PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true,
                    ProfilePictureUrl = "\\images\\user\\female-1.png"
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
					UserName = "bruno@example.com",
					Email = "bruno@example.com",
					NormalizedEmail = "BRUNO@EXAMPLE.COM",
					NormalizedUserName = "BRUNO@EXAMPLE.COM",
					Name = "Bruno Silva",
					CourseName = "Medicine",
					AreaOfStudy = AreaOfStudy.Health,
					UniversityId = 1,
					PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true,
                    ProfilePictureUrl = "\\images\\user\\male-3.png"
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
					UserName = "claire@example.com",
					Email = "emily@example.com",
					NormalizedEmail = "CLAIRE@EXAMPLE.COM",
					NormalizedUserName = "CLAIRE@EXAMPLE.COM",
					Name = "Claire Martin",
					CourseName = "BA History",
					AreaOfStudy = AreaOfStudy.ArtsAndHumanities,
					UniversityId = 1,
					PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true,
                    ProfilePictureUrl = "\\images\\user\\female-1.png"
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
					UserName = "qasim@example.com",
					Email = "qasim@example.com",
					NormalizedEmail = "QASIM@EXAMPLE.COM",
					NormalizedUserName = "QASIM@EXAMPLE.COM",
					Name = "Qasim Khan",
					CourseName = "Nursing",
					AreaOfStudy = AreaOfStudy.Health,
					UniversityId = 1,
					PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true,
                    ProfilePictureUrl = "\\images\\user\\male-3.png"
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
					UserName = "minho@example.com",
					Email = "minho@example.com",
					NormalizedEmail = "MINHO@EXAMPLE.COM",
					NormalizedUserName = "MINHO@EXAMPLE.COM",
					Name = "Min-ho Lee",
					CourseName = "MSc Human Resources",
					AreaOfStudy = AreaOfStudy.Business,
					UniversityId = 1,
					PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true,
                    ProfilePictureUrl = "\\images\\user\\male-2.png"
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
					UserName = "olga@example.com",
					Email = "olga@example.com",
					NormalizedEmail = "OLGA@EXAMPLE.COM",
					NormalizedUserName = "OLGA@EXAMPLE.COM",
					Name = "Olga Nowak",
					CourseName = "BA Printmaking",
					AreaOfStudy = AreaOfStudy.CreativeArts,
					UniversityId = 1,
					PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true,
                    ProfilePictureUrl = "\\images\\user\\female-3.png"
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				var users = _context.Students.ToList();

				foreach (var user in users)
				{
					_userManager.AddToRoleAsync(user, Enums.Role.Mentor.ToString()).GetAwaiter().GetResult();
				}
			}
			return;
			
		}
	}
}
