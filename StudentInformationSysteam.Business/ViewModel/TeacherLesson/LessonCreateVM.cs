using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInformationSysteam.Business.ViewModel.TeacherLesson
{
    public class LessonCreateVM
    {
        public string Name { get; set; }
        public List<int> Score { get; set; }
        public int LessonTypeId { get; set; }
        public List<string> AppUserId { get; set; }
    }
}
