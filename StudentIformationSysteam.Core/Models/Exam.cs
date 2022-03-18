﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class Exam:BaseEntity
    {
        public string Name { get; set; }
        public DateTime ExamDate { get; set; }
        public double point { get; set; }
        public AppUser AppUser { get; set; }
        public string UserId { get; set; }
        public ICollection<UserExam> UserExams { get; set; }
        public ICollection<SubjectExam> SubejctExams{ get; set; }

    }
}
