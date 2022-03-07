using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class UserGroup:BaseEntity
    {
        public string UserId { get; set; }
        public AppUser AppUser { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
