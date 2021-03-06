using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class AppUser : IdentityUser

    {
        
        public ICollection<Lesson> Lessons { get; set; }
        public ICollection<UserExam> UserExams { get; set; }
       
        public ICollection<UserGroup> UserGroups { get; set; }
        public ICollection<SubjectTeacher> SubjectTeachers { get; set; }
      

        public int? CourseId { get; set; }
        public Course Course { get; set; }     
        public int? SpecialityId { get; set; }
        public Speciality Speciality { get; set; }
        public int? GenderId { get; set; }
        public Gender Gender { get; set; }
        public string Identifier { get; set; }
        public string FullName { get; set; }
      
        public string FatherName { get; set; }


    }
    public enum UserRoles
    {
        Admin,
        Teacher,
        Student,

    }

}
