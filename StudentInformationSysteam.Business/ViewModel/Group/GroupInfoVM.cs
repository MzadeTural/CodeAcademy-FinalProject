using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace StudentInformationSysteam.Business.ViewModel.Group
{
    public class GroupInfoVM
    {
        public List<StudentIformationSysteam.Core.Models.Group> Groups { get; set; }
        public int Id { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        public string FacultyName { get; set; }
        [Required]
        public string Course { get; set; }
        
    }
}
