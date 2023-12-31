﻿using MentoringApp.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace MentoringApp.Data.Models
{
    public class Student : IdentityUser
    {
        [Required(ErrorMessage = "Name is required.")]
        [PersonalData]
        public string Name { get; set; }

        [Required(ErrorMessage = "Course name is required.")]
        [DisplayName("Course name")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Please select an area of study.")]
        [DisplayName("Area of Study")]
        public string AreaOfStudy { get; set; }

        [Required(ErrorMessage = "Please select a university.")]
        public int UniversityId { get; set; }

        [Required]
        public virtual University University { get; set; }
        public string MentorId { get; set; }
        public virtual Student Mentor { get; set; }
        public virtual List<Student> Mentees { get; set; } = null;
        public virtual List<ConnectionRequest> SentConnectionRequests { get; set; } = new List<ConnectionRequest>();
        public virtual List<ConnectionRequest> ReceivedConnectionRequests { get; set; } = new List<ConnectionRequest>();
        public virtual List<Notification> SentNotifications { get; set; } =  new List<Notification>();
		public virtual List<Notification> ReceivedNotifications { get; set; } = new List<Notification>();
		public string ProfilePictureUrl { get; set; }
        public string IntroductionMessage { get; set; }
    }

    public class AreaOfStudy
    {
        public static readonly string CreativeArts = "Creative Arts";
        public static readonly string Languages = "Languages";
        public static readonly string ArtsAndHumanities = "Arts and Humanities";
        public static readonly string SocialSciences = "Social Sciences";
        public static readonly string Business = "Business";
        public static readonly string Science = "Science";
        public static readonly string Technology = "Technology";
        public static readonly string Maths = "Maths";
        public static readonly string Engineering = "Engineering";
        public static readonly string Health = "Health";
        public static readonly string Sport = "Sport";
        public static readonly string Other = "Other";
    }
}
