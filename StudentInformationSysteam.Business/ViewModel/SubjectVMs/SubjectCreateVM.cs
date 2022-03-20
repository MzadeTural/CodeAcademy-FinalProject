using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentInformationSysteam.Business.ViewModel.SubjectVMs
{
    public class SubjectCreateVM
    {
        [Required]
        public string Name { get; set; }
    }
}
