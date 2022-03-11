using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class Gender:BaseEntity
    {
        public string Name { get; set; }
        public AppUser AppUser { get; set; }
    }
}
