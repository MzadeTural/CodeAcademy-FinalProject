using FluentValidation;
using StudentInformationSysteam.Business.ViewModel.TeacherVMs;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInformationSysteam.Business.Validators.Teachers
{
    public class TeacherCreateVMValidation : AbstractValidator<TeacherCreateVM>
    {
        public TeacherCreateVMValidation()
        {
            RuleFor(r => r.FullName).NotNull().NotNull();
            RuleFor(r => r.FatherName).NotNull().NotEmpty();
            RuleFor(r => r.GenderId).NotNull().NotEmpty();
            RuleFor(r => r.UserName).NotNull().NotEmpty();
            RuleFor(r => r.Email).NotNull().NotEmpty();
           

        }
    }
}
