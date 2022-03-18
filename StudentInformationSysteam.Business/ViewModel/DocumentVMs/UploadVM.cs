using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInformationSysteam.Business.ViewModel.DocumentVMs
{
    public class UploadVM
    {
        public string Title { get; set; }
        public IFormFile File { get; set; }
        
    }
}
