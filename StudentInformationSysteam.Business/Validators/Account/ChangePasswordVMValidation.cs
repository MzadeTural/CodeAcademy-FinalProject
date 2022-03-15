using FluentValidation;
using StudentInformationSysteam.Business.ViewModel.Account;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInformationSysteam.Business.Validators.Account
{
    public class ChangePasswordVMValidation : AbstractValidator<ChangePasswordVM>
    {
        public ChangePasswordVMValidation()
        {

            RuleFor(x => x.CurrentPassword).NotEmpty().NotNull().MaximumLength(255);
            RuleFor(x => x.NewPassword).NotEmpty().NotNull().MaximumLength(255);
            RuleFor(x => x.ConfirmNewPassword).NotNull().NotEmpty().Equal(x => x.NewPassword)
                                                                                .WithMessage("Password is not equal");
        }
    }
}
