using System;
using System.Collections.Generic;
using System.Text;

namespace StudentIformationSysteam.Core.Models
{
    public class Notification:BaseEntity
    {
        public string Title { get; set; }
        public string Message { get; set; }
    }
}
