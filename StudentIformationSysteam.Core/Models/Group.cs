using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class Group:BaseEntity
    {
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public int CourseId{ get; set; }
        public Course Course { get; set; }
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
        public ICollection<Document> Documents { get; set; }
        public ICollection<GroupSubject> GroupSubjects { get; set; }
        public ICollection<UserGroup> UserGroups { get; set; }
    }
}
