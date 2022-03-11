using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class Speciality:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<AppUser> AppUsers { get; set; }
    }
}
