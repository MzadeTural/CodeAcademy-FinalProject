using StudentIformationSysteam.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInformationSysteam.Business.ViewModel.TeacherVMs
{
    public class TeacherCreateVM
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string FatherName { get; set; }
        public int GenderId { get; set; }
        public string Email { get; set; }
      
       


        public string Identifier { get; set; }

    }
}
