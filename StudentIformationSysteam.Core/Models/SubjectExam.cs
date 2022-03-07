using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class SubjectExam:BaseEntity
    {
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
    }
}
