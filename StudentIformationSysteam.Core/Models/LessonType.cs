using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class LessonType:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Lesson> Lesson { get; set; }
    }
}
