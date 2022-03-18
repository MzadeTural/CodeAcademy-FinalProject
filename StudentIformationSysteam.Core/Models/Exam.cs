using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class Exam:BaseEntity
    {
        public string Name { get; set; }
      
        
        public ICollection<UserExam> UserExams { get; set; }
        public ICollection<SubjectExam> SubejctExams{ get; set; }

    }
}
