using StudentIformationSysteam.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInformationSysteam.Business.ViewModel.Group
{
    public class GroupSubjectVM
    {
        public List<Subject> Subjects { get; set; }
        public List<AppUser> Teacher { get; set; }
    }
}
