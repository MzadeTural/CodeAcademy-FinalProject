using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentInformationSysteam.Business.ViewModel.Group
{
    public class GroupCreateVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        public int FacultyId { get; set; }
    }
}
