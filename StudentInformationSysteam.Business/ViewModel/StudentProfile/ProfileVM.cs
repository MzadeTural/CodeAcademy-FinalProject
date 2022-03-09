﻿using StudentIformationSysteam.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInformationSysteam.Business.ViewModel.StudentProfile
{
    public class ProfileVM
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public AppUser GroupName { get; set; }
        public string Course { get; set; }

    }
}
