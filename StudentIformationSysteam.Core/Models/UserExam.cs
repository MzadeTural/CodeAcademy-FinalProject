using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class UserExam:BaseEntity
    {
      
        public string AppUserId { get; set; }
        public int SubjectId{ get; set; }
        public AppUser AppUser { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public double Scoor { get; set; }
    }
}
