using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class Course:BaseEntity
    {
        public string Name { get; set; }
      ICollection<AppUser> AppUsers { get; set; }
    }
}
