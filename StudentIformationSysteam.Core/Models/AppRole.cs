using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class AppRole:IdentityRole
    {
        public ICollection<AppUserRole> AppUserRoles{ get; set; }
    }
}
