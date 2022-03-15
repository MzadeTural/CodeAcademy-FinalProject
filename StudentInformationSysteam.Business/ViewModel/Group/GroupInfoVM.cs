using System;
using System.Collections.Generic;
using System.Text;


namespace StudentInformationSysteam.Business.ViewModel.Group
{
    public class GroupInfoVM
    {
        public List<StudentIformationSysteam.Core.Models.Group> Groups { get; set; }
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string FacultyName { get; set; }
        public string Course { get; set; }
        
    }
}
