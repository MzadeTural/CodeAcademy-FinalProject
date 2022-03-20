using StudentIformationSysteam.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentInformationSysteam.Business.ViewModel.Student
{
    public class CreateVM
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string FatherName { get; set; }
        [Required]
        public int GenderId { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int SpecialityId { get; set; }
        [Required]
        public int CourseId { get; set; }
        public List<Gender> Genders { get; set; }

        [Required]
        public string Identifier { get; set; }

    }
}
