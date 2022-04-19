using StudentIformationSysteam.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInformationSysteam.Business.ViewModel.TeacherSubject
{
    public class SubjectDetailVM
    {
        public List<Lesson> Lessons { get; set; }
        public List<AppUser> Teachers { get; set; }
        public List<Document> Documents { get; set; }

    }
}
