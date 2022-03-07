using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentIformationSysteam.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace StudnetInformationSysteam.Data.DAL
{
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<GroupSubject> GroupSubjects { get; set; }
        public DbSet<Lessson> Lesssons { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectExam> SubjectExams{ get; set; }
        public DbSet<UserGroup> UserGroups{ get; set; }
        public DbSet<UserLesson> UserLessons { get; set; }

        



    }
}
