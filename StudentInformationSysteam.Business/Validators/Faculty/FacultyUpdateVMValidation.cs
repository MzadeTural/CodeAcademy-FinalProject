using FluentValidation;
using StudentInformationSysteam.Business.ViewModel.FacultyVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInformationSysteam.Business.Validators.Faculty
{
    public class FacultyUpdateVMValidation : AbstractValidator<FacultyUpdateVM>
    {
        public FacultyUpdateVMValidation()
        {
            RuleFor(r => r.Name).NotNull().NotNull();
        }
    }
}
