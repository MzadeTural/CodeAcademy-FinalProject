using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentIformationSysteam.Core.Models;
using StudnetInformationSysteam.Data.Configurations;
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
      
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<GroupSubject> GroupSubjects { get; set; }
        public DbSet<Lesson> Lesssons { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectExam> SubjectExams{ get; set; }
        public DbSet<UserGroup> UserGroups{ get; set; }
        public DbSet<UserLesson> UserLessons { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<SubjectTeacher> SubjectTeachers { get; set; }
        public DbSet<UserExam> UserExams { get; set; }
        public DbSet<Document> Documents { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AttendanceConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new ExamConfiguration());
           
            modelBuilder.ApplyConfiguration(new FacultyConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new LessonConfiguration());
            modelBuilder.ApplyConfiguration(new SemesterConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
           
            base.OnModelCreating(modelBuilder);
        }



    }
}
