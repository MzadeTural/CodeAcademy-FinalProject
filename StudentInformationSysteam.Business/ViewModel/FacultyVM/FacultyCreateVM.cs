using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentInformationSysteam.Business.ViewModel.FacultyVM
{
    public class FacultyCreateVM
    {
        [Required]
        public string Name{ get; set; }
    }
}
