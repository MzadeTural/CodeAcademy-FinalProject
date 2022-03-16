using FluentValidation;
using StudentInformationSysteam.Business.ViewModel.FacultyVM;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInformationSysteam.Business.Validators.Faculty
{
    public class FacultyCreateVMValidation : AbstractValidator<FacultyUpdateVM>
    {
        public FacultyCreateVMValidation()
        {
            RuleFor(r => r.Name).NotNull().NotNull();

        }
    }
}
