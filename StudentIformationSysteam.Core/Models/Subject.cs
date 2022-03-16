using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class Subject:BaseEntity
    {
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
        public Semester Semester { get; set; }
        public int SemesterId { get; set; }
        public ICollection<GroupSubject> GroupSubjects { get; set; }
        public ICollection<SubjectExam> SubejctExams { get; set; }
        public ICollection<SubjectTeacher> SubjectTeachers { get; set; }

    }
}
