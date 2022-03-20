using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentInformationSysteam.Business.ViewModel.DocumentVMs
{
    public class UploadVM
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public IFormFile File { get; set; }
        
    }
}
