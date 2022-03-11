﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentInformationSysteam.Business.ViewModel.Student
{
    public class CreateVM
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string FatherName { get; set; }
        public int GenderId { get; set; }
        public int SpecialityId { get; set; }
        public int CourseId { get; set; }
      
       [RegularExpression(@"^[0-9]{0,8}$")]
        public string Identifier { get; set; }

    }
}
