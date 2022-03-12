using FluentValidation;
using StudentInformationSysteam.Business.ViewModel.Group;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInformationSysteam.Business.Validators.Group
{
    public class GroupCreateVMValidation:AbstractValidator<GroupCreateVM>
    {
        public GroupCreateVMValidation()
        {
            RuleFor(r => r.Name).NotNull().NotNull();
            RuleFor(r => r.FacultyId).NotNull().NotEmpty();
            RuleFor(r => r.CourseId).NotNull().NotEmpty();
        }
    }
}
