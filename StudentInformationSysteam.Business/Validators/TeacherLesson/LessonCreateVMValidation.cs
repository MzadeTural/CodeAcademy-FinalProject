using FluentValidation;
using StudentInformationSysteam.Business.ViewModel.TeacherLesson;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInformationSysteam.Business.Validators.TeacherLesson
{
    public class LessonCreateVMValidation : AbstractValidator<LessonCreateVM>
    {
        public LessonCreateVMValidation()
        {
            RuleFor(r => r.Name).NotNull().NotNull();
            RuleFor(r => r.AppUserId).NotNull().NotEmpty();
            RuleFor(r => r.LessonTypeId).NotNull().NotEmpty();
            RuleFor(r => r.Score).NotNull().NotEmpty();
        }
    }
}
