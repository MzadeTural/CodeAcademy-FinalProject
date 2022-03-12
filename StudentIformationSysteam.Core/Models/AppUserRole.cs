using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class AppUserRole
    {
        public int Id { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string AppRoleId { get; set; }
        public AppRole AppRole { get; set; }
    }
}
