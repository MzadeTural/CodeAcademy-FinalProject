using StudentIformationSysteam.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInformationSysteam.Business.ViewModel.FacultyVM
{
    public class FacultyListVM
    {
        public List<Faculty> Faculties { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public int GroupCount { get; set; }
    }
}
