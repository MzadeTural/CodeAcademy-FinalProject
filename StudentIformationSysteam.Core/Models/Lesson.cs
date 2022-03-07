using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class Lesson:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<UserLesson> UserLessons { get; set; }
        public Subject Subject { get; set; }
   
        public int SubjectId { get; set; }
    }
}
