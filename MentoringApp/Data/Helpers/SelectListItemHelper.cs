﻿using MentoringApp.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace MentoringApp.Data.Helpers
{
    public static class SelectListItemHelper
    {
        public static IEnumerable<SelectListItem> GetAreaOfStudySelectList()
        {
            var areaOfStudyList = new List<SelectListItem>();

            foreach (var field in typeof(AreaOfStudy).GetFields())
            {
                if (field.IsStatic && field.FieldType == typeof(string))
                {
                    var value = (string)field.GetValue(null);
                    areaOfStudyList.Add(new SelectListItem { Value = value, Text = value });
                }
            }

            return areaOfStudyList;
        }

        public static IEnumerable<SelectListItem> GetRolesSelectList()
        {
            var roles = new List<SelectListItem> 
            {
                new SelectListItem{Text = "Mentee", Value = "Student" },
				new SelectListItem{Text = "Mentor", Value = "Mentor" },

			};
            return roles;
        }
    }

    
}
