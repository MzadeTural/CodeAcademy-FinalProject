using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class Semester:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Subject> Subjects { get; set; }
    }
}
