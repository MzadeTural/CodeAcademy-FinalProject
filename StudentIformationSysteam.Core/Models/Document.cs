using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class Document:BaseEntity
    {
        public string FilePath { get; set; }
        public string Title { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public Subject Subject { get; set; }
       
        public int SubjectId { get; set; }
    }
}
