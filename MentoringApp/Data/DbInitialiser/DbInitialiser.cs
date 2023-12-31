﻿using MentoringApp.Data.Enums;
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
					Id = "1",
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
					ProfilePictureUrl = "\\images\\user\\male-1.png",
					IntroductionMessage = "Hi. I can help you with studying and finding your way around. Please send me a request."
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
                    Id = "2",
                    UserName = "shuying@example.com",
					Email = "shuying@example.com",
					NormalizedEmail = "JIANG@EXAMPLE.COM",
					NormalizedUserName = "JIANG@EXAMPLE.COM",
					Name = "Shuying Jiang",
					CourseName = "BSc Computer Science",
					AreaOfStudy = AreaOfStudy.Technology,
					UniversityId = 1,
					PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true,
                    ProfilePictureUrl = "\\images\\user\\male-2.png",
                    IntroductionMessage = "Hi. I'm a 3rd year Computer Science student, if you're struggling with coding send me a connection request."
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
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
					PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true,
                    ProfilePictureUrl = "\\images\\user\\male-3.png",
                    IntroductionMessage = "hi, happy to help out with anything you need"
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
					Id = "4",
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
                    ProfilePictureUrl = "\\images\\user\\female-2.png",
                    IntroductionMessage = "Friendly 2nd year student offering to be a mentor, I am an international student from India. I love video games and technology."
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
					Id = "5",
					UserName = "robin@example.com",
					Email = "robin@example.com",
					NormalizedEmail = "ROBIN@EXAMPLE.COM",
					NormalizedUserName = "ROBIN@EXAMPLE.COM",
					Name = "Robin Hawthorn",
					CourseName = "BSc Data Science",
					AreaOfStudy = AreaOfStudy.Technology,
					UniversityId = 1,
					PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true,
                    ProfilePictureUrl = "\\images\\user\\female-3.png",
                    IntroductionMessage = "I can help with: coursework, directions, budgeting, or just someone to talk to."
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
					Id = "6",
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
                    ProfilePictureUrl = "\\images\\user\\male-2.png",
                    IntroductionMessage = "Friendly 2nd year student offering to be a mentor, as an international student myself I've been in your shoes."
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
					Id = "7",
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
                    ProfilePictureUrl = "\\images\\user\\female-1.png",
                    IntroductionMessage = "hi, happy to help out with anything you need"
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
                    Id = "8",
                    UserName = "sven@example.com",
					Email = "sven@example.com",
					NormalizedEmail = "SVEN@EXAMPLE.COM",
					NormalizedUserName = "SVEN@EXAMPLE.COM",
					Name = "Sven Erikson",
					CourseName = "MSc Data Science",
					AreaOfStudy = AreaOfStudy.Technology,
					UniversityId = 1,
					PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true,
                    ProfilePictureUrl = "\\images\\user\\male-4.png",
                    IntroductionMessage = "hi, happy to help out with anything you need"
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
                    Id = "9",
                    UserName = "adenike@example.com",
					Email = "adenike@example.com",
					NormalizedEmail = "ADENIKE@EXAMPLE.COM",
					NormalizedUserName = "ADENIKE@EXAMPLE.COM",
					Name = "Adenike Oyetunde",
					CourseName = "MSc Advanced Computer Science",
					AreaOfStudy = AreaOfStudy.Technology,
					UniversityId = 1,
					PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true,
                    ProfilePictureUrl = "\\images\\user\\female-2.png",
                    IntroductionMessage = "I am a masters student from Nigeria. Please send me a request, we can help each other."
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
					Id = "10",
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
                    ProfilePictureUrl = "\\images\\user\\male-3.png",
                    IntroductionMessage = "hi, happy to help out with anything you need"
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
					Id = "11",
					UserName = "claire@example.com",
					Email = "claire@example.com",
					NormalizedEmail = "CLAIRE@EXAMPLE.COM",
					NormalizedUserName = "CLAIRE@EXAMPLE.COM",
					Name = "Claire Martin",
					CourseName = "BSc Information Technology",
					AreaOfStudy = AreaOfStudy.Technology,
					UniversityId = 1,
					PhoneNumber = "1234567890",
					PhoneNumberConfirmed = true,
                    ProfilePictureUrl = "\\images\\user\\female-4.png",
                    IntroductionMessage = "Hi. I can help you with studying and finding your way around. Please send me a request."
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
                    Id = "12",
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
                    ProfilePictureUrl = "\\images\\user\\male-3.png",
                    IntroductionMessage = "Hello! I can help you with studying and finding your way around. Please send me a request."
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
                    Id = "13",
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
                    ProfilePictureUrl = "\\images\\user\\male-2.png",
                    IntroductionMessage = "Hello! I can help you with studying and finding your way around. Please send me a request."
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				_userManager.CreateAsync(new Student
				{
                    Id = "14",
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
                    ProfilePictureUrl = "\\images\\user\\female-3.png",
                    IntroductionMessage = "I can help with: coursework, directions, budgeting, or just someone to talk to. Send me a request."
                }, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();

				var users = _context.Students.ToList();

				foreach (var user in users)
				{
					_userManager.AddToRoleAsync(user, Enums.Role.Mentor.ToString()).GetAwaiter().GetResult();
				}

                //create student
                var mentee = new Student
                {
                    Id = "15",
                    UserName = "user@example.com",
                    Email = "user@example.com",
                    NormalizedUserName = "USER@EXAMPLE.COM",
                    NormalizedEmail = "USER@EXAMPLE.COM",
                    Name = "Example User",
                    CourseName = "MSc Computing",
                    AreaOfStudy = AreaOfStudy.Technology,
                    UniversityId = 1,
					MentorId = "3",
                    PhoneNumber = "1234567890",
                    PhoneNumberConfirmed = true,
                    ProfilePictureUrl = "\\images\\user\\default.png",
                    IntroductionMessage = "I'm looking for someone to help me with studying."
                };
                var mentee2 = new Student
                {
                    Id = "16",
                    UserName = "ahmed@example.com",
                    Email = "ahmed@example.com",
                    NormalizedUserName = "AHMED@EXAMPLE.COM",
                    NormalizedEmail = "AHMED@EXAMPLE.COM",
                    Name = "Ahmed Rezai",
                    CourseName = "MSc Computing",
                    AreaOfStudy = AreaOfStudy.Technology,
                    UniversityId = 1,
                    PhoneNumber = "1234567890",
                    PhoneNumberConfirmed = true,
                    ProfilePictureUrl = "\\images\\user\\male-2.png",
                    IntroductionMessage = "I'm looking for someone to help me with studying, please connect with me."
                };
                _userManager.CreateAsync(mentee, "X32G#ILcWi^d5^P!").GetAwaiter().GetResult();
                _userManager.AddToRoleAsync(mentee, Enums.Role.Student.ToString()).GetAwaiter().GetResult();

                _userManager.CreateAsync(mentee2, "X32G#ILcWi^d5^P?").GetAwaiter().GetResult();
                _userManager.AddToRoleAsync(mentee2, Enums.Role.Student.ToString()).GetAwaiter().GetResult();
            }

			//create request
            if (!_context.ConnectionRequests.Any(x => x.StudentId == "16"))
            {
                var req = new ConnectionRequest
                {
                    Status = Status.Pending,
					StudentId = "16",
					MentorId = "3"
                };
                _context.ConnectionRequests.Add(req);
                _context.SaveChanges();
            }

            //create notifications
            if (!_context.Notifications.Any(x => x.FromUserId == "3"))
            {
                var noti = new Notification
                {
                    FromUserId = "3",
					ToUserId = "15",
					NotiHeader = "Connection request sent!",
					NotiBody = "Thanks for sending a connection request, the mentor will get back to you soon.",
					CreatedDate = DateTime.Now.AddDays(-2)
					
                };
                var noti2 = new Notification
                {
                    FromUserId = "3",
                    ToUserId = "15",
                    NotiHeader = "Connection request accepted!",
                    NotiBody = "Your connection request was accepted! Your new mentor has been added to Contacts.",
                    CreatedDate = DateTime.Now.AddDays(-1)

                };
                var noti3 = new Notification
                {
                    FromUserId = "16",
                    ToUserId = "3",
                    NotiHeader = "New connection request.",
                    NotiBody = "I'm looking for someone to help me with studying, please connect with me.",
                    CreatedDate = DateTime.Now.AddDays(-1)

                };
                _context.Notifications.Add(noti);
                _context.Notifications.Add(noti2);
                _context.Notifications.Add(noti3);
                _context.SaveChanges();
            }

            return;
			
		}
	}
}
