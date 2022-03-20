using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentInformationSysteam.Business.ViewModel.TeacherLesson
{
    public class LessonCreateVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public List<int> Score { get; set; }
        public int LessonTypeId { get; set; }
        public List<string> AppUserId { get; set; }
    }
}
