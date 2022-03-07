using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class Attendance:BaseEntity
    {
        public DateTime LessonDate { get; set; }
        public int LessonId { get; set; }
        public bool IsPresent { get; set; }
       
    }
}
