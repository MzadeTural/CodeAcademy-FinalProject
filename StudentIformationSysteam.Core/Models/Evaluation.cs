using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class Evaluation
    {
        public int Id { get; set; }
        public double Point { get; set; }
        public Exam Exam { get; set; }
        public int ExamId { get; set; }
    }
}
