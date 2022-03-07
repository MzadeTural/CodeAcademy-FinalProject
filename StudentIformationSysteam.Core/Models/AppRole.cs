using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class AppRole:IdentityRole
    {
        public Group Group { get; set; }
        public int GroupId{ get; set; }
        public Subject Subject { get; set; }
        public int SubjectId { get; set; }

    }
}
