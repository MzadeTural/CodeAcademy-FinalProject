using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class Subject:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Lessson> Lessons { get; set; }
        public Semester Semester { get; set; }
        public int SemesterId { get; set; }
        public ICollection<GroupSubject> GroupSubjects { get; set; }
        public ICollection<SubjectExam> SubejctExams { get; set; }
    }
}
