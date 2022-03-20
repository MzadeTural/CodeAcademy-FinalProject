    using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class Lesson:BaseEntity
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public LessonType LessonType { get; set; }
        public int LessonTypeId { get; set; }
        public AppUser AppUser { get; set; }
        public string AppUserId { get; set; }
        public Subject Subject { get; set; }
   
        public int SubjectId { get; set; }
    }
}
