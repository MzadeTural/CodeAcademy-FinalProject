using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class UserLesson : BaseEntity
    {
        public int LessonId { get; set; }
        public Lesson Lessson { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
