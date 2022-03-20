using StudentIformationSysteam.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentInformationSysteam.Business.ViewModel.FacultyVM
{
    public class FacultyListVM
    {
        public List<Faculty> Faculties { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Id { get; set; }
        [Required]
        public int GroupCount { get; set; }
    }
}
