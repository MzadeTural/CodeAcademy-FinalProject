using StudentIformationSysteam.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInformationSysteam.Business.ViewModel.StudentProfile
{
    public class ProfileVM
    {
        public string FullName { get; set; }
        public int Identifier { get; set; }
        public string FateherName { get; set; }
        public bool Gender { get; set; }
        public string GroupName { get; set; }
        public AppUser Course { get; set; }

    }
}
