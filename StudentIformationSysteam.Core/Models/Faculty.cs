using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class Faculty:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}
